using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    public class User
    {
        private string _Name;
        private int _hoaId;


        public User(string name, int hoaId)
        {
            Name = name;
            this.hoaId = hoaId;
        }

        public int hoaId { get { return _hoaId;} set { _hoaId = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
    }
}
