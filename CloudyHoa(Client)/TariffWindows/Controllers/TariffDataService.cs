using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.TariffWindows.Controllers
{
    public class TariffDataService
    {
        TariffService.TariffServiceClient _tariffServiceClient;
        ObjectsService.ObjectsServiceClient _ObjectsService;
        public TariffDataService()
        {
            _tariffServiceClient = new TariffService.TariffServiceClient();
            _ObjectsService = new ObjectsService.ObjectsServiceClient();
        }

        public DataTable GetTariffs(int hoaId, int? type_object)
        {
            DataSet dataSet = null;
            dataSet = _tariffServiceClient.GetTariffs(hoaId,type_object);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetTariffsAsync(int hoaId, int? type_object)
        {
            DataSet dataSet = null;
            dataSet = await _tariffServiceClient.GetTariffsAsync(hoaId, type_object);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetTOTable(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = _ObjectsService.GetObjectsStructure(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetTOTableAsync(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = await _ObjectsService.GetObjectsStructureAsync(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void AddTariff(string name,float value,int metadataId)
        {
            _tariffServiceClient.AddTariff(name, value, metadataId);
        }
        public void DeleteTariff(int tariffId)
        {
            _tariffServiceClient.DeleteTariff(tariffId);
        }
        public void EditTariff(int tariffId,string name,float value,int metadataId)
        {
            _tariffServiceClient.EditTariff(tariffId, name, value, metadataId);
        }

        public DataTable GetServices(int  hoaId, int type_object) 
        {
            DataSet dataSet = null;
            dataSet = _tariffServiceClient.GetServices(hoaId,type_object);
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
