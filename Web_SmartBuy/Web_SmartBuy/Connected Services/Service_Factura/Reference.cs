﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_SmartBuy.Service_Factura {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WishList", Namespace="http://schemas.datacontract.org/2004/07/WCF_Factura.Models")]
    [System.SerializableAttribute()]
    public partial class WishList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CANTIDADField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_PRODUCTOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_WISHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MARCAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NOMBREField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PRECIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TOTALField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string USERNAMEField;
        
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
        public int CANTIDAD {
            get {
                return this.CANTIDADField;
            }
            set {
                if ((this.CANTIDADField.Equals(value) != true)) {
                    this.CANTIDADField = value;
                    this.RaisePropertyChanged("CANTIDAD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_PRODUCTO {
            get {
                return this.ID_PRODUCTOField;
            }
            set {
                if ((this.ID_PRODUCTOField.Equals(value) != true)) {
                    this.ID_PRODUCTOField = value;
                    this.RaisePropertyChanged("ID_PRODUCTO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_WISH {
            get {
                return this.ID_WISHField;
            }
            set {
                if ((this.ID_WISHField.Equals(value) != true)) {
                    this.ID_WISHField = value;
                    this.RaisePropertyChanged("ID_WISH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MARCA {
            get {
                return this.MARCAField;
            }
            set {
                if ((object.ReferenceEquals(this.MARCAField, value) != true)) {
                    this.MARCAField = value;
                    this.RaisePropertyChanged("MARCA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NOMBRE {
            get {
                return this.NOMBREField;
            }
            set {
                if ((object.ReferenceEquals(this.NOMBREField, value) != true)) {
                    this.NOMBREField = value;
                    this.RaisePropertyChanged("NOMBRE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PRECIO {
            get {
                return this.PRECIOField;
            }
            set {
                if ((this.PRECIOField.Equals(value) != true)) {
                    this.PRECIOField = value;
                    this.RaisePropertyChanged("PRECIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TOTAL {
            get {
                return this.TOTALField;
            }
            set {
                if ((this.TOTALField.Equals(value) != true)) {
                    this.TOTALField = value;
                    this.RaisePropertyChanged("TOTAL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string USERNAME {
            get {
                return this.USERNAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.USERNAMEField, value) != true)) {
                    this.USERNAMEField = value;
                    this.RaisePropertyChanged("USERNAME");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service_Factura.IMetodos")]
    public interface IMetodos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetodos/AgregarItem", ReplyAction="http://tempuri.org/IMetodos/AgregarItemResponse")]
        bool AgregarItem(Web_SmartBuy.Service_Factura.WishList Item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetodos/AgregarItem", ReplyAction="http://tempuri.org/IMetodos/AgregarItemResponse")]
        System.Threading.Tasks.Task<bool> AgregarItemAsync(Web_SmartBuy.Service_Factura.WishList Item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetodos/ConsultarLista", ReplyAction="http://tempuri.org/IMetodos/ConsultarListaResponse")]
        Web_SmartBuy.Service_Factura.WishList[] ConsultarLista(string UserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetodos/ConsultarLista", ReplyAction="http://tempuri.org/IMetodos/ConsultarListaResponse")]
        System.Threading.Tasks.Task<Web_SmartBuy.Service_Factura.WishList[]> ConsultarListaAsync(string UserName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMetodosChannel : Web_SmartBuy.Service_Factura.IMetodos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MetodosClient : System.ServiceModel.ClientBase<Web_SmartBuy.Service_Factura.IMetodos>, Web_SmartBuy.Service_Factura.IMetodos {
        
        public MetodosClient() {
        }
        
        public MetodosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MetodosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetodosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetodosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AgregarItem(Web_SmartBuy.Service_Factura.WishList Item) {
            return base.Channel.AgregarItem(Item);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarItemAsync(Web_SmartBuy.Service_Factura.WishList Item) {
            return base.Channel.AgregarItemAsync(Item);
        }
        
        public Web_SmartBuy.Service_Factura.WishList[] ConsultarLista(string UserName) {
            return base.Channel.ConsultarLista(UserName);
        }
        
        public System.Threading.Tasks.Task<Web_SmartBuy.Service_Factura.WishList[]> ConsultarListaAsync(string UserName) {
            return base.Channel.ConsultarListaAsync(UserName);
        }
    }
}