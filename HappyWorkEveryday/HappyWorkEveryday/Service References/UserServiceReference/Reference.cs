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
namespace HappyWorkEveryday.UserServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tb_User", Namespace="http://schemas.datacontract.org/2004/07/HappyWorkService")]
    public partial class Tb_User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AliasField;
        
        private string EnglishNameField;
        
        private double OverTimeField;
        
        private int RoleIdField;
        
        private int UserIdField;
        
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
        public double OverTime {
            get {
                return this.OverTimeField;
            }
            set {
                if ((this.OverTimeField.Equals(value) != true)) {
                    this.OverTimeField = value;
                    this.RaisePropertyChanged("OverTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoleId {
            get {
                return this.RoleIdField;
            }
            set {
                if ((this.RoleIdField.Equals(value) != true)) {
                    this.RoleIdField = value;
                    this.RaisePropertyChanged("RoleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Add", ReplyAction="http://tempuri.org/IUserService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(HappyWorkEveryday.UserServiceReference.Tb_User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Update", ReplyAction="http://tempuri.org/IUserService/UpdateResponse")]
        System.Threading.Tasks.Task<int> UpdateAsync(HappyWorkEveryday.UserServiceReference.Tb_User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Delete", ReplyAction="http://tempuri.org/IUserService/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(HappyWorkEveryday.UserServiceReference.Tb_User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Find", ReplyAction="http://tempuri.org/IUserService/FindResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HappyWorkEveryday.UserServiceReference.Tb_User))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.UserServiceReference.Tb_User>))]
        System.Threading.Tasks.Task<HappyWorkEveryday.UserServiceReference.Tb_User> FindAsync(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindAll", ReplyAction="http://tempuri.org/IUserService/FindAllResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.UserServiceReference.Tb_User>> FindAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : HappyWorkEveryday.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<HappyWorkEveryday.UserServiceReference.IUserService>, HappyWorkEveryday.UserServiceReference.IUserService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserServiceClient() : 
                base(UserServiceClient.GetDefaultBinding(), UserServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUserService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), UserServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(HappyWorkEveryday.UserServiceReference.Tb_User t) {
            return base.Channel.AddAsync(t);
        }
        
        public System.Threading.Tasks.Task<int> UpdateAsync(HappyWorkEveryday.UserServiceReference.Tb_User t) {
            return base.Channel.UpdateAsync(t);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(HappyWorkEveryday.UserServiceReference.Tb_User t) {
            return base.Channel.DeleteAsync(t);
        }
        
        public System.Threading.Tasks.Task<HappyWorkEveryday.UserServiceReference.Tb_User> FindAsync(object id) {
            return base.Channel.FindAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.UserServiceReference.Tb_User>> FindAllAsync() {
            return base.Channel.FindAllAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserService)) {
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8791/Services/UserService/UserService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return UserServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUserService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return UserServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUserService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IUserService,
        }
    }
}
