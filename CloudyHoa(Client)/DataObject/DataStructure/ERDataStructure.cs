using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ERDataStructure :IDataStructure
    {
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public DataTable MainObjectsTable { get; set; } = new DataTable();
        public DataTable ChildTypesObjectsTable { get; set; } = new DataTable();
        public DataTable ServicesTable { get; set; } = new DataTable();
        public DataTable EnteringTable { get; set; } = new DataTable(); 

        public DataTable TemporaryDPTable { get; set; } = new DataTable();

        public int FocusedService { get; set; } = -1;
    }
}
