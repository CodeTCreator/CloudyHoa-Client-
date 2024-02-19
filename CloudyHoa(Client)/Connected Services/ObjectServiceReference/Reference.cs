﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyHoa_Client_.ObjectServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ObjectServiceReference.IObjectsService")]
    public interface IObjectsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/DeleteObject", ReplyAction="http://tempuri.org/IObjectsService/DeleteObjectResponse")]
        void DeleteObject(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/DeleteObject", ReplyAction="http://tempuri.org/IObjectsService/DeleteObjectResponse")]
        System.Threading.Tasks.Task DeleteObjectAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/EditObject", ReplyAction="http://tempuri.org/IObjectsService/EditObjectResponse")]
        void EditObject(int id, string objectNumber, System.Nullable<int> parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/EditObject", ReplyAction="http://tempuri.org/IObjectsService/EditObjectResponse")]
        System.Threading.Tasks.Task EditObjectAsync(int id, string objectNumber, System.Nullable<int> parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/AddObject", ReplyAction="http://tempuri.org/IObjectsService/AddObjectResponse")]
        int AddObject(int hoa_id, int type_object, string objectNumber, System.Nullable<int> parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/AddObject", ReplyAction="http://tempuri.org/IObjectsService/AddObjectResponse")]
        System.Threading.Tasks.Task<int> AddObjectAsync(int hoa_id, int type_object, string objectNumber, System.Nullable<int> parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/GetAllObjects", ReplyAction="http://tempuri.org/IObjectsService/GetAllObjectsResponse")]
        System.Data.DataSet GetAllObjects(int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/GetAllObjects", ReplyAction="http://tempuri.org/IObjectsService/GetAllObjectsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllObjectsAsync(int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/GetObjectsStructure", ReplyAction="http://tempuri.org/IObjectsService/GetObjectsStructureResponse")]
        System.Data.DataSet GetObjectsStructure(int hoa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/GetObjectsStructure", ReplyAction="http://tempuri.org/IObjectsService/GetObjectsStructureResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetObjectsStructureAsync(int hoa_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/GetObjectsParents", ReplyAction="http://tempuri.org/IObjectsService/GetObjectsParentsResponse")]
        System.Data.DataSet GetObjectsParents(int hoa_id, int type_object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObjectsService/GetObjectsParents", ReplyAction="http://tempuri.org/IObjectsService/GetObjectsParentsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetObjectsParentsAsync(int hoa_id, int type_object);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IObjectsServiceChannel : CloudyHoa_Client_.ObjectServiceReference.IObjectsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ObjectsServiceClient : System.ServiceModel.ClientBase<CloudyHoa_Client_.ObjectServiceReference.IObjectsService>, CloudyHoa_Client_.ObjectServiceReference.IObjectsService {
        
        public ObjectsServiceClient() {
        }
        
        public ObjectsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ObjectsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ObjectsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ObjectsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DeleteObject(int id) {
            base.Channel.DeleteObject(id);
        }
        
        public System.Threading.Tasks.Task DeleteObjectAsync(int id) {
            return base.Channel.DeleteObjectAsync(id);
        }
        
        public void EditObject(int id, string objectNumber, System.Nullable<int> parentId) {
            base.Channel.EditObject(id, objectNumber, parentId);
        }
        
        public System.Threading.Tasks.Task EditObjectAsync(int id, string objectNumber, System.Nullable<int> parentId) {
            return base.Channel.EditObjectAsync(id, objectNumber, parentId);
        }
        
        public int AddObject(int hoa_id, int type_object, string objectNumber, System.Nullable<int> parentId) {
            return base.Channel.AddObject(hoa_id, type_object, objectNumber, parentId);
        }
        
        public System.Threading.Tasks.Task<int> AddObjectAsync(int hoa_id, int type_object, string objectNumber, System.Nullable<int> parentId) {
            return base.Channel.AddObjectAsync(hoa_id, type_object, objectNumber, parentId);
        }
        
        public System.Data.DataSet GetAllObjects(int hoaId) {
            return base.Channel.GetAllObjects(hoaId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllObjectsAsync(int hoaId) {
            return base.Channel.GetAllObjectsAsync(hoaId);
        }
        
        public System.Data.DataSet GetObjectsStructure(int hoa_id) {
            return base.Channel.GetObjectsStructure(hoa_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetObjectsStructureAsync(int hoa_id) {
            return base.Channel.GetObjectsStructureAsync(hoa_id);
        }
        
        public System.Data.DataSet GetObjectsParents(int hoa_id, int type_object) {
            return base.Channel.GetObjectsParents(hoa_id, type_object);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetObjectsParentsAsync(int hoa_id, int type_object) {
            return base.Channel.GetObjectsParentsAsync(hoa_id, type_object);
        }
    }
}