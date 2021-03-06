﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServisoClientas.ErikasWebService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ktu.lt/", ConfigurationName="ErikasWebService.ManoWebServisasSoap")]
    public interface ManoWebServisasSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/GautiPaskaitas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GautiPaskaitas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/IrasytiNaujaPaskaita", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int IrasytiNaujaPaskaita(string kodas, string pavadinimas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/AtnaujintiPaskaitosPavadinimaPagalKoda", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int AtnaujintiPaskaitosPavadinimaPagalKoda(string naujasPavadinimas, string paskaitosKodas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/GautiStudentus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GautiStudentus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/GautiDuomenisApieStudijuPlana", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GautiDuomenisApieStudijuPlana();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/GautiDuomenisApieStudijuPlanaPagalPaskaitosPavadinima", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GautiDuomenisApieStudijuPlanaPagalPaskaitosPavadinima(string pavadinimas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/GautiPaskaitaPagalLaikaIrStudentoId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GautiPaskaitaPagalLaikaIrStudentoId(string diena, string laikas, string studentoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/PriskirtiPaskaitaStudentui", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int PriskirtiPaskaitaStudentui(string studentoId, string paskaitosKodas, string diena, string laikas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ktu.lt/IstrintiStudentoPaskaitaIsStudijuPlano", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int IstrintiStudentoPaskaitaIsStudijuPlano(string paskaitosKodas, string studentoId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ManoWebServisasSoapChannel : WebServisoClientas.ErikasWebService.ManoWebServisasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManoWebServisasSoapClient : System.ServiceModel.ClientBase<WebServisoClientas.ErikasWebService.ManoWebServisasSoap>, WebServisoClientas.ErikasWebService.ManoWebServisasSoap {
        
        public ManoWebServisasSoapClient() {
        }
        
        public ManoWebServisasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManoWebServisasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManoWebServisasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManoWebServisasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GautiPaskaitas() {
            return base.Channel.GautiPaskaitas();
        }
        
        public int IrasytiNaujaPaskaita(string kodas, string pavadinimas) {
            return base.Channel.IrasytiNaujaPaskaita(kodas, pavadinimas);
        }
        
        public int AtnaujintiPaskaitosPavadinimaPagalKoda(string naujasPavadinimas, string paskaitosKodas) {
            return base.Channel.AtnaujintiPaskaitosPavadinimaPagalKoda(naujasPavadinimas, paskaitosKodas);
        }
        
        public System.Data.DataTable GautiStudentus() {
            return base.Channel.GautiStudentus();
        }
        
        public System.Data.DataTable GautiDuomenisApieStudijuPlana() {
            return base.Channel.GautiDuomenisApieStudijuPlana();
        }
        
        public System.Data.DataTable GautiDuomenisApieStudijuPlanaPagalPaskaitosPavadinima(string pavadinimas) {
            return base.Channel.GautiDuomenisApieStudijuPlanaPagalPaskaitosPavadinima(pavadinimas);
        }
        
        public string GautiPaskaitaPagalLaikaIrStudentoId(string diena, string laikas, string studentoId) {
            return base.Channel.GautiPaskaitaPagalLaikaIrStudentoId(diena, laikas, studentoId);
        }
        
        public int PriskirtiPaskaitaStudentui(string studentoId, string paskaitosKodas, string diena, string laikas) {
            return base.Channel.PriskirtiPaskaitaStudentui(studentoId, paskaitosKodas, diena, laikas);
        }
        
        public int IstrintiStudentoPaskaitaIsStudijuPlano(string paskaitosKodas, string studentoId) {
            return base.Channel.IstrintiStudentoPaskaitaIsStudijuPlano(paskaitosKodas, studentoId);
        }
    }
}
