using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.MDWindows.Controllers
{
    internal class MDWindowController
    {

        public MDWindowController() { }

        public DataTable GetMDTable(MDDataStructure mdDataStructure) { return mdDataStructure.MeteringDevicesTable; }

        public DataTable GetPATable(MDDataStructure mdDataStructure) { return mdDataStructure.PersonalAccountsTable; }

        public void SetMDTable(DataTable meteringDeviceTable, MDDataStructure mdDataStructure) { mdDataStructure.MeteringDevicesTable = meteringDeviceTable; }

        public void SetPATable(DataTable personalAccountTable, MDDataStructure mdDataStructure) { mdDataStructure.PersonalAccountsTable = personalAccountTable; }

        public DataTable GetObjectsTable(ObjectDataStructure objectDataStructure) { return objectDataStructure.DataTable; }
        public void SetObjectsTable (DataTable objectsDataTable, ObjectDataStructure objectDataStructure) { objectDataStructure.DataTable = objectsDataTable; }


        public async Task LoadObjectsTableAsync(IDataService dataService,IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ObjectDataService) ? 
                await ((ObjectDataService)dataService).GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId) : null;
            dataTable.TableName = "AllObjects";
            if(dataStructure.GetType() == typeof(ObjectDataStructure))
            {
                ((ObjectDataStructure)dataStructure).DataTable = dataTable;
            }
        }

        public async Task LoadPAsTableAsync(IDataService dataService, IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ObjectDataService) ?
                await ((ObjectDataService)dataService).GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId) : null;
            dataTable.TableName = "AllObjects";
            if (dataStructure.GetType() == typeof(ObjectDataStructure))
            {
                ((ObjectDataStructure)dataStructure).DataTable = dataTable;
            }
        }
        public async Task LoadMDsTableAsyncO(IDataService dataService, IDataStructure dataStructure, int objectId)
        {
            DataTable dataTable = dataService.GetType() == typeof(MDDataService) ?
                await ((MDDataService)dataService).GetMeteringDevicesAsyncO(objectId) : null;
            dataTable.TableName = "AllObjects";
            if (dataStructure.GetType() == typeof(MDDataStructure))
            {
                ((MDDataStructure)dataStructure).MeteringDevicesTable = dataTable;
            }
        }
        public async Task LoadMDsTableAsyncP(IDataService dataService, IDataStructure dataStructure, int paId)
        {
            DataTable dataTable = dataService.GetType() == typeof(MDDataService) ?
                await ((MDDataService)dataService).GetMeteringDevicesAsyncP(paId) : null;
            dataTable.TableName = "AllObjects";
            if (dataStructure.GetType() == typeof(MDDataStructure))
            {
                ((MDDataStructure)dataStructure).MeteringDevicesTable = dataTable;
            }
        }
    }
}
