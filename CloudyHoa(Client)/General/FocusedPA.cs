using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    public class FocusedPA
    {
        int _paId = -1;
        int _registered = -1;
        int _lives = -1;
        int _responsibleId = -1;
        string _account = string.Empty;
        int _objectId = -1;


        public FocusedPA() { }

        public int paId { get { return _paId; } set { _paId = value; } }
        public int Registered { get { return _registered; } set { _registered = value; } }
        public int Lives { get { return _lives; } set { _lives = value; } }
        public int resposibleId { get { return _responsibleId; } set { _responsibleId = value; } }
        public string Account { get { return _account; } set { _account = value; } }
        public int objectId { get { return _objectId; } set { _objectId = value; } }


    }
}
