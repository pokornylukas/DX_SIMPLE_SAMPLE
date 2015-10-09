﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.PersonsReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] RowVersionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] RowVersion {
            get {
                return this.RowVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.RowVersionField, value) != true)) {
                    this.RowVersionField = value;
                    this.RaisePropertyChanged("RowVersion");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataModificationResult", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class DataModificationResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.PersonsReference.DataModificationResult.Results ResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionMessage {
            get {
                return this.ExceptionMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMessageField, value) != true)) {
                    this.ExceptionMessageField = value;
                    this.RaisePropertyChanged("ExceptionMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.PersonsReference.DataModificationResult.Results Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="DataModificationResult.Results", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
        public enum Results : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Ok = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            OptimisticConcurrencyException = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            GeneralException = 2,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonsReference.IPersonsService")]
    public interface IPersonsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/BulkInsert10000Records", ReplyAction="http://tempuri.org/IPersonsService/BulkInsert10000RecordsResponse")]
        void BulkInsert10000Records();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/BulkInsert10000Records", ReplyAction="http://tempuri.org/IPersonsService/BulkInsert10000RecordsResponse")]
        System.Threading.Tasks.Task BulkInsert10000RecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/GetPersons", ReplyAction="http://tempuri.org/IPersonsService/GetPersonsResponse")]
        Client.PersonsReference.Person[] GetPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/GetPersons", ReplyAction="http://tempuri.org/IPersonsService/GetPersonsResponse")]
        System.Threading.Tasks.Task<Client.PersonsReference.Person[]> GetPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/GetPersonsDS", ReplyAction="http://tempuri.org/IPersonsService/GetPersonsDSResponse")]
        Client.PersonsReference.Person[] GetPersonsDS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/GetPersonsDS", ReplyAction="http://tempuri.org/IPersonsService/GetPersonsDSResponse")]
        System.Threading.Tasks.Task<Client.PersonsReference.Person[]> GetPersonsDSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonsService/UpdatePersonResponse")]
        Client.PersonsReference.DataModificationResult UpdatePerson(Client.PersonsReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonsService/UpdatePersonResponse")]
        System.Threading.Tasks.Task<Client.PersonsReference.DataModificationResult> UpdatePersonAsync(Client.PersonsReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/DeletePerson", ReplyAction="http://tempuri.org/IPersonsService/DeletePersonResponse")]
        Client.PersonsReference.DataModificationResult DeletePerson(Client.PersonsReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonsService/DeletePerson", ReplyAction="http://tempuri.org/IPersonsService/DeletePersonResponse")]
        System.Threading.Tasks.Task<Client.PersonsReference.DataModificationResult> DeletePersonAsync(Client.PersonsReference.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonsServiceChannel : Client.PersonsReference.IPersonsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonsServiceClient : System.ServiceModel.ClientBase<Client.PersonsReference.IPersonsService>, Client.PersonsReference.IPersonsService {
        
        public PersonsServiceClient() {
        }
        
        public PersonsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void BulkInsert10000Records() {
            base.Channel.BulkInsert10000Records();
        }
        
        public System.Threading.Tasks.Task BulkInsert10000RecordsAsync() {
            return base.Channel.BulkInsert10000RecordsAsync();
        }
        
        public Client.PersonsReference.Person[] GetPersons() {
            return base.Channel.GetPersons();
        }
        
        public System.Threading.Tasks.Task<Client.PersonsReference.Person[]> GetPersonsAsync() {
            return base.Channel.GetPersonsAsync();
        }
        
        public Client.PersonsReference.Person[] GetPersonsDS() {
            return base.Channel.GetPersonsDS();
        }
        
        public System.Threading.Tasks.Task<Client.PersonsReference.Person[]> GetPersonsDSAsync() {
            return base.Channel.GetPersonsDSAsync();
        }
        
        public Client.PersonsReference.DataModificationResult UpdatePerson(Client.PersonsReference.Person person) {
            return base.Channel.UpdatePerson(person);
        }
        
        public System.Threading.Tasks.Task<Client.PersonsReference.DataModificationResult> UpdatePersonAsync(Client.PersonsReference.Person person) {
            return base.Channel.UpdatePersonAsync(person);
        }
        
        public Client.PersonsReference.DataModificationResult DeletePerson(Client.PersonsReference.Person person) {
            return base.Channel.DeletePerson(person);
        }
        
        public System.Threading.Tasks.Task<Client.PersonsReference.DataModificationResult> DeletePersonAsync(Client.PersonsReference.Person person) {
            return base.Channel.DeletePersonAsync(person);
        }
    }
}
