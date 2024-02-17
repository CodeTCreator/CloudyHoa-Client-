using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ObjectWindows.MW
{
    internal interface ISPControl
    {
        void LoadData(string name, string type);

        string GetData();
    }
}
