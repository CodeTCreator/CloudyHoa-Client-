using DevExpress.XtraBars.Docking2010.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ExpenseDataStructure : IDataStructure
    {
        public FocusedCategory FocusedCategory { get; set;} = new FocusedCategory();
        public FocusedExpense FocusedExpense { get; set;} = new FocusedExpense();
        public DataTable CategoryTable { get; set; } = new DataTable();
        public DataTable InnerExpenseTable { get; set; } = new DataTable();
        public DataTable ExternalExpenseTable { get; set; } = new DataTable();
        public DateTime DateFilter {  get; set; } 

        public float InnerCost {  get; set; }
        public float ExternalCost { get; set; }
        public float ResultCost { get; set; }
        public ExpenseDataStructure() { }
    }
}
