using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PropertiesWindows.Controllers.ServiceControllers;
using CloudyHoa_Client_.PropertiesWindows.MW.UserControls;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.PropertiesWindows.MW.Controller
{
    internal class PropMWController
    {
        public PropMWController() { }

        public void LoadSP(DAO dataObject, PropertiesSC propertiesSC)
        {
            if (dataObject.structure.GetType() == typeof(SPMWDataStructure))
            {
                DataTable dataTable = propertiesSC.GetCurrentSP(((IFocusedObject)dataObject.structure).focusedObject.objectId);
                dataTable.TableName = "SP";
                ((SPMWDataStructure)dataObject.structure).SPTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public DataTable GetSP(DAO dataObject)
        {
            DataTable dataTable = null;
            if (dataObject.structure.GetType() == typeof(SPMWDataStructure))
            {
                dataTable = ((SPMWDataStructure)dataObject.structure).SPTable;
            }
            return dataTable;
        }
        public void LoadPropertiesAndData(StackPanel stackPanelProperties, DAO dataObject, PropertiesSC propertiesSC)
        {
            LoadSP(dataObject, propertiesSC);

            foreach (DataRow dataRow in ((SPMWDataStructure)dataObject.structure).SPTable.Rows)
            {

                if (dataRow["name"].ToString() == "строка")
                {
                    SPControl spControl = new SPControl();
                    spControl.LoadData(dataRow["property_name"].ToString(), dataRow["name"].ToString(), dataRow["case"].ToString());
                    stackPanelProperties.Controls.Add(spControl);
                }
                else if (dataRow["name"].ToString() == "число")
                {
                    SPControl spControl = new SPControl();
                    spControl.LoadData(dataRow["property_name"].ToString(), dataRow["name"].ToString(), dataRow["case"].ToString());
                    stackPanelProperties.Controls.Add(spControl);
                }
                else if (dataRow["name"].ToString() == "дата")
                {
                    SPControl_Date spControl_Date = new SPControl_Date();
                    spControl_Date.LoadData(dataRow["property_name"].ToString(), dataRow["name"].ToString(), dataRow["case"].ToString());
                    stackPanelProperties.Controls.Add(spControl_Date);
                }
            }
        }
        public void SetLabelNameText(Label labelName, DAO dataAccessObject)
        {
            if (dataAccessObject.structure.GetType() == typeof(SPMWDataStructure))
            {
                labelName.Text = "Объект: " + ((IFocusedObject)dataAccessObject.structure).focusedObject.nameType
                    + " №" + ((IFocusedObject)dataAccessObject.structure).focusedObject.identificator;
            }
            
        }

        public void SaveSP(PropertiesSC propertiesSC,DAO dataObject, StackPanel stackPanel)
        {
            if (dataObject.structure.GetType() == typeof(SPMWDataStructure))
            {
                var dataObjectMW = (SPMWDataStructure)dataObject.structure;
                try
                {
                    
                    int objectId = ((SPMWDataStructure)dataObject.structure).focusedObject.objectId;
                   
                    for (int i = 0; i < stackPanel.Controls.Count; i++)
                    {
                        propertiesSC.AddSP(
                            ((ISPControl)stackPanel.Controls[i]).GetData(), (int)dataObjectMW.SPTable.Rows[i]["type_property"],
                            (int)dataObjectMW.SPTable.Rows[i]["prop_id"], objectId);
                    }
                }
                catch (TimeoutException timeProblem)
                {
                    const string message =
                    "Сервер недоступен. Попробуйте позже.";
                    const string caption = "Подключение к серверу";
                    var serverResult = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
            else
            {
                const string message =
                "Не удалось явно преобразовать объект к указанному типу";
                const string caption = "Преобразование типов";
                var serverResult = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }

        }
    }
}
