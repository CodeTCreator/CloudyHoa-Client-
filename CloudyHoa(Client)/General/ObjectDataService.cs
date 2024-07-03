using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ObjectWindow.Service_Controller
{
    public class ObjectDataService
    {
        ObjectServiceReference.ObjectsServiceClient _objectsServiceClient;

        public ObjectDataService()
        {
            _objectsServiceClient = new ObjectServiceReference.ObjectsServiceClient();
        }

        public DataTable GetAllObjects(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = _objectsServiceClient.GetAllObjects(hoaId);
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
            dataSet = await _objectsServiceClient.GetAllObjectsAsync(hoaId);
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
            dataSet = _objectsServiceClient.GetObjectsStructure(hoaId);
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
            dataSet = await _objectsServiceClient.GetObjectsStructureAsync(hoaId);
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

        public DataTable GetParentsObjectsTable(int hoaId,int typeObject)
        {
            DataSet dataSet = null;
            dataSet = _objectsServiceClient.GetObjectsParents(hoaId,typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetObject(int objectId)
        {
            DataSet dataSet = null;
            dataSet = _objectsServiceClient.GetObject(objectId);
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
