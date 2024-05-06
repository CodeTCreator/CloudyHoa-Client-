using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.PersonalAccountsWindows.Controllers
{
    internal class PAWindowController
    {
        public PAWindowController() { }


        public async Task LoadPAsTableAsync(PADataService pADataService, PADataStructure pADataStructure, FocusedObject focusedObject)
        {
            DataTable dataTable = await pADataService.GetPAs(focusedObject.objectId);
            dataTable.TableName = "personalAccountTable";
            pADataStructure.PersonalAccountTable = dataTable;
        }

        public DataTable GetPATable(PADataStructure pADataStructure)
        {
            return pADataStructure.PersonalAccountTable;
        }

        public async Task LoadObjectsTableAsync(ObjectDataService objectDataService, ObjectDataStructure objectDataStructure)
        {
            DataTable dataTable = await objectDataService.GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId);
            dataTable.TableName = "Objects";
            objectDataStructure.DataTable = dataTable;
        }

        public FocusedPA GetFocusedPA(PADataStructure pADataStructure)
        {
            return pADataStructure.FocusedPA;
        }
    }
}
