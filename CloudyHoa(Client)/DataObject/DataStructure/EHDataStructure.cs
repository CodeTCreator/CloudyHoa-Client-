using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;

namespace CloudyHoa_Client_.DataObject.DataStructure
{
    public class EHDataStructure : IDataStructure
    {
        public EHDataStructure() { }
        public DataTable ServicesTable { get; set; }

        public int CurrentService { get; set; }

        public DateTime CurrentDate { get; set; }   

        public DataTable EnteringTable { get; set; }

        public DataTable TemporaryEnteringTable { get; set; } = new DataTable();
    }
}
