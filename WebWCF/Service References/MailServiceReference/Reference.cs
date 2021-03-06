﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebWCF.MailServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailServiceReference.IMailService")]
    public interface IMailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        void SendMail(string toEmail, string subject, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        System.Threading.Tasks.Task SendMailAsync(string toEmail, string subject, string content);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceChannel : WebWCF.MailServiceReference.IMailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailServiceClient : System.ServiceModel.ClientBase<WebWCF.MailServiceReference.IMailService>, WebWCF.MailServiceReference.IMailService {
        
        public MailServiceClient() {
        }
        
        public MailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendMail(string toEmail, string subject, string content) {
            base.Channel.SendMail(toEmail, subject, content);
        }
        
        public System.Threading.Tasks.Task SendMailAsync(string toEmail, string subject, string content) {
            return base.Channel.SendMailAsync(toEmail, subject, content);
        }
    }
}
