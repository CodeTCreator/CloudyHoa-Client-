using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.PropertiesWindows.MW.UserControls
{
    internal interface ISPControl
    {
        void LoadData(string name, string type,string value);

        string GetData();
    }
}
