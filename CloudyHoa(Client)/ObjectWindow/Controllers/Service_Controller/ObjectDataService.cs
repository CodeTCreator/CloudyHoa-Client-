using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ObjectWindow.Service_Controller
{
    internal class ObjectDataService
    {
        ObjectServiceReference.ObjectsServiceClient _objectsServiceClient;

        public ObjectDataService()
        {
            _objectsServiceClient = new ObjectServiceReference.ObjectsServiceClient();
        }

        public DataTable GetAllObjects(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = _objectsServiceClient.getAllObjects(hoaId);
            if(dataSet != null) 
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetAllObjectsAsync(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = await _objectsServiceClient.getAllObjectsAsync(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetObjectsStructure(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = _objectsServiceClient.getObjectsStructure(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetObjectsStructureAsync(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = await _objectsServiceClient.getObjectsStructureAsync(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void DeleteObject(int objectId)
        {
            _objectsServiceClient.DeleteObject(objectId);
        }
    }
}
