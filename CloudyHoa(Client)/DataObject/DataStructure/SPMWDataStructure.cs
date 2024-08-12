using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class SPMWDataStructure : ObjectSPDataStructure, IFocusedObject, IDataStructure
    {
        FocusedObject _focusedObject = null;
        public FocusedObject focusedObject
        {
            get { return _focusedObject; }
            set { _focusedObject = value; }
        }
    }
}
