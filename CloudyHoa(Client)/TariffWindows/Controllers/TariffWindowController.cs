using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.TariffWindows.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.TariffWindows
{
    internal class TariffWindowController
    {
        public TariffWindowController() { }

        public DataTable GetTariffTable(TariffDataStructure tariffDataStructure)
        {
            return tariffDataStructure.TariffTable;
        }
        public DataTable GetTOTable(TariffDataStructure tariffDataStructure)
        {
            return tariffDataStructure.TypesObjectsTable;
        }
        public void LoadDataTariffTable(TariffDataService tariffDataService, 
            TariffDataStructure tariffDataStructure)
        {
            tariffDataStructure.TariffTable = tariffDataService.GetTariffs(UserContext.Instance.CurrentUser.hoaId,
                GetCurrrentTypeObject(tariffDataStructure));
        }
        public void LoadDataTOTable(TariffDataService tariffDataService,
           TariffDataStructure tariffDataStructure)
        {
            tariffDataStructure.TariffTable = tariffDataService.GetTOTable(UserContext.Instance.CurrentUser.hoaId);
        }

        public async Task LoadDataTariffTableAsync(TariffDataService tariffDataService,
            TariffDataStructure tariffDataStructure)
        {
            tariffDataStructure.TariffTable = await tariffDataService.GetTariffsAsync(
                UserContext.Instance.CurrentUser.hoaId, GetCurrrentTypeObject(tariffDataStructure));
        }

        public async Task LoadDataTOTableAsync(TariffDataService tariffDataService,
            TariffDataStructure tariffDataStructure)
        {
            tariffDataStructure.TypesObjectsTable = await tariffDataService.GetTOTableAsync(UserContext.Instance.CurrentUser.hoaId);
        }


        public void DeleteTariff(TariffDataService tariffDataService,int tariffId)
        {
            tariffDataService.DeleteTariff(tariffId);
        }

        public void EditTariff(TariffDataService tariffDataService, Tariff tariff)
        {
            tariffDataService.EditTariff(tariff.Id, tariff.Name, tariff.Value, tariff.metadataId);
        }

        public void AddTariff(TariffDataService tariffDataService,Tariff tariff)
        {
            tariffDataService.AddTariff(tariff.Name, tariff.Value, tariff.metadataId);
        }

        public Tariff ConvertToTariff(int tariffId,string name,float value,int metadataId)
        {
            return new Tariff() { Id = tariffId, Name = name, Value = value, metadataId = metadataId };
        }

        public int GetCurrrentTypeObject(TariffDataStructure tariffDataStructure)
        {
            return tariffDataStructure.CurrentTypeObject;
        }
        public void SetCurrentTypeObject(int typeObject, TariffDataStructure tariffDataStructure)
        {
            tariffDataStructure.CurrentTypeObject = typeObject; 
        }

    }
}
