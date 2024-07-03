using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ExpenseWindows.Controllers;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ExpenseWindows.ExternalExpenseMW
{
    public partial class ExternalExpenseMW : Form
    {
        ObjectDataService _objectDataService;
        List<Tuple<int, string>> _objects = new List<Tuple<int, string>>();

        ExpenseMWDataStructure _expenseMWDataStructure = new ExpenseMWDataStructure();
        ExpenseDataService _expenseDataService { get; set; }
        /// <summary>
        /// 1 - добавление / 0 - редактирование
        /// </summary>
        int _mode = -1;
        public ExternalExpenseMW()
        {
            InitializeComponent();
        }

        public ExternalExpenseMW(DataTable categoriesTable, FocusedExpense focusedExpense, ExpenseDataService expenseDataService,
            ObjectDataService objectDataService)
        {
            InitializeComponent();
            _expenseMWDataStructure.CategoriesTable = categoriesTable;
            _expenseMWDataStructure.FocusedExpense = focusedExpense;
            _expenseDataService = expenseDataService;
            _objectDataService = objectDataService;
            _mode = 0;
        }

        public ExternalExpenseMW(DataTable categoriesTable, ExpenseDataService expenseDataService, 
            ObjectDataService objectDataService)
        {
            InitializeComponent();
            _expenseMWDataStructure.CategoriesTable = categoriesTable;
            _expenseDataService = expenseDataService;
            _objectDataService = objectDataService;
            _mode = 1;
        }


        private void viewButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable =  _objectDataService.GetAllObjects(UserContext.Instance.CurrentUser.hoaId);
            ListObjects listObjects = new ListObjects(dataTable, _objects);
            listObjects.ShowDialog();
            _objects = listObjects.GetListObject();
            LoadDataSelectedObjects(_objects);
        }

        private void LoadDataSelectedObjects(List<Tuple<int,string>> list)
        {
            if(list.Count != 0)
            {
                textEditObjects.Text = list[0].Item2;
                for (int i = 1; i < list.Count; i++)
                {
                    textEditObjects.Text += ", " + list[i].Item2;
                }
            }
        }

        private void ExternalExpenseMW_Load(object sender, EventArgs e)
        {
            BindingDataCategoriesBox();
            if (_mode == 0)
            {
                labelControlWN.Text = "Изменение расхода";
                LoadDataInForms();
                LoadObjectData();
                universalButton.Click += EditExpense;
                viewButton.Visible = false;
            }
            else
            {
                labelControlWN.Text = "Создание расхода";
                universalButton.Click += AddExpense;
                periodTimeOffset.DateTimeOffset = DateTimeOffset.Now;
                _expenseMWDataStructure.FocusedExpense.CategoryId = (int)comboBoxCat.SelectedValue;
            }
        }
        public void BindingDataCategoriesBox()
        {
            comboBoxCat.DataSource = _expenseMWDataStructure.CategoriesTable;
            comboBoxCat.DisplayMember = "name";
            comboBoxCat.ValueMember = "id";
        }
        private void LoadDataInForms()
        {
            comboBoxCat.SelectedValue = _expenseMWDataStructure.FocusedExpense.CategoryId;
            periodTimeOffset.DateTimeOffset = _expenseMWDataStructure.FocusedExpense.Period;
            textEditName.Text = _expenseMWDataStructure.FocusedExpense.ExpenseName;
            spinEditQuantity.Value = ((decimal)_expenseMWDataStructure.FocusedExpense.Quantity);
            spinEditCost.Value = ((decimal)_expenseMWDataStructure.FocusedExpense.Cost);
            textEditResultCost.Text = _expenseMWDataStructure.FocusedExpense.ResultCost.ToString();
            textEditObjects.Text = _expenseMWDataStructure.FocusedExpense.ObjectName;
            _objects.Add(new Tuple<int,string>(_expenseMWDataStructure.FocusedExpense.ObjectId, _expenseMWDataStructure.FocusedExpense.ObjectName));
        }
        private void LoadObjectData()
        {
            int objectdId = _expenseMWDataStructure.FocusedExpense.ObjectId;
            DataTable dataTable = _objectDataService.GetObject(objectdId);
        }

        private void AddExpense(object sender, EventArgs e)
        {
            foreach(Tuple<int,string> tuple in _objects)
            {
                _expenseMWDataStructure.FocusedExpense.ObjectId = tuple.Item1;
                _expenseDataService.AddExternalExpense(_expenseMWDataStructure.FocusedExpense);
            }
            this.Close();
        }

        private void EditExpense(object sender, EventArgs e)
        {
            foreach (Tuple<int, string> tuple in _objects)
            {
                _expenseMWDataStructure.FocusedExpense.ObjectId = tuple.Item1;
                _expenseDataService.EditExternalExpense(_expenseMWDataStructure.FocusedExpense);
            }
            this.Close();
        }

        private void comboBoxCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _expenseMWDataStructure.FocusedExpense.CategoryId = (int)comboBoxCat.SelectedValue;
        }

        private void periodTimeOffset_EditValueChanged(object sender, EventArgs e)
        {
            _expenseMWDataStructure.FocusedExpense.Period = periodTimeOffset.DateTimeOffset.Date;
        }

        private void textEditName_EditValueChanged(object sender, EventArgs e)
        {
            _expenseMWDataStructure.FocusedExpense.ExpenseName = textEditName.Text;
        }

        private void spinEditQuantity_EditValueChanged(object sender, EventArgs e)
        {
            _expenseMWDataStructure.FocusedExpense.Quantity = (float)spinEditQuantity.Value;
            CalculateResultCost();
            ShowResultCost();
        }

        private void spinEditCost_EditValueChanged(object sender, EventArgs e)
        {
            _expenseMWDataStructure.FocusedExpense.Cost = (float)spinEditCost.Value;
            CalculateResultCost();
            ShowResultCost();
        }
        private void CalculateResultCost()
        {
            _expenseMWDataStructure.FocusedExpense.ResultCost = ((float)(spinEditQuantity.Value * spinEditCost.Value));
        }

        private void ShowResultCost()
        {
            textEditResultCost.Text = _expenseMWDataStructure.FocusedExpense.ResultCost.ToString();
        }
    }
}
