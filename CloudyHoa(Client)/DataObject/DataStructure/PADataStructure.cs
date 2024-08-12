using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class PADataStructure
    {
        DataTable _paTable = new DataTable();

        FocusedPA _focusedPA = new FocusedPA();

        public FocusedPA FocusedPA { get { return _focusedPA; } set { _focusedPA = value; } }
        public DataTable PersonalAccountTable { get { return _paTable; } set { _paTable = value; } }
    }
}
