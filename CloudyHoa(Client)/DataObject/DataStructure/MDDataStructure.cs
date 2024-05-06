using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class MDDataStructure:IDataStructure
    {
        public DataTable MeteringDevicesTable { get; set; }  = new DataTable();
        public FocusedMD FocusedMD { get; set; } = new FocusedMD();

        public MDDataStructure() { }
    }
}
