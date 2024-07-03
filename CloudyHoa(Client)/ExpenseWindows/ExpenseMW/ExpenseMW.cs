using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ExpenseWindows.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ExpenseWindows.ExpenseMW
{
    public partial class ExpenseMW : Form
    {
        ExpenseMWDataStructure _expenseMWDataStructure = new ExpenseMWDataStructure();
        ExpenseDataService _expenseDataService { get; set; }
        /// <summary>
        /// 1 - добавление / 0 - редактирование
        /// </summary>
        int _mode = -1;
        public ExpenseMW()
        {
            InitializeComponent();
        }

        public ExpenseMW(DataTable categoriesTable, FocusedExpense focusedExpense, ExpenseDataService expenseDataService)
        {
            InitializeComponent();
            _expenseMWDataStructure.CategoriesTable = categoriesTable;
            _expenseMWDataStructure.FocusedExpense = focusedExpense;
            _expenseDataService = expenseDataService;
            _mode = 0;
        }

        public ExpenseMW(DataTable categoriesTable, ExpenseDataService expenseDataService)
        {
            InitializeComponent();
            _expenseMWDataStructure.CategoriesTable = categoriesTable;
            _expenseDataService = expenseDataService;
            _mode = 1;
        }

        private void ExpenseMW_Load(object sender, EventArgs e)
        {
            BindingDataCategoriesBox();
            if(_mode == 0)
            {
                labelControlWN.Text = "Изменение расхода";
                LoadDataInForms();
                universalButton.Click += EditExpense;
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

        private void AddExpense(object sender, EventArgs e)
        {
            _expenseDataService.AddExpense(_expenseMWDataStructure.FocusedExpense);
            this.Close();
        }

        private void EditExpense(object sender, EventArgs e)
        {
            _expenseDataService.EditExpense(_expenseMWDataStructure.FocusedExpense);
            this.Close();
        }
    }
}
