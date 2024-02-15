using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.ObjectWindows.MW.Controllers.Service_Controller
{
    internal class ObjectMWDataService
    {
        ObjectServiceReference.ObjectsServiceClient _objectsServiceClient;
        
        public ObjectMWDataService()
        {
            _objectsServiceClient = new ObjectServiceReference.ObjectsServiceClient();
        }

        public void AddObject(int hoaId,int typeObject,string identificator,int parentId)
        {
            _objectsServiceClient.AddObject(hoaId, typeObject, identificator, parentId);
        }

        public void EditObject(int objectId, string identificator, int parentId)
        {
            _objectsServiceClient.EditObject(objectId, identificator, parentId);
        }
    }
}
