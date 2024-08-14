using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    public class FocusedMD
    {
        public int meteringDeviceId { get; set; } = -1;
        public string number { get; set; } = string.Empty;
        public DateTime verificationDate { get; set; } = DateTime.Now;
        public DateTime installationDate { get; set; } = DateTime.Now;
        public int serviceId { get; set; } = -1;
        public int personalAccountId { get; set; } = -1;

        public FocusedMD()
        {

        }

    }
}
