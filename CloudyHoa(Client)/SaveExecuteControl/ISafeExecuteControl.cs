using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.SaveExecuteControl
{
    internal interface ISafeExecuteControl
    {
        Control ContainerForLoading { get; }
        Control LockControl { get; }
    }
}
