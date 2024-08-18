using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    public class CalculationDataStructure : IDataStructure
    {
        public DataTable ServicesTable {  get; set; }
        public DataTable TemplateTable { get; set; }
        public DataTable CalculationsTable { get; set; }
        public DataTable TariffsTable { get; set; }

        public DataTable BenefitsTable {  get; set; }

        public DataTable ResultTariffsTable {  get; set; }
        public DataTable ResultTable { get; set; }
        
        public DataTable TypesObjectsTable { get; set; }
        public FocusedObject FocusedObject { get; set; } = new FocusedObject();
        public DateTime CurrentDate { get; set; }
        public int CurrentService {  get; set; }
    }
}
