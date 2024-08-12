

using CloudyHoa_Client_.BenefitService;
using CloudyHoa_Client_.CalculationService;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PersonalAccountService;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.BenefitWindows.Controllers
{
    public class BenefitDataService : IDataService
    {

        BenefitServiceClient _benefitServiceClient;

        public BenefitDataService() 
        { 
            _benefitServiceClient = new BenefitServiceClient();
        }


        public void AddCalculation(int typeBenefit, int objectId, int metadataId)
        {
            _benefitServiceClient.AddBenefit(typeBenefit, objectId, metadataId);
        }
        public void DeleteParameter(int benefitId)
        {
            _benefitServiceClient.DeleteBenefit(benefitId);
        }
        public void EditParameter(int benefitId, int typeBenefit, int objectId, int metadataId)
        {
            _benefitServiceClient.EditBenefit(benefitId, typeBenefit, objectId, metadataId);
        }

        public async Task<DataTable> GetBenefitsForMetadata(int metadataId)
        {
            DataSet dataSet = null;
            dataSet = await _benefitServiceClient.GetBenefitsForMetadataAsync(metadataId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetBenefitsForObject(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _benefitServiceClient.GetBenefitsForObjectAsync(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetTypeBenefits(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = await _benefitServiceClient.GetTypeBenefitsAsync(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetBenefits(int objectId, int metadataId)
        {
            DataSet dataSet = null;
            dataSet = await _benefitServiceClient.GetBenefitsAsync(objectId, metadataId);
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
