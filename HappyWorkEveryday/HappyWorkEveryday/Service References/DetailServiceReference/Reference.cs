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
namespace HappyWorkEveryday.DetailServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tb_Detail", Namespace="http://schemas.datacontract.org/2004/07/HappyWorkService")]
    public partial class Tb_Detail : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AliasField;
        
        private System.DateTime EndTimeField;
        
        private int IdField;
        
        private int IsApprovedField;
        
        private string LeaveTypeField;
        
        private string MyBackUpField;
        
        private string ReasonField;
        
        private System.DateTime StartTimeField;
        
        private double TotalTimeField;
        
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
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IsApproved {
            get {
                return this.IsApprovedField;
            }
            set {
                if ((this.IsApprovedField.Equals(value) != true)) {
                    this.IsApprovedField = value;
                    this.RaisePropertyChanged("IsApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LeaveType {
            get {
                return this.LeaveTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.LeaveTypeField, value) != true)) {
                    this.LeaveTypeField = value;
                    this.RaisePropertyChanged("LeaveType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MyBackUp {
            get {
                return this.MyBackUpField;
            }
            set {
                if ((object.ReferenceEquals(this.MyBackUpField, value) != true)) {
                    this.MyBackUpField = value;
                    this.RaisePropertyChanged("MyBackUp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TotalTime {
            get {
                return this.TotalTimeField;
            }
            set {
                if ((this.TotalTimeField.Equals(value) != true)) {
                    this.TotalTimeField = value;
                    this.RaisePropertyChanged("TotalTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DetailServiceReference.IDetailService")]
    public interface IDetailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetailService/Add", ReplyAction="http://tempuri.org/IDetailService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(HappyWorkEveryday.DetailServiceReference.Tb_Detail t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetailService/Update", ReplyAction="http://tempuri.org/IDetailService/UpdateResponse")]
        System.Threading.Tasks.Task<int> UpdateAsync(HappyWorkEveryday.DetailServiceReference.Tb_Detail t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetailService/Delete", ReplyAction="http://tempuri.org/IDetailService/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(HappyWorkEveryday.DetailServiceReference.Tb_Detail t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetailService/Find", ReplyAction="http://tempuri.org/IDetailService/FindResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HappyWorkEveryday.DetailServiceReference.Tb_Detail))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.DetailServiceReference.Tb_Detail>))]
        System.Threading.Tasks.Task<HappyWorkEveryday.DetailServiceReference.Tb_Detail> FindAsync(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetailService/FindAll", ReplyAction="http://tempuri.org/IDetailService/FindAllResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.DetailServiceReference.Tb_Detail>> FindAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDetailServiceChannel : HappyWorkEveryday.DetailServiceReference.IDetailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DetailServiceClient : System.ServiceModel.ClientBase<HappyWorkEveryday.DetailServiceReference.IDetailService>, HappyWorkEveryday.DetailServiceReference.IDetailService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DetailServiceClient() : 
                base(DetailServiceClient.GetDefaultBinding(), DetailServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IDetailService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DetailServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(DetailServiceClient.GetBindingForEndpoint(endpointConfiguration), DetailServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DetailServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DetailServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DetailServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DetailServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DetailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(HappyWorkEveryday.DetailServiceReference.Tb_Detail t) {
            return base.Channel.AddAsync(t);
        }
        
        public System.Threading.Tasks.Task<int> UpdateAsync(HappyWorkEveryday.DetailServiceReference.Tb_Detail t) {
            return base.Channel.UpdateAsync(t);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(HappyWorkEveryday.DetailServiceReference.Tb_Detail t) {
            return base.Channel.DeleteAsync(t);
        }
        
        public System.Threading.Tasks.Task<HappyWorkEveryday.DetailServiceReference.Tb_Detail> FindAsync(object id) {
            return base.Channel.FindAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<HappyWorkEveryday.DetailServiceReference.Tb_Detail>> FindAllAsync() {
            return base.Channel.FindAllAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDetailService)) {
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDetailService)) {
                return new System.ServiceModel.EndpointAddress("http://10.168.172.218:8090/Services/DetailService/DetailService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return DetailServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IDetailService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return DetailServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IDetailService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IDetailService,
        }
    }
}
