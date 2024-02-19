using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ObjectSPDataStructure
    {
        DataTable _SPTable = new DataTable();

        public ObjectSPDataStructure() { }

        public DataTable SPTable { get { return _SPTable; } set { _SPTable = value; } }

    }
}
