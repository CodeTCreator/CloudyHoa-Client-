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

        DataTable _personalAccountsTable = new DataTable();

        DataTable _meteringdevicesTable = new DataTable();

        public MDDataStructure() { }

        public DataTable PersonalAccountsTable { get { return _personalAccountsTable; } set { _personalAccountsTable = value; } }
        public DataTable MeteringDevicesTable { get { return _meteringdevicesTable; } set { _meteringdevicesTable = value; } }

    }
}
