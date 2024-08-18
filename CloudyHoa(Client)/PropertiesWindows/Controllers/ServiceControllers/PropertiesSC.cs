using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ObjectsService;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using DevExpress.XtraBars.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.PropertiesWindows.Controllers.ServiceControllers
{
    public class PropertiesSC
    {
        SPService.StaticParamsServiceClient _staticParamsServiceClient;

        public PropertiesSC() 
        {
            _staticParamsServiceClient = new SPService.StaticParamsServiceClient();    
        }

        /// <summary>
        /// Получение таблицы текущих статических параметров объекта
        /// </summary>
        /// <param name="objectId"></param>
        /// <returns></returns>
        public DataTable GetCurrentSP(int objectId)
        {
            DataSet dataSet = null;
            dataSet = _staticParamsServiceClient.GetCurrentStaticParams(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetCurrentSPAsync(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _staticParamsServiceClient.GetCurrentStaticParamsAsync(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Получение таблицы устаревших статических параметров объекта
        /// </summary>
        /// <param name="objectId"></param>
        /// <returns></returns>
        public DataTable GetOldSP(int objectId)
        { 
            DataSet dataSet = null;
            dataSet = _staticParamsServiceClient.GetOldStaticParams(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public async Task<DataTable> GetOldSPAsync(int objectId)
        {
            DataSet dataSet = null;
            dataSet = await _staticParamsServiceClient.GetOldStaticParamsAsync(objectId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetSP(int paramId)
        {
            DataSet dataSet = null;
            dataSet = _staticParamsServiceClient.GetStaticParam(paramId);
            if (dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void AddSP(string value, int typeParams, int propId, int objectId)
        {
            _staticParamsServiceClient.AddStaticParam(value,typeParams, propId,
                objectId);
        }

        public void DeleteSP(int paramId)
        {
            _staticParamsServiceClient.DeleteStaticParam(paramId);
        }

    }
}
