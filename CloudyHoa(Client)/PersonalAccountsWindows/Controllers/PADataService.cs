using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PAService;
using CloudyHoa_Client_.ResidentsService;
using System.Data;
using System.Threading.Tasks;


namespace CloudyHoa_Client_.PersonalAccountsWindows.Controllers
{
    public class PADataService:IDataService
    {
        PersonalAccountServiceClient _personalAccountServiceClient;
       
        public PADataService()
        {
            _personalAccountServiceClient = new PersonalAccountServiceClient();
        }

        public void AddPA(FocusedPA focusedPA)
        {
            _personalAccountServiceClient.AddPersonalAccount(focusedPA.Account, focusedPA.objectId, 
                focusedPA.resposibleId, focusedPA.Registered, focusedPA.Lives);
        }

        public void EditPA(FocusedPA focusedPA)
        {
            _personalAccountServiceClient.EditPersonalAccount(focusedPA.paId,focusedPA.Account,
                focusedPA.objectId, focusedPA.resposibleId, focusedPA.Registered, focusedPA.Lives);
        }

        public void DeletePA(FocusedPA focusedPA)
        {
            _personalAccountServiceClient.DeletePersonalAccount(focusedPA.paId);
        }

        public DataTable GetPAs()
        {
            DataSet dataSet = null;
            dataSet = _personalAccountServiceClient.GetPersonalAccounts(UserContext.Instance.CurrentUser.hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetPAs(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _personalAccountServiceClient.GetPersonalAccountAsync(objectId);
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
