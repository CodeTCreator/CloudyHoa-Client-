using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using Fractions;
using System.Data;
using System.Threading.Tasks;


namespace CloudyHoa_Client_.ResidentsWindows.Controllers
{
    internal class ResidentsWindowController
    {
        public ResidentsWindowController() { }

        public async Task LoadResidentsTableAsync(ResidentsDataService residentDataService, ResidentsDataStructure residentsDataStructure,
            FocusedObject focusedObject)
        {
            DataTable dataTable = await residentDataService.GetResidentsAsync(focusedObject.objectId);
            dataTable.TableName = "Residents";
            residentsDataStructure.ResidentsTable = dataTable;
        }

        public DataTable GetResidentsTable(ResidentsDataStructure residentsDataStructure)
        {
            return residentsDataStructure.ResidentsTable;
        }

        public async Task LoadObjectsTableAsync(ObjectDataService objectDataService, ObjectDataStructure objectDataStructure)
        {
            DataTable dataTable = await objectDataService.GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId);
            dataTable.TableName = "Objects";
            objectDataStructure.DataTable = dataTable;
        }
       
    }
}
