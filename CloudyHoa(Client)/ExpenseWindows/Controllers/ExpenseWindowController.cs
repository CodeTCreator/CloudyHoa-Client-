using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ExpenseWindows.Controllers
{
    internal class ExpenseWindowController
    {
        public ExpenseWindowController() { }

        public FocusedCategory GetFocusedCategory(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.FocusedCategory;
        }
        public FocusedExpense GetFocusedExpense(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.FocusedExpense;
        }

        public DataTable GetCategoryTable(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.CategoryTable;
        }
        
        public async Task LoadCategoryTable(IDataService dataService,IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ExpenseDataService) ?
                await ((ExpenseDataService)dataService).GetCategories() : null;
            dataTable.TableName = "Categories";
            if (dataStructure.GetType() == typeof(ExpenseDataStructure))
            {
                ((ExpenseDataStructure)dataStructure).CategoryTable = dataTable;
            }
        }

        public async Task LoadInnerExpensesTable(IDataService dataService,IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ExpenseDataService) ?
                await ((ExpenseDataService)dataService).GetInternalExpenses() : null;
            dataTable.TableName = "Expenses";
            if (dataStructure.GetType() == typeof(ExpenseDataStructure))
            {
                ((ExpenseDataStructure)dataStructure).InnerExpenseTable = dataTable;
            }
        }
        public async Task LoadExternalExpensesTable(IDataService dataService, IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ExpenseDataService) ?
                await ((ExpenseDataService)dataService).GetExternalExpenses() : null;
            dataTable.TableName = "Expenses";
            if (dataStructure.GetType() == typeof(ExpenseDataStructure))
            {
                ((ExpenseDataStructure)dataStructure).ExternalExpenseTable = dataTable;
            }
        }


        public void SetCategoryTable(ExpenseDataStructure expenseDataStructure, DataTable dataTable)
        {
            expenseDataStructure.CategoryTable = dataTable;
        }

        public DataTable GetInnerExpenseTable(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.InnerExpenseTable;
        }
        public DataTable GetExternalExpenseTable(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.ExternalExpenseTable;
        }

        public void SetInnerExpenseTable(ExpenseDataStructure expenseDataStructure, DataTable dataTable)
        {
            expenseDataStructure.InnerExpenseTable = dataTable;
        }
        public void SetExternalExpenseTable(ExpenseDataStructure expenseDataStructure, DataTable dataTable)
        {
            expenseDataStructure.ExternalExpenseTable = dataTable;  
        }

        public void SetFocusedCategory(ExpenseDataStructure expenseDataStructure, FocusedCategory focusedCategory)
        {
            expenseDataStructure.FocusedCategory = focusedCategory;
        }

        public void SetFocusedExpense(ExpenseDataStructure expenseDataStructure, FocusedExpense focusedExpense)
        {
            expenseDataStructure.FocusedExpense = focusedExpense;
        }

        public void DeleteCategory(ExpenseDataService expenseDataService, FocusedCategory focusedCategory)
        {
            expenseDataService.DeleteCategory(focusedCategory);
        }
        public void DeleteExpense(ExpenseDataService expenseDataService, FocusedExpense focusedExpense)
        {
            expenseDataService.DeleteExpense(focusedExpense);
        }

        public float CalculateCost(DataTable dataTable)
        {
            float resultCost = 0;

            foreach(DataRow row in dataTable.Rows)
            {
                if (row["result_cost"] != null)
                {
                    resultCost += float.Parse(row["result_cost"].ToString());
                }
            }
            return resultCost;
        }

        public void SetDateTimeFilter(ExpenseDataStructure expenseDataStructure, DateTime dateTime)
        {
            expenseDataStructure.DateFilter = dateTime;
        }
        public DateTime GetDateTimeFilter (ExpenseDataStructure expenseDataStructure) 
        {
            return expenseDataStructure.DateFilter;        
        }

        public DataTable SetDateTimeFilter(DataTable dataTable, DateTime dateTime)
        {
            var filteredRows = dataTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("date").Year == dateTime.Year & row.Field<DateTime>("date").Month == dateTime.Month);
            return filteredRows.Count() > 0 ?
                 filteredRows.CopyToDataTable() : null;
        }

        public float GetInnerCost(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.InnerCost;
        }
        public void SetInnerCost(ExpenseDataStructure expenseDataStructure, float Cost)
        {
            expenseDataStructure.InnerCost = Cost;
        }

        public float GetExternalCost(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.ExternalCost;
        }
        public void SetExternalCost(ExpenseDataStructure expenseDataStructure, float Cost)
        {
            expenseDataStructure.ExternalCost = Cost;
        }

        public float GetResultCost(ExpenseDataStructure expenseDataStructure)
        {
            return expenseDataStructure.ResultCost;
        }
        public void SetResultCost(ExpenseDataStructure expenseDataStructure, float Cost)
        {
            expenseDataStructure.ResultCost = Cost;
        }

        public float CalculateAllCost(float InnerCost, float ExternalCost)
        {
            return InnerCost + ExternalCost;
        }
    }
}
