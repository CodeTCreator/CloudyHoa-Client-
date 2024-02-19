using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    public class FocusedObject
    {
        int _objectId = -1;
        int _typeObject = -1;
        string _identificator = string.Empty;
        int? _parentId = -1;

        string _nameType = string.Empty;

        public FocusedObject()
        {

        }

        public int objectId { get { return _objectId; } set { _objectId = value; } }
        public int typeObject { get { return _typeObject; } set { _typeObject = value; } }
        public string identificator {  get { return _identificator; } set { _identificator = value; } }
        public int? parentId { get { return _parentId; } set { _parentId = value; } }
        public string nameType { get { return _nameType; } set { _nameType = value; } }
    }
}
