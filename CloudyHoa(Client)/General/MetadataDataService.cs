using CloudyHoa_Client_.MetadataService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    public class MetadataDataService:IDataService
    {
        MetadataServiceClient _metadataServiceClient;

        public MetadataDataService() 
        { 
            _metadataServiceClient = new MetadataServiceClient();
        }

        public DataTable GetAllTypesObjectsTable()
        {
            DataSet dataSet = null;
            dataSet = _metadataServiceClient.GetAllTypesObjects();
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetAllTypesObjectsTableAsync()
        {
            DataSet dataSet = null;
            dataSet = await _metadataServiceClient.GetAllTypesObjectsAsync();
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetTypesObjects(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = _metadataServiceClient.GetTypesObjects(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetTypesObjectsTableAsync(int hoaId)
        {
            DataSet dataSet = null;
            dataSet = await _metadataServiceClient.GetTypesObjectsAsync(hoaId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }


        public DataTable GetParametersTable(int typeObject)
        {
            DataSet dataSet = null;
            dataSet = _metadataServiceClient.GetParameters(typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<DataTable> GetParametersTableAsync(int typeObject)
        {
            DataSet dataSet = null;
            dataSet = await _metadataServiceClient.GetParametersAsync(typeObject);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public void AddParameter(int hoaId,int typeObject, string propertyName,int typeProperty, string systemName,
            string formula, bool staticParam, bool calculated)
        {
            _metadataServiceClient.AddParameter(hoaId, typeObject, propertyName, typeProperty, systemName,
                formula, staticParam, calculated);
        }

        public void AddTypeObject(string nameType, int? parentType, int hoaId)
        {
            _metadataServiceClient.AddTypeObject(nameType, parentType, hoaId);
        }
        public void DeleteParameter(int parameterId)
        {
            _metadataServiceClient.DeleteParameter(parameterId);
        }

        public void DeleteTypeObject(int typeObject)
        {
            _metadataServiceClient.DeleteTypeObject(typeObject);
        }

        public void EditParameter(int parameterId,string propertyName, int typeProperty, string systemName,
            string formula, bool staticParam, bool calculated)
        {
            _metadataServiceClient.EditParameter(parameterId, propertyName, typeProperty,
                systemName, formula, staticParam, calculated);
        }

        public void EditTypeObject(int typeId,string nameType, int? parentType)
        {
            _metadataServiceClient.EditTypeObject(typeId, nameType, parentType);
        }

        public DataTable GetTypesParamsTable()
        {
            DataSet dataSet = null;
            dataSet = _metadataServiceClient.GetTypesParameters();
            return dataSet.Tables[0];
        }

        public async Task<DataTable> GetServicesAsync(int typeObject)
        {
            DataSet dataSet = null;
            dataSet = await _metadataServiceClient.GetServicesAsync(typeObject);
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
