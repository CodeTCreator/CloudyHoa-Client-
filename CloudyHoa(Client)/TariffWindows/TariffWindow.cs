using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.SaveExecuteControl;
using CloudyHoa_Client_.TariffWindows.Controllers;
using CloudyHoa_Client_.TariffWindows.MW;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.TariffWindows
{
    public partial class TariffWindow : Form, ISafeExecuteControl
    {
        TariffWindowController _controller;
        TariffDataService _dataService;
        TariffDataStructure _dataStructure;

        public Control ContainerForLoading => this;
        public Control LockControl => panelControl;

        public TariffWindow()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private async void TariffWindow_Load(object sender, EventArgs e)
        {
            _controller = new TariffWindowController();
            _dataService = new TariffDataService();
            _dataStructure = new TariffDataStructure();
            await LoadData();
            BindingData();
        }
        private async Task LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await _controller.LoadDataTOTableAsync(_dataService, _dataStructure);
                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }
        private void BindingData()
        {
            BindingTOTable();
            BindingTariffsTable();
        }
        private void BindingTOTable()
        {
            treeListTO.DataSource = _controller.GetTOTable(_dataStructure);
        }
        private void BindingTariffsTable()
        {
            gridControlTariffs.DataSource = _controller.GetTariffTable(_dataStructure);  
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {
                int tariffId = (int)gridView1.GetFocusedRowCellValue("id");
                _controller.DeleteTariff(_dataService, tariffId);
                await UpdateData();
            }
        }

        private async Task UpdateData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await _controller.LoadDataTariffTableAsync(_dataService, _dataStructure);
                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
            BindingTariffsTable();
        }

        private async void treeListTO_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if(treeListTO.GetFocusedRowCellValue("id")!= null)
            {
                _controller.SetCurrentTypeObject((int)treeListTO.GetFocusedRowCellValue("id"),_dataStructure);
                await UpdateData();
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            TariffMW tariffMW = new TariffMW(_dataService, new FocusedObject()
            { typeObject = _controller.GetCurrrentTypeObject(_dataStructure),
              nameType = treeListTO.GetFocusedRowCellValue("name").ToString() 
            });
            tariffMW.ShowDialog();
            await UpdateData();
        }

        private async void changeButton_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("id") != null)
            {
                Tariff tariff = new Tariff()
                {
                    Id = (int)gridView1.GetFocusedRowCellValue("id"),
                    Name = gridView1.GetFocusedRowCellValue("name").ToString(),
                    Value = float.Parse(gridView1.GetFocusedRowCellValue("value").ToString()),
                    metadataId = (int)gridView1.GetFocusedRowCellValue("metadata_id")
                };
                TariffMW tariffMW = new TariffMW(tariff, _dataService, new FocusedObject()
                {
                    typeObject = _controller.GetCurrrentTypeObject(_dataStructure),
                    nameType = treeListTO.GetFocusedRowCellValue("name").ToString()
                });
                tariffMW.ShowDialog();
                await UpdateData();
            }
            else
            {
                MessageBox.Show("Тариф не выбран", "Ошибка",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
            
        }

        private async void repositoryDeleteButton_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {
                int tariffId = (int)gridView1.GetFocusedRowCellValue("id");
                _controller.DeleteTariff(_dataService, tariffId);
                await UpdateData();
            }
        }
    }
}
