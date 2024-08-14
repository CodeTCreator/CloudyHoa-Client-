using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDService;
using CloudyHoa_Client_.ObjectServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.MDWindows.Controllers
{
    public class MDDataService :IDataService
    {
        MDServiceClient _mdServiceClient;
        
        public MDDataService()
        {
            _mdServiceClient = new MDServiceClient();
        }

        public void AddMeteringDevice(string number, DateTime verification_date, DateTime installation_date, 
            int service_id, int personal_account_id)
        {
            _mdServiceClient.AddMeteringDevice(number, verification_date, installation_date, service_id, personal_account_id);
        }

        public void EditMeteringDevice(int deviceId, string number, DateTime verification_date, DateTime installation_date,
            int service_id, int personal_account_id)
        {
            _mdServiceClient.EditMeteringDevice(deviceId, number, verification_date, installation_date, service_id,
                personal_account_id);
        }

        public void DeleteMeteringDevice(int deviceId)
        {
            _mdServiceClient.DeleteMeteringDevice(deviceId);
        }

        public DataTable GetMeterindDevicesO(int objectId)
        {
            DataSet dataSet = null;
            dataSet = _mdServiceClient.GetMeteringDevicesO(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetMeteringDevicesAsyncO(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _mdServiceClient.GetMeteringDevicesOAsync(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetMeterindDevicesP(int paId)
        {
            DataSet dataSet = null;
            dataSet = _mdServiceClient.GetMeteringDevicesP(paId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetMeteringDevicesAsyncP(int paId)
        {
            DataSet dataSet = null;
            dataSet = await _mdServiceClient.GetMeteringDevicesPAsync(paId);
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
