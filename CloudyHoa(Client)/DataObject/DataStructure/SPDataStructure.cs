using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class SPDataStructure : ObjectDataStructure, IFocusedObject
    {
        DataTable _oldSPTable = new DataTable();
        DataTable _currentSPTable = new DataTable();    
        FocusedObject _focusedObject = new FocusedObject();

       public FocusedObject focusedObject
        {
            get { return _focusedObject; }
            set { _focusedObject = value; }
        }

        public DataTable OldSPTable
        {
            get { return _oldSPTable; }
            set { _oldSPTable = value; }
        }
        public DataTable CurrentSPTable
        {
            get { return _currentSPTable; }
            set { _currentSPTable = value; }
        }
    }
}
