using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class TariffDataStructure : IDataStructure
    {
        DataTable _tariffsTable = new DataTable();
        DataTable _typesObjectsTable = new DataTable();
        int type_object;

        public TariffDataStructure() { }
        public DataTable TariffTable { get { return _tariffsTable; } set { _tariffsTable = value; } }
        public DataTable TypesObjectsTable { get { return _typesObjectsTable; } set { _typesObjectsTable = value; } }

        public int CurrentTypeObject {  get { return type_object; } set {  type_object = value; } }
    }

    public struct Tariff
    {
        public int Id;
        public string Name;
        public float Value;
        public int metadataId;
    }
}
