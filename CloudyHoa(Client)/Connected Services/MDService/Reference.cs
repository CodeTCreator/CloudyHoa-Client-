﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyHoa_Client_.MDService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MDService.IMDService")]
    public interface IMDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/AddMeteringDevice", ReplyAction="http://tempuri.org/IMDService/AddMeteringDeviceResponse")]
        void AddMeteringDevice(string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/AddMeteringDevice", ReplyAction="http://tempuri.org/IMDService/AddMeteringDeviceResponse")]
        System.Threading.Tasks.Task AddMeteringDeviceAsync(string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/EditMeteringDevice", ReplyAction="http://tempuri.org/IMDService/EditMeteringDeviceResponse")]
        void EditMeteringDevice(int deviceId, string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/EditMeteringDevice", ReplyAction="http://tempuri.org/IMDService/EditMeteringDeviceResponse")]
        System.Threading.Tasks.Task EditMeteringDeviceAsync(int deviceId, string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/DeleteMeteringDevice", ReplyAction="http://tempuri.org/IMDService/DeleteMeteringDeviceResponse")]
        void DeleteMeteringDevice(int deviceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/DeleteMeteringDevice", ReplyAction="http://tempuri.org/IMDService/DeleteMeteringDeviceResponse")]
        System.Threading.Tasks.Task DeleteMeteringDeviceAsync(int deviceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/GetMeteringDevicesO", ReplyAction="http://tempuri.org/IMDService/GetMeteringDevicesOResponse")]
        System.Data.DataSet GetMeteringDevicesO(int objectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/GetMeteringDevicesO", ReplyAction="http://tempuri.org/IMDService/GetMeteringDevicesOResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetMeteringDevicesOAsync(int objectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/GetMeteringDevicesP", ReplyAction="http://tempuri.org/IMDService/GetMeteringDevicesPResponse")]
        System.Data.DataSet GetMeteringDevicesP(int personalAccountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMDService/GetMeteringDevicesP", ReplyAction="http://tempuri.org/IMDService/GetMeteringDevicesPResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetMeteringDevicesPAsync(int personalAccountId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMDServiceChannel : CloudyHoa_Client_.MDService.IMDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MDServiceClient : System.ServiceModel.ClientBase<CloudyHoa_Client_.MDService.IMDService>, CloudyHoa_Client_.MDService.IMDService {
        
        public MDServiceClient() {
        }
        
        public MDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddMeteringDevice(string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id) {
            base.Channel.AddMeteringDevice(number, verification_date, installation_date, service_id, personal_account_id);
        }
        
        public System.Threading.Tasks.Task AddMeteringDeviceAsync(string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id) {
            return base.Channel.AddMeteringDeviceAsync(number, verification_date, installation_date, service_id, personal_account_id);
        }
        
        public void EditMeteringDevice(int deviceId, string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id) {
            base.Channel.EditMeteringDevice(deviceId, number, verification_date, installation_date, service_id, personal_account_id);
        }
        
        public System.Threading.Tasks.Task EditMeteringDeviceAsync(int deviceId, string number, System.DateTime verification_date, System.DateTime installation_date, int service_id, int personal_account_id) {
            return base.Channel.EditMeteringDeviceAsync(deviceId, number, verification_date, installation_date, service_id, personal_account_id);
        }
        
        public void DeleteMeteringDevice(int deviceId) {
            base.Channel.DeleteMeteringDevice(deviceId);
        }
        
        public System.Threading.Tasks.Task DeleteMeteringDeviceAsync(int deviceId) {
            return base.Channel.DeleteMeteringDeviceAsync(deviceId);
        }
        
        public System.Data.DataSet GetMeteringDevicesO(int objectId) {
            return base.Channel.GetMeteringDevicesO(objectId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetMeteringDevicesOAsync(int objectId) {
            return base.Channel.GetMeteringDevicesOAsync(objectId);
        }
        
        public System.Data.DataSet GetMeteringDevicesP(int personalAccountId) {
            return base.Channel.GetMeteringDevicesP(personalAccountId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetMeteringDevicesPAsync(int personalAccountId) {
            return base.Channel.GetMeteringDevicesPAsync(personalAccountId);
        }
    }
}
