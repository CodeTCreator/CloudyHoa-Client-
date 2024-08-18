using CloudyHoa_Client_.ObjectsService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ObjectWindows.MW.Controllers.Service_Controller
{
    internal class SPDataService
    {
        SPService.StaticParamsServiceClient _staticParamsServiceClient;

        public SPDataService()
        {
            _staticParamsServiceClient = new SPService.StaticParamsServiceClient();
        }

        public DataTable GetSPTable(int hoaId, int typeObject)
        {
            DataSet dataSet = null;
            dataSet = _staticParamsServiceClient.GetSchemeStaticParams(hoaId,typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public void AddSP(string value, int typeParams, int propertyId, int objectId)
        {
            _staticParamsServiceClient.AddStaticParam(value, typeParams, propertyId, objectId);
        }
    }
}
