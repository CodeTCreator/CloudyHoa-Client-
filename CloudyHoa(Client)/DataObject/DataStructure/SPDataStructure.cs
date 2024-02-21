using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class SPDataStructure : ObjectDataStructure, IDataStructure, IFocusedObject
    {
        DataTable _oldSPTable = new DataTable();
        DataTable _currentSPTable = new DataTable();    
        FocusedObject _focusedObject = null;

       public FocusedObject focusedObject
        {
            get { return _focusedObject; }
            set { _focusedObject = value; }
        }

        public DataTable oldSPTable
        {
            get { return _oldSPTable; }
            set { _oldSPTable = value; }
        }
        public DataTable currentSPTable
        {
            get { return _currentSPTable; }
            set { _currentSPTable = value; }
        }
    }
}
