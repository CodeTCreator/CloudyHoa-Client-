using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDWindows.Controllers;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.EHWindows.Controllers
{
    public class EHWindowController
    {

        public async Task LoadCalculationServicesAsync(IDataService dataService, IDataStructure dataStructure, int typeObject)
        {
            if (dataService.GetType() == typeof(MetadataDataService) & dataStructure.GetType() == typeof(EHDataStructure))
            {
                DataTable servicesTable = await ((MetadataDataService)dataService).GetServicesAsync(typeObject);
                ((EHDataStructure)dataStructure).ServicesTable = servicesTable;
            }
        }
        public DataTable GetServicesTable(EHDataStructure dataStructure)
        {
            return dataStructure.ServicesTable;
        }
        public void LoadServicesTable(DataTable dataTable, EHDataStructure dataStructure)
        {
            dataStructure.ServicesTable = dataTable;
        }
        public async Task LoadObjectsTableAsync(IDataService dataService, IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ObjectDataService) ?
                await ((ObjectDataService)dataService).GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId) : null;
            dataTable.TableName = "AllObjects";
            if (dataStructure.GetType() == typeof(ObjectDataStructure))
            {
                ((ObjectDataStructure)dataStructure).DataTable = dataTable;
            }
        }
        public DataTable GetObjectsTable(ObjectDataStructure objectDataStructure) { return objectDataStructure.DataTable; }
        public void SetObjectsTable(DataTable objectsDataTable, ObjectDataStructure objectDataStructure) { objectDataStructure.DataTable = objectsDataTable; }
        public void SetSelectedProp(EHDataStructure eHDataStructure, int propId)
        {
            eHDataStructure.CurrentService = propId;
        }
        public async Task LoadEnteringHistoryPAAsync(IDataService dataService, IDataStructure dataStructure, int paId, DateTime period)
        {
            if (dataService.GetType() == typeof(EHDataService) & dataStructure.GetType() == typeof(EHDataStructure))
            {
                DataTable childObjects = await ((EHDataService)dataService).GetEnteringHistoryPA(paId, period);
                ((EHDataStructure)dataStructure).EnteringTable = childObjects;
            }
        }
        public async Task LoadEnteringHistoryObjectAsync(IDataService dataService, IDataStructure dataStructure, int objectId, DateTime period)
        {
            if (dataService.GetType() == typeof(EHDataService) & dataStructure.GetType() == typeof(EHDataStructure))
            {
                DataTable enteringTable = await ((EHDataService)dataService).GetEnteringHistoryOD(objectId, period);
                ((EHDataStructure)dataStructure).EnteringTable = enteringTable;
            }
        }
        public void SetSelectedPeriod(EHDataStructure _structure, DateTime period)
        {
            _structure.CurrentDate = period;
        }

        public void SetTemporaryEnteringTable(EHDataStructure structure, DataTable table)
        {
            structure.TemporaryEnteringTable = table;
        }
        public DataTable GetTemporaryEnteringTable(EHDataStructure structure)
        {
            return structure.TemporaryEnteringTable;    
        }
        public void SetEnteringTable(EHDataStructure dataStructure, DataTable table)
        {
            dataStructure.EnteringTable = table;
        }
        public DataTable GetEnteringTable(EHDataStructure dataStructure)
        {
            return dataStructure.EnteringTable;
        }
    }
}
