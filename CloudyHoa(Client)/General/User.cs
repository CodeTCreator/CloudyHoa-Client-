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


        public User(string name)
        {
            Name = name;
        }
        public string Name { get { return _Name; } set { _Name = value; } }
    }
}
