﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Servisas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servisas.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Labas", ReplyAction="http://tempuri.org/IService2/LabasResponse")]
        string Labas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Suma", ReplyAction="http://tempuri.org/IService2/SumaResponse")]
        string Suma(int i, int j);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : Client.Servisas.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<Client.Servisas.IService2>, Client.Servisas.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Labas() {
            return base.Channel.Labas();
        }
        
        public string Suma(int i, int j) {
            return base.Channel.Suma(i, j);
        }
    }
}