using CloudyHoa_Client_.General;
using System.Data;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ObjectDataStructure : IDataStructure
    {
        FocusedObject _focusedObject = new FocusedObject();
        DataTable _dataObjectTable = new DataTable();
        
        public ObjectDataStructure() { }

        public FocusedObject FocusedObject { get { return _focusedObject; } set { _focusedObject = value; } }
        public DataTable DataTable { get { return _dataObjectTable; } set { _dataObjectTable = value; } }
    }
}
