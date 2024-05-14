using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class DPsDataStructure: IDataStructure
    {
        public DataTable OldDynamicParams { get; set; } = new DataTable();
    }
}
