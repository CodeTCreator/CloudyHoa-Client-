using CloudyHoa_Client_.DataObject;
using System;
using System.Collections.Generic;
using System.Data;

namespace CloudyHoa_Client_.CHWindows.Controllers
{
    public class CHDataStructure :IDataStructure
    {
        public CHDataStructure() { }
        public DataTable ServicesTable { get; set; }

        public int CurrentService { get; set; }

        public DateTime CurrentDate { get; set; }

        public DataTable CalculatingTable { get; set; }

        public DataTable TemporaryCalculatingTable { get; set; } = new DataTable();
    }
}
