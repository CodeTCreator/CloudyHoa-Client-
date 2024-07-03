using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    public class FocusedExpense
    {
        public int Id {  get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ExpenseName { get; set; } 
        public float Quantity { get; set; }
        public float Cost { get; set; }
        public float ResultCost { get; set; }
        public int ObjectId {  get; set; }

        public string ObjectName {  get; set; }

        public DateTime Period { get; set; }

        public FocusedExpense() { }
    }
}
