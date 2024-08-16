using CloudyHoa_Client_.DynamicParamsService;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    public class DynamicParamsDataService:IDataService
    {
        DynamicParamsServiceClient _dynamicParamsServiceClient;

        public DynamicParamsDataService()
        {
            _dynamicParamsServiceClient = new DynamicParamsServiceClient();
        }


        public async Task<DataTable> GetOLdDynamicParamsAsync(int typeObject)
        {
            DataSet dataSet = null;
            dataSet = await _dynamicParamsServiceClient.OldDynamicParamsAsync(typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetDPTableFromChildren(int objectId,int typeObject)
        {
            DataSet dataSet = null;
            dataSet = await _dynamicParamsServiceClient.BoneDynamicParamsFromChildrensAsync(objectId,typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetOLdAllDynamicParamsAsync()
        {
            DataSet dataSet = null;
            dataSet = await _dynamicParamsServiceClient.OldAllDynamicParamsAsync(UserContext.Instance.CurrentUser.hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void AddDynamicParam(float value, DateTime period, int propertyId,int personal_account_id)
        {
            _dynamicParamsServiceClient.AddDynamicParam( value, period, propertyId, personal_account_id);
        }


    }


}
