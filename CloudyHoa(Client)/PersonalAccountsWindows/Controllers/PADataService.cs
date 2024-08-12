using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PersonalAccountService;
using System.Data;
using System.Threading.Tasks;


namespace CloudyHoa_Client_.PersonalAccountsWindows.Controllers
{
    public class PADataService : IDataService
    {
        PersonalAccountServiceClient _personalAccountServiceClient;
       
        public PADataService()
        {
            _personalAccountServiceClient = new PersonalAccountServiceClient();
        }

        public async Task<DataTable> GetPA(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _personalAccountServiceClient.GetPersonalAccountsAsync(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetPAs(int typeObject)
        {
            DataSet dataSet = null;
            dataSet = await _personalAccountServiceClient.GetPersonalAccountsAsync(typeObject);
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
