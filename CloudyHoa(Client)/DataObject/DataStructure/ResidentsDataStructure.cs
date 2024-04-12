using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class ResidentsDataStructure : IDataStructure
    {
        DataTable _residentsTable = new DataTable();
        FocusedObject _focusedObject = new FocusedObject();
        FocusedResident _focusedResident = new FocusedResident();
        public ResidentsDataStructure() { }

        public DataTable ResidentsTable { get { return _residentsTable; } set { _residentsTable = value; } }

        public FocusedObject FocusedObject { get { return _focusedObject; } set { _focusedObject = value; } }

        public FocusedResident FocusedResident { get { return _focusedResident; } set { _focusedResident = value; } }
    }
}
