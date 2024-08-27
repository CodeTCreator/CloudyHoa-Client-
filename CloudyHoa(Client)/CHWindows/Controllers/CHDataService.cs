using CloudyHoa_Client_.CHService;
using CloudyHoa_Client_.EHService;
using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.CHWindows.Controllers
{
    public class CHDataService : IDataService
    {
        CHServiceClient _chServiceClient;
        public CHDataService()
        {
            _chServiceClient = new CHServiceClient();
        }

        public async Task<DataTable> GetCalculatingHistoryOD(int objectId, DateTime period)
        {
            DataSet dataSet = null;
            dataSet = await _chServiceClient.GetCalculationHistoryFromObjectAsync(objectId, period);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetCalculatingHistoryPA(int paId, DateTime period)
        {
            DataSet dataSet = null;
            dataSet = await _chServiceClient.GetCalculationHistoryFromPAAsync(paId, period);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
    }
}
