using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using DevExpress.Utils.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ObjectWindow.Service_Controller
{
    internal class ObjectWindowController
    {
        public ObjectWindowController() { }

        public void LoadAllObjects(ObjectDataService objectDataService, DAO dataObject)
        {
            DataTable dataTable = objectDataService.GetAllObjects(dataObject.hoaId);
            dataTable.TableName = "AllObjects";
            SetDataTable(dataObject, dataTable);
        }
        public async void LoadAllObjectsAsync(ObjectDataService objectDataService, DAO dataObject)
        {
            DataTable dataTable = await objectDataService.GetAllObjectsAsync(dataObject.hoaId);
            dataTable.TableName = "AllObjects";
            SetDataTable(dataObject, dataTable);
        }
        private void SetDataTable(DAO dataObject, DataTable dataTable)
        {
            if (dataObject.structure.GetType() == typeof(ObjectDataStructure))
            {
                ((ObjectDataStructure)dataObject.structure).DataTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public DataTable GetObjectsTable(DAO dataObject)
        {
            DataTable dataTable = null;
            if (dataObject.structure.GetType() == typeof(ObjectDataStructure))
            {
                dataTable = ((ObjectDataStructure)dataObject.structure).DataTable;
            }
            return dataTable;
        }
        public void DeleteObject(ObjectDataService objectDataService, int objectId) 
        {
            objectDataService.DeleteObject(objectId);
        }
    }
}
