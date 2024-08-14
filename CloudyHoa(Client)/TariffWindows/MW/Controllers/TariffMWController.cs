using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.TariffWindows.Controllers;
using DevExpress.XtraEditors;
using System.Data;

using System.Windows.Forms;
using System.Xml.Linq;

namespace CloudyHoa_Client_.TariffWindows.MW.Controllers
{
    internal class TariffMWController
    {
        public TariffMWController() { }

        public void AddTariff(TariffMWDataStructure tariffMWDataStructure, TariffDataService tariffDataService)
        {
            Tariff tariff = tariffMWDataStructure.Tariff;
            tariffDataService.AddTariff(tariff.Name, tariff.Value, tariff.metadataId);
        }
        public void EditTariff(TariffMWDataStructure tariffMWDataStructure, TariffDataService tariffDataService)
        {
            Tariff tariff = tariffMWDataStructure.Tariff;
            tariffDataService.EditTariff(tariff.Id, tariff.Name, tariff.Value, tariff.metadataId);
        }

        public void LoadServices(TariffDataService tariffDataService, 
            TariffMWDataStructure tariffMWDataStructure)
        {
            tariffMWDataStructure.ServicesTable = tariffDataService.GetServices(tariffMWDataStructure.HoaId,
                tariffMWDataStructure.FocusedObject.typeObject);
        }
        public DataTable GetServiceTable(TariffMWDataStructure tariffMWDataStructure)
        {
            return tariffMWDataStructure.ServicesTable;
        }


        public void ChangeName(string name, TariffMWDataStructure tariffMWDataStructure)
        {
            Tariff tariff = tariffMWDataStructure.Tariff;
            tariff.Name = name;
            tariffMWDataStructure.Tariff = tariff;
        }
        public void ChangeService(int metadataId, TariffMWDataStructure tariffMWDataStructure)
        {
            Tariff tariff = tariffMWDataStructure.Tariff;
            tariff.metadataId = metadataId;
            tariffMWDataStructure.Tariff = tariff;
        }
        public void ChangeValue(float value, TariffMWDataStructure tariffMWDataStructure)
        {
            Tariff tariff = tariffMWDataStructure.Tariff;
            tariff.Value = value;
            tariffMWDataStructure.Tariff = tariff;
        }

        public void SetFocusedObject(FocusedObject focusedObject, TariffMWDataStructure tariffMWDataStructure)
        {
            tariffMWDataStructure.FocusedObject = focusedObject;
        }

        public FocusedObject GetFocusedObject(TariffMWDataStructure tariffMWDataStructure)
        {
            return tariffMWDataStructure.FocusedObject;
        }
        public void SetTariffData(Tariff tariff, TariffMWDataStructure tariffMWDataStructure)
        {
            tariffMWDataStructure.Tariff = tariff;
        }
        public Tariff GetTariff(TariffMWDataStructure tariffMWDataStructure)
        {
            return tariffMWDataStructure.Tariff;
        }

        public void SelectValueComboBox(System.Windows.Forms.ComboBox comboBox, DataTable dataTable, int? value, string nameField)
        {
            int index = -1;
            var rows = dataTable.Select(nameField + " = " + value);
            index = rows.Length > 0 ? index = dataTable.Rows.IndexOf(rows[0]) : -1;
            comboBox.SelectedIndex = index;
            comboBox.SelectedValue = value;
        }


        public bool CheckFormsValue(TariffMWDataStructure tariffMWDataStructure)
        {
            string errorCaption = "Ошибка!";
            if(tariffMWDataStructure.Tariff.Name == "")
            {
                MessageBox.Show("Не указано название тарифа!", errorCaption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                return false;
            }
            if(tariffMWDataStructure.Tariff.metadataId == 0)
            {
                MessageBox.Show("Не указана услуга!", errorCaption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                return false;
            }
            if(tariffMWDataStructure.Tariff.Value == 0)
            {
                MessageBox.Show("Не указана значение!", errorCaption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
