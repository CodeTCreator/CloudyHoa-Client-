

using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ExpenseService;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectServiceReference;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ExpenseWindows.Controllers
{
    public class ExpenseDataService: IDataService
    {
        ExpensesServiceClient _expensesServiceClient;

        public ExpenseDataService()
        {
            _expensesServiceClient = new ExpensesServiceClient();
        }

        public async Task<DataTable> GetCategories()
        {
            DataSet dataSet = null;
            dataSet = await _expensesServiceClient.GetCategoriesAsync(UserContext.Instance.CurrentUser.hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetAllExpenses()
        {
            DataSet dataSet = null;
            dataSet = await _expensesServiceClient.GetAllExpensesAsync(UserContext.Instance.CurrentUser.hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetExpenses(DateTime dateTime)
        {
            DataSet dataSet = null;
            dataSet = await _expensesServiceClient.GetExpensesAsync(dateTime);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }


        public void AddCategory(FocusedCategory focusedCategory)
        {
            _expensesServiceClient.AddCategory(focusedCategory.Name, UserContext.Instance.CurrentUser.hoaId);
        }

        public void EditCategory(FocusedCategory focusedCategory)
        {
            _expensesServiceClient.EditCategory(focusedCategory.Id, focusedCategory.Name);
        }

        public void DeleteCategory(FocusedCategory focusedCategory)
        {
            _expensesServiceClient.DeleteCategory(focusedCategory.Id);
        }

        public void AddExpense(FocusedExpense focusedExpense)
        {
            _expensesServiceClient.AddExpense(focusedExpense.CategoryId,
                focusedExpense.ExpenseName, focusedExpense.Quantity,
                focusedExpense.Cost, focusedExpense.ResultCost, focusedExpense.Period);
        }

        public void EditExpense(FocusedExpense focusedExpense)
        {
            _expensesServiceClient.EditExpense(focusedExpense.Id,
                focusedExpense.CategoryId,
                focusedExpense.ExpenseName, focusedExpense.Quantity,
                focusedExpense.Cost, focusedExpense.ResultCost, focusedExpense.Period);
        }
        public void DeleteExpense(FocusedExpense focusedExpense)
        {
            _expensesServiceClient.DeleteExpense(focusedExpense.Id);
        }

        public void AddExternalExpense(FocusedExpense focusedExpense)
        {
            _expensesServiceClient.AddExternalExpense(focusedExpense.CategoryId,
                focusedExpense.ExpenseName, focusedExpense.Quantity,
                focusedExpense.Cost, focusedExpense.ResultCost, focusedExpense.Period,
                focusedExpense.ObjectId);
        }
        public void EditExternalExpense(FocusedExpense focusedExpense)
        {
            _expensesServiceClient.EditExternalExpense(focusedExpense.Id,
               focusedExpense.CategoryId,
               focusedExpense.ExpenseName, focusedExpense.Quantity,
               focusedExpense.Cost, focusedExpense.ResultCost, focusedExpense.Period, focusedExpense.ObjectId);
        }

        public async Task<DataTable> GetExternalExpenses()
        {
            DataSet dataSet = null;
            dataSet = await _expensesServiceClient.GetExternalExpensesAsync(UserContext.Instance.CurrentUser.hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetInternalExpenses()
        {
            DataSet dataSet = null;
            dataSet = await _expensesServiceClient.GetInternalExpensesAsync(UserContext.Instance.CurrentUser.hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
    }
}
