using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class PAMWStructure : IDataStructure
    {
        DataTable _personalAccountsTable = new DataTable();
        DataTable _residentsTable = new DataTable();
        FocusedObject _focusedObject = new FocusedObject();
        FocusedPA _focusedPA = new FocusedPA();
        public PAMWStructure() { }

        public DataTable PersonalAccountsTable { get { return _personalAccountsTable; } set { _personalAccountsTable = value; } }
        public DataTable ResidentsTable { get { return _residentsTable; } set { _residentsTable = value; } }

        public FocusedObject FocusedObject { get { return _focusedObject; } set { _focusedObject = value; } }


        public FocusedPA FocusedPA { get { return _focusedPA; } set { _focusedPA = value; } }
    }
}
