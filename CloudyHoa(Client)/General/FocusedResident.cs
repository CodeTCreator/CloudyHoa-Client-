
using System;

namespace CloudyHoa_Client_.General
{
    public class FocusedResident
    {
        int _residentId = -1;
        string _fullName = string.Empty;
        int _objectId = -1;
        //string _objectName = string.Empty;
        //string _objectNumber = string.Empty;
        bool _registered;
        DateTime? _registrationData = null;
        bool _residence;
        DateTime? _checkInDate = null;
        bool _owner;
        int? _ownerShareNumerator = null;
        int? _ownerShareDenominator = null;

        public FocusedResident() { }

        public int residentId { get { return _residentId; }  set { _residentId = value; } }
        public string fullName { get { return _fullName;} set { _fullName = value; } }
        public int objectId { get { return _objectId; } set { _objectId = value; } }
        //public string objectName { get { return _objectName; } set { _objectName = value; } }
        //public string objectNumber { get { return _objectNumber; } set { _objectNumber = value; } }
        public bool registered { get { return _registered;} set { _registered = value; } }  
        public DateTime? registrationData { get { return _registrationData; } set { _registrationData = value; } }
        public bool residence { get { return _residence; } set { _residence = value; } }
        public DateTime? checkInDate { get { return _checkInDate; } set { _checkInDate = value; } }
        public bool owner { get { return _owner; } set { _owner = value; } }
        public int? ownerShareNumerator { get {  return _ownerShareNumerator; } set { _ownerShareNumerator = value; } }
        public int? ownerShareDenominator { get {  return _ownerShareDenominator; } set { _ownerShareDenominator= value; } }
    }
}
