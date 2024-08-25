using CloudyHoa_Client_.EHService;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDService;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.EHWindows.Controllers
{
    public class EHDataService : IDataService
    {
        EHServiceClient _eHServiceClient;
        public EHDataService() 
        {
            _eHServiceClient = new EHServiceClient();   
        }

        public async Task<DataTable> GetEnteringHistoryOD(int objectId, DateTime period)
        {
            DataSet dataSet = null;
            dataSet = await _eHServiceClient.GetEnteringHistoryFromObjectAsync(objectId,period);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public  DataTable GetEnteringHistoryOD1(int objectId, DateTime period)
        {
            DataSet dataSet = null;
            dataSet = _eHServiceClient.GetEnteringHistoryFromObject(objectId, period);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetEnteringHistoryPA(int paId, DateTime period)
        {
            DataSet dataSet = null;
            dataSet = await _eHServiceClient.GetEnteringHistoryFromPAAsync(paId, period);
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
