using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using DevExpress.Utils.Design;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.CalculationWindows.Controllers
{
    public class CalculationWindowController
    {

        public CalculationWindowController() { }
        public async Task LoadObjectsTable(IDataService dataService, IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ObjectDataStructure) ?
                await ((ObjectDataService)dataService).GetCategories() : null;
            dataTable.TableName = "Objects";
            if (dataStructure.GetType() == typeof(ObjectDataStructure))
            {
                ((ObjectDataStructure)dataStructure).DataTable = dataTable;
            }
        }
    }
}
