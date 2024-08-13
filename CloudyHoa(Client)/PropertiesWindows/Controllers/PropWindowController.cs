using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudyHoa_Client_.PropertiesWindows.Controllers.ServiceControllers;
using System.Windows.Forms;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PropertiesWindows.MW;
using System.Runtime.CompilerServices;

namespace CloudyHoa_Client_.PropertiesWindows
{
    internal class PropWindowController
    {
        public PropWindowController() { }

        
        public void LoadAllObjects(ObjectDataService objectDataService, 
            ObjectDataStructure objectDataStructure)
        {
            DataTable dataTable = objectDataService.GetAllObjects(UserContext.Instance.CurrentUser.hoaId);
            dataTable.TableName = "AllObjects";
            SetDataTable(objectDataStructure, dataTable);
        }
        public async Task LoadAllObjectAsync(ObjectDataService objectDataService, 
            ObjectDataStructure objectDataStructure)
        {
            DataTable dataTable = await objectDataService.GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId);
            dataTable.TableName = "AllObjects";
            SetDataTable(objectDataStructure, dataTable);
        }
        private void SetDataTable(ObjectDataStructure objectDataStructure, DataTable dataTable)
        {
            objectDataStructure.DataTable = dataTable;
        }
        public DataTable GetObjectsTable(ObjectDataStructure objectDataStructure)
        {
            return objectDataStructure.DataTable;
        }
        public DataTable GetCurrentSP(DAO dataObject)
        {
            DataTable dataTable = null;
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                dataTable = ((SPDataStructure)dataObject.structure).CurrentSPTable;
            }
            return dataTable;
        }

        public DataTable GetOldSP(DAO dataObject)
        {
            DataTable dataTable = null;
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                dataTable = ((SPDataStructure)dataObject.structure).OldSPTable;
            }
            return dataTable;
        }

        public void LoadOldSP(DAO dataObject, PropertiesSC propertiesSC,int objectId)
        {
            DataTable dataTable = propertiesSC.GetOldSP(objectId);
            dataTable.TableName = "OldSP";
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                ((SPDataStructure)dataObject.structure).OldSPTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public async Task LoadOldSPAsync(DAO dataObject, PropertiesSC propertiesSC, int objectId)
        {
            DataTable dataTable = await propertiesSC.GetOldSPAsync(objectId);
            dataTable.TableName = "OldSP";
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                ((SPDataStructure)dataObject.structure).OldSPTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public void LoadCurrentSP(DAO dataObject, PropertiesSC propertiesSC, int objectId)
        {
            DataTable dataTable = propertiesSC.GetCurrentSP(objectId);
            dataTable.TableName = "CurrentSP";
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                ((SPDataStructure)dataObject.structure).CurrentSPTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public async Task LoadCurrentSPAsync(DAO dataObject, PropertiesSC propertiesSC, int objectId)
        {
            DataTable dataTable = await propertiesSC.GetCurrentSPAsync(objectId);
            dataTable.TableName = "CurrentSP";
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                ((SPDataStructure)dataObject.structure).CurrentSPTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }

        public FocusedObject GetFO(DAO dataObject)
        {
            return dataObject.structure.GetType() == typeof(SPDataStructure) ?
                ((SPDataStructure)dataObject.structure).focusedObject : null;
        }
        public void UpdateFocusedObject(DAO dataObject, int objectId, int typeObject, string identificator,
            int? parentId, string nameType)
        {
            if (dataObject.structure.GetType() == typeof(SPDataStructure))
            {
                ((SPDataStructure)dataObject.structure).focusedObject.objectId = objectId;
                ((SPDataStructure)dataObject.structure).focusedObject.typeObject = typeObject;
                ((SPDataStructure)dataObject.structure).focusedObject.identificator = identificator;
                ((SPDataStructure)dataObject.structure).focusedObject.parentId = parentId;
                ((SPDataStructure)dataObject.structure).focusedObject.nameType = nameType;

            }
        }
    }
}
