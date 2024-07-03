using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    public class ExpenseMWDataStructure
    {
        public DataTable CategoriesTable { get; set; } = new DataTable();
        public FocusedExpense FocusedExpense {  get; set; } = new FocusedExpense();
    }
}
