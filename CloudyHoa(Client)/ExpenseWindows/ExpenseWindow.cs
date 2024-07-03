using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ExpenseWindows.Controllers;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ExpenseWindows
{
    public partial class ExpenseWindow : Form, ISafeExecuteControl
    {
        ObjectDataService _objectDataService;
        ExpenseDataService _expenseDataService;
        ExpenseWindowController _controller;
        ExpenseDataStructure _expenseDataStructure;

        public Control ContainerForLoading => this;

        public Control LockControl => panelControl;

        public ExpenseWindow()
        {
            InitializeComponent();
        }

        private async void addCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryMW.CategoryMW categoryMW = new CategoryMW.CategoryMW(_expenseDataService);
            categoryMW.ShowDialog();
            await LoadDataCategory();
            BindingCategoriesTable();
        }

        private async void editCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryMW.CategoryMW categoryMW = new CategoryMW.CategoryMW(_controller.GetFocusedCategory(_expenseDataStructure), _expenseDataService);
            categoryMW.ShowDialog();
            await LoadDataCategory();
            BindingCategoriesTable();
        }

        private async void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            _controller.DeleteCategory(_expenseDataService, _controller.GetFocusedCategory(_expenseDataStructure));
            await LoadDataCategory();
            BindingCategoriesTable();
        }

        private void gridControlCategory_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {
                _controller.SetFocusedCategory(_expenseDataStructure, new FocusedCategory
                {
                    Id = (int)gridView1.GetFocusedRowCellValue("id")
                    ,
                    Name = gridView1.GetFocusedRowCellValue("name").ToString()
                });
                editCategoryButton.Enabled = true;
                deleteCategoryButton.Enabled = true;
            }
        }

        private async void ExpenseWindow_Load(object sender, EventArgs e)
        {
            _expenseDataService = new ExpenseDataService();
            _controller = new ExpenseWindowController();
            _expenseDataStructure = new ExpenseDataStructure();
            _objectDataService = new ObjectDataService();
            await LoadData();
            BindingData();
        }

        private async Task LoadData()
        {
            await LoadDataCategory();
            await LoadDataInnerExpenses();
            await LoadDataExternalExpenses();
        }

        private async Task LoadDataCategory()
        {
            await General.GeneralLoadData.LoadData(this, _controller.LoadCategoryTable, _expenseDataStructure, _expenseDataService);
        }

        private async Task LoadDataInnerExpenses()
        {
            await General.GeneralLoadData.LoadData(this, _controller.LoadInnerExpensesTable, _expenseDataStructure, _expenseDataService);
        }
        private async Task LoadDataExternalExpenses()
        {
            await General.GeneralLoadData.LoadData(this, _controller.LoadExternalExpensesTable, _expenseDataStructure, _expenseDataService);
        }

        private void BindingData()
        {
            BindingCategoriesTable();
            BindingInnerExpensesTable(_controller.GetInnerExpenseTable(_expenseDataStructure));
            BindingExternalExpensesTable(_controller.GetExternalExpenseTable(_expenseDataStructure));
        }
        private void BindingCategoriesTable()
        {
            gridControlCategory.DataSource = _expenseDataStructure.CategoryTable;
        }
        private void BindingInnerExpensesTable(DataTable dataTable)
        {
            gridControlInnerExpenses.DataSource = dataTable;
            CalculateInnerCost(dataTable);
        }
        private void BindingExternalExpensesTable(DataTable dataTable)
        {
            gridControlExternalExpenses.DataSource = dataTable;
            CalculatExternalCost(dataTable);
        }

        private void CalculateInnerCost(DataTable dataTable)
        {
            _controller.SetInnerCost(_expenseDataStructure, dataTable != null ? _controller.CalculateCost(dataTable) : 0);
            SetInnerCostText();
            CalculateResultCost();
        }
        private void SetInnerCostText()
        {
            labelControlInnerResult.Text = "Сумма внутренних расходов: " +
                 _controller.GetInnerCost(_expenseDataStructure).ToString();
        }
        private void CalculatExternalCost(DataTable dataTable)
        {
            _controller.SetExternalCost(_expenseDataStructure, dataTable != null ? _controller.CalculateCost(dataTable) : 0);
            SetExternalCostText();
            CalculateResultCost();
        }
        private void SetExternalCostText()
        {
            labelControlExternalResult.Text = "Сумма расходов: " +
                 _controller.GetExternalCost(_expenseDataStructure).ToString();
        }
        private void CalculateResultCost()
        {
            _controller.SetResultCost(_expenseDataStructure,
                _controller.CalculateAllCost(
                    _controller.GetInnerCost(_expenseDataStructure),
                    _controller.GetExternalCost(_expenseDataStructure)
                ));
            SetResultCostText();
        }
        private void SetResultCostText()
        {
            labelControlResultCost.Text = "Общая сумма расходов: " +
                 _controller.GetResultCost(_expenseDataStructure).ToString();
        }


        private async void deleteExpenseButton_Click(object sender, EventArgs e)
        {
            _controller.DeleteExpense(_expenseDataService,_controller.GetFocusedExpense(_expenseDataStructure));
            await UpdateInternalExpenses();
        }

        private async void addExpenseButton_Click(object sender, EventArgs e)
        {
            ExpenseMW.ExpenseMW expenseMW = new ExpenseMW.ExpenseMW(_controller.GetCategoryTable(_expenseDataStructure),_expenseDataService);
            expenseMW.ShowDialog();
            await UpdateInternalExpenses();
        }

        private async void editExpenseButton_Click(object sender, EventArgs e)
        {
            ExpenseMW.ExpenseMW expenseMW = new ExpenseMW.ExpenseMW(_controller.GetCategoryTable(_expenseDataStructure), 
                _controller.GetFocusedExpense(_expenseDataStructure), _expenseDataService);
            expenseMW.ShowDialog();
            await UpdateInternalExpenses();
        }

        private async void updateIEButton_Click(object sender, EventArgs e)
        {
            await UpdateInternalExpenses();
        }

        private async Task UpdateInternalExpenses()
        {
            await LoadDataInnerExpenses();
            BindingInnerExpensesTable(_controller.GetInnerExpenseTable(_expenseDataStructure));
        }

        private void gridControlInnerExpenses_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("id") != null)
            {
                _expenseDataStructure.FocusedExpense.Id = (int)gridView2.GetFocusedRowCellValue("id");
                _expenseDataStructure.FocusedExpense.CategoryId = (int)gridView2.GetFocusedRowCellValue("category_id");
                _expenseDataStructure.FocusedExpense.CategoryName = gridView2.GetFocusedRowCellValue("name1").ToString();
                _expenseDataStructure.FocusedExpense.ExpenseName = gridView2.GetFocusedRowCellValue("name").ToString();
                _expenseDataStructure.FocusedExpense.Quantity = float.Parse(gridView2.GetFocusedRowCellValue("quantity").ToString());
                _expenseDataStructure.FocusedExpense.Cost = float.Parse(gridView2.GetFocusedRowCellValue("cost").ToString());
                _expenseDataStructure.FocusedExpense.ResultCost = float.Parse(gridView2.GetFocusedRowCellValue("result_cost").ToString());
                _expenseDataStructure.FocusedExpense.Period = DateTime.Parse(gridView2.GetFocusedRowCellValue("date").ToString());

                editInnerExpenseButton.Enabled = true;
                deleteInnerExpenseButton.Enabled= true;
            }
        }

        private void clearPeriodFilterButton_Click(object sender, EventArgs e)
        {
            periodEdit.EditValue = null;
            BindingInnerExpensesTable(_controller.GetInnerExpenseTable(_expenseDataStructure));
            BindingExternalExpensesTable(_controller.GetExternalExpenseTable(_expenseDataStructure));
        }

        private DataTable ApplyDateTimeFilter(DataTable dataTable, DateTime dateTime)
        {
            return _controller.SetDateTimeFilter(
                dataTable, dateTime);
           
        }
        private void periodEdit_EditValueChanged(object sender, EventArgs e)
        {
            _controller.SetDateTimeFilter(_expenseDataStructure, periodEdit.DateTimeOffset.DateTime);
           DataTable filteredInnerTable =  ApplyDateTimeFilter(_controller.GetInnerExpenseTable(_expenseDataStructure),
                _controller.GetDateTimeFilter(_expenseDataStructure));
            BindingInnerExpensesTable((filteredInnerTable));

            DataTable filteredExternalTable = ApplyDateTimeFilter(_controller.GetExternalExpenseTable(_expenseDataStructure),
                _controller.GetDateTimeFilter(_expenseDataStructure));
            BindingExternalExpensesTable((filteredExternalTable));
        }

        private async void addExternalButton_Click(object sender, EventArgs e)
        {
            ExternalExpenseMW.ExternalExpenseMW externalExpenseMW = new ExternalExpenseMW.ExternalExpenseMW(_controller.GetCategoryTable(_expenseDataStructure), 
                _expenseDataService,_objectDataService);
            externalExpenseMW.ShowDialog();
            await UpdateExternalExpenses();
        }

        private void gridControlExternalExpenses_Click(object sender, EventArgs e)
        {
            if (gridView3.GetFocusedRowCellValue("id") != null)
            {
                _expenseDataStructure.FocusedExpense.Id = (int)gridView3.GetFocusedRowCellValue("id");
                
                _expenseDataStructure.FocusedExpense.CategoryId = gridView3.GetFocusedRowCellValue("category_id").GetType() != DBNull.Value.GetType() ? 
                    (int)gridView3.GetFocusedRowCellValue("category_id") : 
                    -1;
                _expenseDataStructure.FocusedExpense.CategoryName = gridView3.GetFocusedRowCellValue("name1").ToString();
                _expenseDataStructure.FocusedExpense.ExpenseName = gridView3.GetFocusedRowCellValue("name").ToString();
                _expenseDataStructure.FocusedExpense.Quantity = float.Parse(gridView3.GetFocusedRowCellValue("quantity").ToString());
                _expenseDataStructure.FocusedExpense.Cost = float.Parse(gridView3.GetFocusedRowCellValue("cost").ToString());
                _expenseDataStructure.FocusedExpense.ResultCost = float.Parse(gridView3.GetFocusedRowCellValue("result_cost").ToString());
                _expenseDataStructure.FocusedExpense.Period = DateTime.Parse(gridView3.GetFocusedRowCellValue("date").ToString());
                _expenseDataStructure.FocusedExpense.ObjectId = (int)gridView3.GetFocusedRowCellValue("object_id");
                _expenseDataStructure.FocusedExpense.ObjectName = gridView3.GetFocusedRowCellValue("name2").ToString() + " " 
                    +  gridView3.GetFocusedRowCellValue("identificator").ToString();
                editExternalExpenseButton.Enabled = true;
                deleteExternalExpenseButton.Enabled = true;
            }
        }

        private async void editExternalButton_Click(object sender, EventArgs e)
        {
             ExternalExpenseMW.ExternalExpenseMW externalExpenseMW = new ExternalExpenseMW.ExternalExpenseMW(_controller.GetCategoryTable(_expenseDataStructure),
               _controller.GetFocusedExpense(_expenseDataStructure), _expenseDataService, _objectDataService);
            externalExpenseMW.ShowDialog();
            await UpdateExternalExpenses();
        }

        private async void deleteExternalButton_Click(object sender, EventArgs e)
        {
            _controller.DeleteExpense(_expenseDataService, _controller.GetFocusedExpense(_expenseDataStructure));
            await UpdateExternalExpenses();
        }

        private async void updateEEButton_Click(object sender, EventArgs e)
        {
            await UpdateExternalExpenses();
        }

        private async Task UpdateExternalExpenses()
        {
            await LoadDataExternalExpenses();
            BindingExternalExpensesTable(_controller.GetExternalExpenseTable(_expenseDataStructure));
        }


    }
}
