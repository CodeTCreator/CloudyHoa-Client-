using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.ObjectWindows.MW.Controllers.Service_Controller;
using DevExpress.Utils.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ObjectWindows.MW
{
    internal class ObjectMWController
    {
        ObjectMWDataService _dataServiceMW;
        ObjectDataService _dataService;
        SPDataService _SPDataService;


        public ObjectMWController() 
        {
            _SPDataService = new SPDataService();
            _dataServiceMW = new ObjectMWDataService();
            _dataService = new ObjectDataService();

        } 
        public void LoadTypesObjects(DAO dataObject)
        {
            DataTable dataTable = _dataService.GetObjectsStructure(dataObject.hoaId);
            dataTable.TableName = "ObjectsStructure";
            SetTypesObjectsTable(dataObject, dataTable);
        }
        public void LoadAllObjects(DAO dataObject)
        {
            DataTable dataTable = _dataService.GetAllObjects(dataObject.hoaId);
            dataTable.TableName = "AllObjects";
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).DataTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public async void LoadObjectsStructureAsync(DAO dataObject)
        {
            DataTable dataTable = await _dataService.GetObjectsStructureAsync(dataObject.hoaId);
            dataTable.TableName = "ObjectsStructure";
            SetTypesObjectsTable(dataObject, dataTable);
        }
        private void SetTypesObjectsTable(DAO dataObject, DataTable dataTable)
        {
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).TypesObjectsTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public DataTable GetTypeObjectsTable(DAO dataObject)
        {
            DataTable dataTable = null;
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                dataTable = ((ObjectMWDataStructure)dataObject.structure).TypesObjectsTable;
            }
            return dataTable;
        }
        public DataTable GetParentsTable(DAO dataObject,int typeObject)
        {
            DataTable dataTable = _dataService.GetParentsObjectsTable(dataObject.hoaId,typeObject);
            dataTable.TableName = "ParentsObjectsTable";
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).ParentObjectsTable = dataTable;
            }
            else
            {
                dataObject.structure = null;
            }
            return dataTable;
        }

        public void SetTypeObject(DAO dataObject, int typeObject)
        {
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).typeObject = typeObject;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public void SetIdentificator(DAO dataObject, string identificator)
        {
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).identificator = identificator;
            }
            else
            {
                dataObject.structure = null;
            }
        }
        public void SetParentObject(DAO dataObject, int parentObject)
        {
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).parentObject = parentObject;
            }
            else
            {
                dataObject.structure = null;
            }
        }

        public void LoadProperty(StackPanel stackPanel, int typeObject,DAO dataObject)
        {
            LoadSP(dataObject ,typeObject);
            
            foreach(DataRow dataRow in ((ObjectMWDataStructure)dataObject.structure).SPTable.Rows)
            {
                
                if (dataRow["name"].ToString() == "строка")
                {
                    SPControl spControl = new SPControl();
                    spControl.LoadData(dataRow["property_name"].ToString(), dataRow["name"].ToString());
                    stackPanel.Controls.Add(spControl);
                }
                else if(dataRow["name"].ToString() == "число")
                {
                    SPControl spControl = new SPControl();
                    spControl.LoadData(dataRow["property_name"].ToString(), dataRow["name"].ToString());
                    stackPanel.Controls.Add(spControl);
                }
                else if(dataRow["name"].ToString() == "дата") 
                {
                    SPControl_Date spControl_Date = new SPControl_Date();
                    spControl_Date.LoadData(dataRow["property_name"].ToString(), dataRow["name"].ToString());
                    stackPanel.Controls.Add(spControl_Date);
                }
            }
        }
        private void LoadSP(DAO dataObject, int typeObject)
        {
            if (dataObject.structure.GetType() == typeof(ObjectMWDataStructure))
            {
                ((ObjectMWDataStructure)dataObject.structure).SPTable = _SPDataService.GetSPTable(dataObject.hoaId,typeObject);
            }
            else
            {
                dataObject.structure = null;
            }
        }

        public void AddObject(DAO dataObject, StackPanel stackPanel)
        {

        }

    }
}
