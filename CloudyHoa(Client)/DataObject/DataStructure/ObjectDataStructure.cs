using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ObjectDataStructure : IDataStructure
    {
        DataTable _dataObjectTable = new DataTable();
        DataTable _typesObjectsTable = new DataTable();
        public ObjectDataStructure() { }

        public DataTable TypesObjectsTable { get { return _typesObjectsTable; } set { _typesObjectsTable = value; } }
        public DataTable DataTable { get { return _dataObjectTable; } set { _dataObjectTable = value; } }
    }
}
