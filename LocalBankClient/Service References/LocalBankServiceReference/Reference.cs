﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalBankClient.LocalBankServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocalBankServiceReference.ILocalBankService")]
    public interface ILocalBankService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalBankService/GetBankName", ReplyAction="http://tempuri.org/ILocalBankService/GetBankNameResponse")]
        string GetBankName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalBankService/GetBankName", ReplyAction="http://tempuri.org/ILocalBankService/GetBankNameResponse")]
        System.Threading.Tasks.Task<string> GetBankNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILocalBankServiceChannel : LocalBankClient.LocalBankServiceReference.ILocalBankService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LocalBankServiceClient : System.ServiceModel.ClientBase<LocalBankClient.LocalBankServiceReference.ILocalBankService>, LocalBankClient.LocalBankServiceReference.ILocalBankService {
        
        public LocalBankServiceClient() {
        }
        
        public LocalBankServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LocalBankServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocalBankServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocalBankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetBankName() {
            return base.Channel.GetBankName();
        }
        
        public System.Threading.Tasks.Task<string> GetBankNameAsync() {
            return base.Channel.GetBankNameAsync();
        }
    }
}
