﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyHoa_Client_.BenefitService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BenefitService.IBenefitService")]
    public interface IBenefitService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/AddBenefit", ReplyAction="http://tempuri.org/IBenefitService/AddBenefitResponse")]
        void AddBenefit(int typeBenefit, int objectId, int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/AddBenefit", ReplyAction="http://tempuri.org/IBenefitService/AddBenefitResponse")]
        System.Threading.Tasks.Task AddBenefitAsync(int typeBenefit, int objectId, int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/EditBenefit", ReplyAction="http://tempuri.org/IBenefitService/EditBenefitResponse")]
        void EditBenefit(int benefitId, int typeBenefit, int objectId, int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/EditBenefit", ReplyAction="http://tempuri.org/IBenefitService/EditBenefitResponse")]
        System.Threading.Tasks.Task EditBenefitAsync(int benefitId, int typeBenefit, int objectId, int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/DeleteBenefit", ReplyAction="http://tempuri.org/IBenefitService/DeleteBenefitResponse")]
        void DeleteBenefit(int benefitId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/DeleteBenefit", ReplyAction="http://tempuri.org/IBenefitService/DeleteBenefitResponse")]
        System.Threading.Tasks.Task DeleteBenefitAsync(int benefitId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/AddTypeBenefit", ReplyAction="http://tempuri.org/IBenefitService/AddTypeBenefitResponse")]
        void AddTypeBenefit(string name, float value, int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/AddTypeBenefit", ReplyAction="http://tempuri.org/IBenefitService/AddTypeBenefitResponse")]
        System.Threading.Tasks.Task AddTypeBenefitAsync(string name, float value, int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/EditTypeBenefit", ReplyAction="http://tempuri.org/IBenefitService/EditTypeBenefitResponse")]
        void EditTypeBenefit(int typeBenefitId, string name, float value, int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/EditTypeBenefit", ReplyAction="http://tempuri.org/IBenefitService/EditTypeBenefitResponse")]
        System.Threading.Tasks.Task EditTypeBenefitAsync(int typeBenefitId, string name, float value, int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/DeleteTypeBenefit", ReplyAction="http://tempuri.org/IBenefitService/DeleteTypeBenefitResponse")]
        void DeleteTypeBenefit(int typeBenefitId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/DeleteTypeBenefit", ReplyAction="http://tempuri.org/IBenefitService/DeleteTypeBenefitResponse")]
        System.Threading.Tasks.Task DeleteTypeBenefitAsync(int typeBenefitId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetTypeBenefits", ReplyAction="http://tempuri.org/IBenefitService/GetTypeBenefitsResponse")]
        System.Data.DataSet GetTypeBenefits(int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetTypeBenefits", ReplyAction="http://tempuri.org/IBenefitService/GetTypeBenefitsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetTypeBenefitsAsync(int hoaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetBenefitsForObject", ReplyAction="http://tempuri.org/IBenefitService/GetBenefitsForObjectResponse")]
        System.Data.DataSet GetBenefitsForObject(int objectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetBenefitsForObject", ReplyAction="http://tempuri.org/IBenefitService/GetBenefitsForObjectResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBenefitsForObjectAsync(int objectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetBenefitsForMetadata", ReplyAction="http://tempuri.org/IBenefitService/GetBenefitsForMetadataResponse")]
        System.Data.DataSet GetBenefitsForMetadata(int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetBenefitsForMetadata", ReplyAction="http://tempuri.org/IBenefitService/GetBenefitsForMetadataResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBenefitsForMetadataAsync(int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetBenefits", ReplyAction="http://tempuri.org/IBenefitService/GetBenefitsResponse")]
        System.Data.DataSet GetBenefits(int objectId, int metadataId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBenefitService/GetBenefits", ReplyAction="http://tempuri.org/IBenefitService/GetBenefitsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBenefitsAsync(int objectId, int metadataId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBenefitServiceChannel : CloudyHoa_Client_.BenefitService.IBenefitService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BenefitServiceClient : System.ServiceModel.ClientBase<CloudyHoa_Client_.BenefitService.IBenefitService>, CloudyHoa_Client_.BenefitService.IBenefitService {
        
        public BenefitServiceClient() {
        }
        
        public BenefitServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BenefitServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BenefitServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BenefitServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBenefit(int typeBenefit, int objectId, int metadataId) {
            base.Channel.AddBenefit(typeBenefit, objectId, metadataId);
        }
        
        public System.Threading.Tasks.Task AddBenefitAsync(int typeBenefit, int objectId, int metadataId) {
            return base.Channel.AddBenefitAsync(typeBenefit, objectId, metadataId);
        }
        
        public void EditBenefit(int benefitId, int typeBenefit, int objectId, int metadataId) {
            base.Channel.EditBenefit(benefitId, typeBenefit, objectId, metadataId);
        }
        
        public System.Threading.Tasks.Task EditBenefitAsync(int benefitId, int typeBenefit, int objectId, int metadataId) {
            return base.Channel.EditBenefitAsync(benefitId, typeBenefit, objectId, metadataId);
        }
        
        public void DeleteBenefit(int benefitId) {
            base.Channel.DeleteBenefit(benefitId);
        }
        
        public System.Threading.Tasks.Task DeleteBenefitAsync(int benefitId) {
            return base.Channel.DeleteBenefitAsync(benefitId);
        }
        
        public void AddTypeBenefit(string name, float value, int hoaId) {
            base.Channel.AddTypeBenefit(name, value, hoaId);
        }
        
        public System.Threading.Tasks.Task AddTypeBenefitAsync(string name, float value, int hoaId) {
            return base.Channel.AddTypeBenefitAsync(name, value, hoaId);
        }
        
        public void EditTypeBenefit(int typeBenefitId, string name, float value, int hoaId) {
            base.Channel.EditTypeBenefit(typeBenefitId, name, value, hoaId);
        }
        
        public System.Threading.Tasks.Task EditTypeBenefitAsync(int typeBenefitId, string name, float value, int hoaId) {
            return base.Channel.EditTypeBenefitAsync(typeBenefitId, name, value, hoaId);
        }
        
        public void DeleteTypeBenefit(int typeBenefitId) {
            base.Channel.DeleteTypeBenefit(typeBenefitId);
        }
        
        public System.Threading.Tasks.Task DeleteTypeBenefitAsync(int typeBenefitId) {
            return base.Channel.DeleteTypeBenefitAsync(typeBenefitId);
        }
        
        public System.Data.DataSet GetTypeBenefits(int hoaId) {
            return base.Channel.GetTypeBenefits(hoaId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetTypeBenefitsAsync(int hoaId) {
            return base.Channel.GetTypeBenefitsAsync(hoaId);
        }
        
        public System.Data.DataSet GetBenefitsForObject(int objectId) {
            return base.Channel.GetBenefitsForObject(objectId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBenefitsForObjectAsync(int objectId) {
            return base.Channel.GetBenefitsForObjectAsync(objectId);
        }
        
        public System.Data.DataSet GetBenefitsForMetadata(int metadataId) {
            return base.Channel.GetBenefitsForMetadata(metadataId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBenefitsForMetadataAsync(int metadataId) {
            return base.Channel.GetBenefitsForMetadataAsync(metadataId);
        }
        
        public System.Data.DataSet GetBenefits(int objectId, int metadataId) {
            return base.Channel.GetBenefits(objectId, metadataId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBenefitsAsync(int objectId, int metadataId) {
            return base.Channel.GetBenefitsAsync(objectId, metadataId);
        }
    }
}
