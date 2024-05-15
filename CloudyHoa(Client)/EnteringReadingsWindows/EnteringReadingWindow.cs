using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.EnteringReadingsWindows.Controllers;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.Properties;
using CloudyHoa_Client_.SaveExecuteControl;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.EnteringReadingsWindows
{
    public partial class EnteringReadingWindow : Form, ISafeExecuteControl
    {
        ERDataStructure _structure;
        ERWindowController _controller;
        ObjectDataService _objectDataService;
        ObjectDataStructure _objectDataStructure;
        MetadataDataService _metadataDataService;
        DPsDataStructure _dynamicParamsDataStructure;
        DynamicParamsDataService _dynamicParamsDataService;

        public Control ContainerForLoading => this;

        public Control LockControl => panelControlMain;

        public EnteringReadingWindow()
        {
            InitializeComponent();
        }

        private void resetServicesButton_Click(object sender, EventArgs e)
        {
            comboBoxServices.SelectedValue = -1;
            _structure.FocusedService = -1;

            ReloadDPTable();
            BindingDPsTable(_structure.TemporaryDPTable);
            //SetObjectFilter();
            // Применить фильтр к таблице

        }
        private void ReloadDPTable()
        {
            _structure.TemporaryDPTable = _dynamicParamsDataStructure.OldDynamicParams.Copy();
            AddNewColumns();
        }
        private void AddNewColumns()
        {
            _structure.TemporaryDPTable.Columns.AddRange(
                new[] {
                    new DataColumn("curr_period", typeof(DateTime)),
                    new DataColumn("curr_value", typeof(float))
                });
            foreach (DataRow row in _structure.TemporaryDPTable.Rows)
            {
                row["curr_period"] = _structure.CurrentDate;
            }
        }

        private async void comboBoxParentObject_SelectionChangeCommitted(object sender, EventArgs e)
        {

            _objectDataStructure.FocusedObject.objectId = (int)comboBoxParentObject.SelectedValue;
            await GeneralLoadData.LoadData(this, _controller.LoadChildsTypesAsync, _structure, _objectDataService,
                _controller.GetTypeObject(_structure,_objectDataStructure));
            BindingChildsTypes();

            ResetDPData();
            ResetObjectsData();

            ReloadDPTable();
            BindingDPsTable(_structure.TemporaryDPTable);
        }

        private void ResetDPData()
        {
            _dynamicParamsDataStructure.OldDynamicParams.Clear();
        }
        private void ResetObjectsData()
        {
            _objectDataStructure.DataTable.Clear();
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            _structure.CurrentDate = dateEdit.DateTime;
        }

        private async void EnteringReadingWindow_Load(object sender, EventArgs e)
        {
            _structure = new ERDataStructure();
            _controller = new ERWindowController();
            _objectDataService = new ObjectDataService();
            _objectDataStructure = new ObjectDataStructure();
            _metadataDataService = new MetadataDataService();
            _dynamicParamsDataService = new DynamicParamsDataService();
            _dynamicParamsDataStructure = new DPsDataStructure();

            dateEdit.EditValue = DateTime.Now;


            //treeListControlObjects.TreeClick += objectControl_Click;
            await LoadData();
            BindingMainObjects();
        }

        private void SaveButtonEnable(object sender, DataRowChangeEventArgs e)
        {
            if(saveButton.Enabled == false)
            {
                saveButton.Enabled = true;
            }
        }

        private async Task LoadData()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadMainObjectsAsync, _structure, _objectDataService);
        }

        private void BindingMainObjects()
        {
            comboBoxParentObject.DataSource = _controller.GetMainObjectsTable(_structure);
            comboBoxParentObject.DisplayMember = "name";
            comboBoxParentObject.ValueMember = "id";
            comboBoxParentObject.SelectedIndex = -1;
        }
        private void BindingChildsTypes()
        {
            comboBoxTypesObjects.DataSource = _controller.GetChildObjectsTable(_structure);
            comboBoxTypesObjects.DisplayMember = "name";
            comboBoxTypesObjects.ValueMember = "id";
        }

        private async void comboBoxTypesObjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _objectDataStructure.FocusedObject.typeObject = (int)comboBoxTypesObjects.SelectedValue;

            // Загрузка объектов и сервисов
            await GeneralLoadData.LoadData(this, _controller.LoadChildsObjectsAsync, _objectDataStructure, _objectDataService,
                _objectDataStructure.FocusedObject.objectId, _objectDataStructure.FocusedObject.typeObject);


            await GeneralLoadData.LoadData(this, _controller.LoadServicesAsync, _structure, _metadataDataService,
             _objectDataStructure.FocusedObject.typeObject);

            await UpdateDPData();


            BindingServicesComboBox();


            ReloadDPTable();
            BindingDPsTable(_structure.TemporaryDPTable);

            // Проверка на уже введенные данные и создание таблицы, если не было прежде
            if (_structure.EnteringTable.Columns.Count == 0)
            {
                _structure.EnteringTable = _structure.TemporaryDPTable.Clone();
            }
            _controller.CheckAndLoadEnteringData(_structure.TemporaryDPTable, _structure.EnteringTable);
            _structure.EnteringTable.RowChanged += SaveButtonEnable;
            //SetObjectFilter();
            //SetServiceFilter();
        }
        private void BindingServicesComboBox()
        {
            comboBoxServices.DataSource = _controller.GetServicesTable(_structure);
            comboBoxServices.DisplayMember = "property_name";
            comboBoxServices.ValueMember = "id";
            comboBoxServices.SelectedValue = -1;
        }
        private void BindingDPsTable(DataTable dataTable)
        {
            gridControlReadings.DataSource = dataTable;
        }

        private void comboBoxServices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _structure.FocusedService = (int)comboBoxServices.SelectedValue;
            ReloadDPTable();
            SetServiceFilter();
            ResetAllWarnings();
        }
        private void SetServiceFilter()
        {
            if (_structure.FocusedService != -1)
            {
                DataRow[] results = _structure.TemporaryDPTable.Select("property_id =" + _structure.FocusedService);
                if (results.Length > 0)
                {
                    _structure.TemporaryDPTable = results.CopyToDataTable();
                }
                else
                {
                    _structure.TemporaryDPTable.Clear();
                }
                //_structure.TemporaryDPTable = results.Length > 0 ? results.CopyToDataTable() : null;
                BindingDPsTable(_structure.TemporaryDPTable);
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (!_controller.CheckEnteringDataValue(_structure.TemporaryDPTable))
            {

                DialogResult dialogResult = MessageBox.Show(
                    "Имеется несоответствие в введенных показаниях!\n Сохранить такие данные?",
                    "Внимание!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (dialogResult == DialogResult.No)
                {
                    flag = false;
                }
            }
            if (!_controller.CheckEnteringDataDate(_structure.TemporaryDPTable))
            {

                DialogResult dialogResult = MessageBox.Show(
                    "Имеется несоответствие в введенных датах!\n Сохранить такие данные?",
                    "Внимание!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (dialogResult == DialogResult.No)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                _controller.AddERs(_structure.EnteringTable, _dynamicParamsDataService);
                await UpdateDPData();
                ReloadDPTable();
                BindingDPsTable(_structure.TemporaryDPTable);
            }
        }

        private void gridViewReadings_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow focusedRow;
            int rowCount;
            rowCount = gridViewReadings.GetFocusedDataSourceRowIndex();
            focusedRow = gridViewReadings.GetDataRow(rowCount);

            // Работа с показаниями (проверка и вывод предупреждения)
            if (focusedRow["curr_value"].GetType() != typeof(System.DBNull))
            {
                _controller.AddOrUpdateDP(focusedRow, _structure.EnteringTable);
            }
            else
            {
                _controller.CheckAndDeleteEnteringRow(focusedRow, _structure.EnteringTable);
                if (!_controller.CheckTableRows(_structure.EnteringTable))
                {
                    saveButton.Enabled = false;
                }
            }
            
            // Проверка ячеек
            if (_controller.CheckEnteringDataValue(_structure.TemporaryDPTable))
            {
                svgImageBoxWarningValue.Visible = false;
            }
            else
            {
                svgImageBoxWarningValue.Visible = true;
            }

            // Установка даты по умолчанию, если дату удалили
            if (focusedRow["curr_period"].GetType() == typeof(System.DBNull))
            { focusedRow["curr_period"] = _controller.GetDate(_structure); }

            // Проверка ячеек
            if (_controller.CheckEnteringDataDate(_structure.TemporaryDPTable))
            {
                svgImageBoxWarningData.Visible = false;
            }
            else
            {
                svgImageBoxWarningData.Visible = true;
            }
        }

        /// <summary>
        /// Метод, который подсвечивает ячейки таблицы, где неправильные данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewReadings_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            ///
            /// Проверка показаний и подсветка неправильных строк
            ///
            if (view.GetRowCellValue(e.RowHandle, view.Columns["curr_value"]).GetType() != typeof(System.DBNull))
            {
                if (!_controller.CheckCurrentValue(view.GetDataRow(e.RowHandle)) &
                (e.Column.FieldName == "curr_value" || e.Column.FieldName == "value"))
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.DefaultDraw();
                    if (!svgImageBoxWarningValue.Visible) { svgImageBoxWarningValue.Visible = true; }
                }
            }

            ///
            /// Проверка дат и подсветка неправильных строк
            ///
            if (view.GetRowCellValue(e.RowHandle, view.Columns["curr_period"]).GetType() != typeof(System.DBNull))
            {
                if (!_controller.CheckCurrentDate(view.GetDataRow(e.RowHandle)) &
                (e.Column.FieldName == "curr_period" || e.Column.FieldName == "period"))
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.DefaultDraw();
                    if (!svgImageBoxWarningData.Visible) { svgImageBoxWarningData.Visible = true; }
                }
            }
        }
        private void ResetAllWarnings()
        {
            svgImageBoxWarningData.Visible = false;
            svgImageBoxWarningValue.Visible = false;
        }

        private async Task UpdateDPData()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadOldDynamicParams, _dynamicParamsDataStructure, _dynamicParamsDataService,
             _objectDataStructure.FocusedObject.objectId, _objectDataStructure.FocusedObject.typeObject);
        }
    }
}
