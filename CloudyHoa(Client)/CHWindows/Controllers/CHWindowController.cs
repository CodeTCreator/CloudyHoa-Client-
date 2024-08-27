using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Threading.Tasks;
using System.Data;

namespace CloudyHoa_Client_.CHWindows.Controllers
{
    public class CHWindowController
    {
        public CHWindowController() { }

        public async Task LoadCalculationServicesAsync(IDataService dataService, IDataStructure dataStructure, int typeObject)
        {
            if (dataService.GetType() == typeof(MetadataDataService) & dataStructure.GetType() == typeof(CHDataStructure))
            {
                DataTable servicesTable = await ((MetadataDataService)dataService).GetCalculationServices(typeObject);
                ((CHDataStructure)dataStructure).ServicesTable = servicesTable;
            }
        }
        public DataTable GetServicesTable(CHDataStructure dataStructure)
        {
            return dataStructure.ServicesTable;
        }
        public void LoadServicesTable(DataTable dataTable, CHDataStructure dataStructure)
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
        public void SetSelectedProp(CHDataStructure cHDataStructure, int propId)
        {
            cHDataStructure.CurrentService = propId;
        }
        public async Task LoadCalculatingHistoryPAAsync(IDataService dataService, IDataStructure dataStructure, int paId, DateTime period)
        {
            if (dataService.GetType() == typeof(CHDataService) & dataStructure.GetType() == typeof(CHDataStructure))
            {
                DataTable childObjects = await ((CHDataService)dataService).GetCalculatingHistoryPA(paId, period);
                ((CHDataStructure)dataStructure).CalculatingTable = childObjects;
            }
        }
        public async Task LoadCalculatingHistoryObjectAsync(IDataService dataService, IDataStructure dataStructure, int objectId, DateTime period)
        {
            if (dataService.GetType() == typeof(CHDataService) & dataStructure.GetType() == typeof(CHDataStructure))
            {
                DataTable calculatingTable = await ((CHDataService)dataService).GetCalculatingHistoryOD(objectId, period);
                ((CHDataStructure)dataStructure).CalculatingTable = calculatingTable;
            }
        }
        public void SetSelectedPeriod(CHDataStructure _structure, DateTime period)
        {
            _structure.CurrentDate = period;
        }

        public void SetTemporaryCalculatingTable(CHDataStructure structure, DataTable table)
        {
            structure.CalculatingTable = table;
        }
        public DataTable GetTemporaryCalculatingTable(CHDataStructure structure)
        {
            return structure.CalculatingTable;
        }
        public void SetCalculatingTable(CHDataStructure dataStructure, DataTable table)
        {
            dataStructure.CalculatingTable = table;
        }
        public DataTable GetCalculatingTable(CHDataStructure dataStructure)
        {
            return dataStructure.CalculatingTable;
        }
    }
}
