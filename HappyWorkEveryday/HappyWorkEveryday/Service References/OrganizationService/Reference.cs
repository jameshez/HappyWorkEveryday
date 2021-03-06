﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace HappyWorkEveryday.OrganizationService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrganizationPageModel", Namespace="http://schemas.datacontract.org/2004/07/HappyWorkService.CustomModels")]
    public partial class OrganizationPageModel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AliasField;
        
        private string EnglishNameField;
        
        private string TeamLeaderField;
        
        private string TeamNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Alias {
            get {
                return this.AliasField;
            }
            set {
                if ((object.ReferenceEquals(this.AliasField, value) != true)) {
                    this.AliasField = value;
                    this.RaisePropertyChanged("Alias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnglishName {
            get {
                return this.EnglishNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EnglishNameField, value) != true)) {
                    this.EnglishNameField = value;
                    this.RaisePropertyChanged("EnglishName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TeamLeader {
            get {
                return this.TeamLeaderField;
            }
            set {
                if ((object.ReferenceEquals(this.TeamLeaderField, value) != true)) {
                    this.TeamLeaderField = value;
                    this.RaisePropertyChanged("TeamLeader");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TeamName {
            get {
                return this.TeamNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TeamNameField, value) != true)) {
                    this.TeamNameField = value;
                    this.RaisePropertyChanged("TeamName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrganizationService.IOrganizationService")]
    public interface IOrganizationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrganizationService/FindOrganizationRelationship", ReplyAction="http://tempuri.org/IOrganizationService/FindOrganizationRelationshipResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.OrganizationService.OrganizationPageModel>> FindOrganizationRelationshipAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrganizationServiceChannel : HappyWorkEveryday.OrganizationService.IOrganizationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrganizationServiceClient : System.ServiceModel.ClientBase<HappyWorkEveryday.OrganizationService.IOrganizationService>, HappyWorkEveryday.OrganizationService.IOrganizationService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public OrganizationServiceClient() : 
                base(OrganizationServiceClient.GetDefaultBinding(), OrganizationServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IOrganizationService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OrganizationServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(OrganizationServiceClient.GetBindingForEndpoint(endpointConfiguration), OrganizationServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OrganizationServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(OrganizationServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OrganizationServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(OrganizationServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OrganizationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.OrganizationService.OrganizationPageModel>> FindOrganizationRelationshipAsync() {
            return base.Channel.FindOrganizationRelationshipAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOrganizationService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOrganizationService)) {
                return new System.ServiceModel.EndpointAddress("http://10.168.172.218:8090/Services/OrganizationService/OrganizationService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return OrganizationServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IOrganizationService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return OrganizationServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IOrganizationService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IOrganizationService,
        }
    }
}
