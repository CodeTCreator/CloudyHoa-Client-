using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MetadataService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.CalculationWindows.Controllers
{
    public class CalculationDataService :IDataService
    {
        CalculationService.CalculationsServiceClient _calculationsServiceClient { get; set; }

        TariffService.TariffServiceClient _tariffServiceClient { get; set; }
        public CalculationDataService() 
        { 
            _calculationsServiceClient = new CalculationService.CalculationsServiceClient();
            _tariffServiceClient = new TariffService.TariffServiceClient();
        }

        public async Task<DataTable> GetCalculations(int propertyId, int typeObject)
        {
            DataSet dataSet = null;
            dataSet = await _calculationsServiceClient.GetTemplateAsync(propertyId, typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void AddCalculation(int propId, DateTime period, float value, int paId)
        {
            _calculationsServiceClient.AddCalculation(propId, period, value, paId);
        }
        public void DeleteParameter(int calculationId)
        {
            _calculationsServiceClient.DeleteCalcuation(calculationId);
        }
        public void EditParameter(int propId, DateTime period, float value, int paId, int calculationId)
        {
            _calculationsServiceClient.EditCalculation(propId, period, value,
                paId, calculationId);
        }

        public double CalculateTariffResult(int propId, int objectId, int paId, DateTime period)
        {
            double result = 0;
            result = _calculationsServiceClient.CalculateResultValue(propId, objectId, paId, period);
            return result;
        }

        public async Task<DataTable> GetTariffsFromMetadata(int propertyId)
        {
            DataSet dataSet = null;
            dataSet = await _tariffServiceClient.GetTariffsFromMetadataAsync(propertyId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetCalculationsFromMetadata(int propertyId, DateTime period)
        {
            DataSet dataSet = null;
            dataSet = await _calculationsServiceClient.GetCalculationsFromMetadataAsync(propertyId, period);
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
