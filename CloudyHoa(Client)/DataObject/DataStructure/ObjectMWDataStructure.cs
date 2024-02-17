using CloudyHoa_Client_.General;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ObjectMWDataStructure : ObjectDataStructure, IDataStructure,IFocusedObject
    {
        int _typeObject = -1;
        string _identificator = string.Empty;
        int? _parentObject = null;

        DataTable _typesObjectsTable = new DataTable();
        DataTable _parentsObjectsTable = new DataTable();
        DataTable _SPTable = new DataTable();
        FocusedObject _focusedObject = null;
        public ObjectMWDataStructure()
        {

        }

        public int typeObject
        {
            get { return _typeObject; }
            set { _typeObject = value; }
        }
        public string identificator
        {
            get { return _identificator; }
            set { _identificator = value; }
        }
        public int? parentObject
        {
            get { return _parentObject; }
            set { _parentObject = value; }
        }

        public FocusedObject focusedObject
        {
            get { return _focusedObject; }
            set { _focusedObject = value; }
        }

        public DataTable ParentObjectsTable {  get { return _parentsObjectsTable; } set { _parentsObjectsTable = value; } }
        public DataTable TypesObjectsTable { get { return _typesObjectsTable; } set { _typesObjectsTable = value; } }

        public DataTable SPTable { get { return _SPTable; } set { _SPTable = value; } }

        public void SettingFocusedObject()
        {
            _typeObject = _focusedObject.typeObject;
            _identificator = _focusedObject.identificator;
            _parentObject = _focusedObject.parentId;
        }
    }
}
