using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ResidentsService;
using System.Data;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ResidentsWindows.Controllers
{
    public class ResidentsDataService
    {
        ApartmentResidentsClient _apartmentResidentsClient;
        public ResidentsDataService() 
        {
            _apartmentResidentsClient = new ApartmentResidentsClient();
        }

        public void AddResidents(FocusedResident focusedResident)
        {
            _apartmentResidentsClient.AddResident(focusedResident.fullName, focusedResident.objectId, focusedResident.registered,
                focusedResident.registrationData, focusedResident.residence, focusedResident.checkInDate, focusedResident.owner,
                focusedResident.ownerShareNumerator, focusedResident.ownerShareDenominator);
        }
        public void EditResidents(FocusedResident focusedResident)
        {
            _apartmentResidentsClient.EditResident(focusedResident.residentId,focusedResident.fullName, focusedResident.objectId, focusedResident.registered,
                focusedResident.registrationData, focusedResident.residence, focusedResident.checkInDate, focusedResident.owner,
                focusedResident.ownerShareNumerator, focusedResident.ownerShareDenominator);
        }
        
        public void DeleteResidents(int residentId)
        {
            _apartmentResidentsClient.DeleteResident(residentId);
        }

        public DataTable GetResidents(int objectId)
        {
            DataSet dataSet = null;
            dataSet = _apartmentResidentsClient.GetResidents(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetResidentsAsync(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _apartmentResidentsClient.GetResidentsAsync(objectId);
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
