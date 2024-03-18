using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Data;


namespace CloudyHoa_Client_.DataObject.DataStructure
{
    internal class TariffMWDataStructure
    {
        int _hoaId = UserContext.Instance.CurrentUser.hoaId;
        Tariff _tariff;
        FocusedObject _object;
        DataTable _servicesTable = new DataTable();

        public TariffMWDataStructure()
        {

        }

        public DataTable ServicesTable
        {
            get { return _servicesTable; }
            set { _servicesTable = value; }
        }

        public int HoaId { get {  return _hoaId; } set { _hoaId = value; } }

        public Tariff Tariff { get { return _tariff; } set { _tariff = value; } }

        public FocusedObject FocusedObject { get { return _object; } set { _object = value; } } 
    }
}
