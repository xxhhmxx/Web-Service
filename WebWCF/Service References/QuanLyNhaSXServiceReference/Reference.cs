﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebWCF.QuanLyNhaSXServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NhaSX", Namespace="http://schemas.datacontract.org/2004/07/WcfService.EF")]
    [System.SerializableAttribute()]
    public partial class NhaSX : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NhaSX_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebWCF.QuanLyNhaSXServiceReference.SanPham> SanPhamsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenNhaSXField;
        
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
        public int NhaSX_ID {
            get {
                return this.NhaSX_IDField;
            }
            set {
                if ((this.NhaSX_IDField.Equals(value) != true)) {
                    this.NhaSX_IDField = value;
                    this.RaisePropertyChanged("NhaSX_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<WebWCF.QuanLyNhaSXServiceReference.SanPham> SanPhams {
            get {
                return this.SanPhamsField;
            }
            set {
                if ((object.ReferenceEquals(this.SanPhamsField, value) != true)) {
                    this.SanPhamsField = value;
                    this.RaisePropertyChanged("SanPhams");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenNhaSX {
            get {
                return this.TenNhaSXField;
            }
            set {
                if ((object.ReferenceEquals(this.TenNhaSXField, value) != true)) {
                    this.TenNhaSXField = value;
                    this.RaisePropertyChanged("TenNhaSX");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SanPham", Namespace="http://schemas.datacontract.org/2004/07/WcfService.EF")]
    [System.SerializableAttribute()]
    public partial class SanPham : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> DonGiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManhinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> NhaSX_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RAMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
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
        public string CPU {
            get {
                return this.CPUField;
            }
            set {
                if ((object.ReferenceEquals(this.CPUField, value) != true)) {
                    this.CPUField = value;
                    this.RaisePropertyChanged("CPU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> DonGia {
            get {
                return this.DonGiaField;
            }
            set {
                if ((this.DonGiaField.Equals(value) != true)) {
                    this.DonGiaField = value;
                    this.RaisePropertyChanged("DonGia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hinh {
            get {
                return this.HinhField;
            }
            set {
                if ((object.ReferenceEquals(this.HinhField, value) != true)) {
                    this.HinhField = value;
                    this.RaisePropertyChanged("Hinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Manhinh {
            get {
                return this.ManhinhField;
            }
            set {
                if ((object.ReferenceEquals(this.ManhinhField, value) != true)) {
                    this.ManhinhField = value;
                    this.RaisePropertyChanged("Manhinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> NhaSX_ID {
            get {
                return this.NhaSX_IDField;
            }
            set {
                if ((this.NhaSX_IDField.Equals(value) != true)) {
                    this.NhaSX_IDField = value;
                    this.RaisePropertyChanged("NhaSX_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pin {
            get {
                return this.PinField;
            }
            set {
                if ((object.ReferenceEquals(this.PinField, value) != true)) {
                    this.PinField = value;
                    this.RaisePropertyChanged("Pin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RAM {
            get {
                return this.RAMField;
            }
            set {
                if ((object.ReferenceEquals(this.RAMField, value) != true)) {
                    this.RAMField = value;
                    this.RaisePropertyChanged("RAM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SP_ID {
            get {
                return this.SP_IDField;
            }
            set {
                if ((this.SP_IDField.Equals(value) != true)) {
                    this.SP_IDField = value;
                    this.RaisePropertyChanged("SP_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuanLyNhaSXServiceReference.IQuanLyNhaSxService")]
    public interface IQuanLyNhaSxService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/HienThiNhaSX", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/HienThiNhaSXResponse")]
        System.Collections.Generic.List<WebWCF.QuanLyNhaSXServiceReference.NhaSX> HienThiNhaSX();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/HienThiNhaSX", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/HienThiNhaSXResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyNhaSXServiceReference.NhaSX>> HienThiNhaSXAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/Them", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/ThemResponse")]
        void Them(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/Them", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/ThemResponse")]
        System.Threading.Tasks.Task ThemAsync(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/Sua", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/SuaResponse")]
        void Sua(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/Sua", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/SuaResponse")]
        System.Threading.Tasks.Task SuaAsync(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/Xoa", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/XoaResponse")]
        void Xoa(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyNhaSxService/Xoa", ReplyAction="http://tempuri.org/IQuanLyNhaSxService/XoaResponse")]
        System.Threading.Tasks.Task XoaAsync(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuanLyNhaSxServiceChannel : WebWCF.QuanLyNhaSXServiceReference.IQuanLyNhaSxService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuanLyNhaSxServiceClient : System.ServiceModel.ClientBase<WebWCF.QuanLyNhaSXServiceReference.IQuanLyNhaSxService>, WebWCF.QuanLyNhaSXServiceReference.IQuanLyNhaSxService {
        
        public QuanLyNhaSxServiceClient() {
        }
        
        public QuanLyNhaSxServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuanLyNhaSxServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuanLyNhaSxServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuanLyNhaSxServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WebWCF.QuanLyNhaSXServiceReference.NhaSX> HienThiNhaSX() {
            return base.Channel.HienThiNhaSX();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyNhaSXServiceReference.NhaSX>> HienThiNhaSXAsync() {
            return base.Channel.HienThiNhaSXAsync();
        }
        
        public void Them(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx) {
            base.Channel.Them(nsx);
        }
        
        public System.Threading.Tasks.Task ThemAsync(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx) {
            return base.Channel.ThemAsync(nsx);
        }
        
        public void Sua(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx) {
            base.Channel.Sua(nsx);
        }
        
        public System.Threading.Tasks.Task SuaAsync(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx) {
            return base.Channel.SuaAsync(nsx);
        }
        
        public void Xoa(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx) {
            base.Channel.Xoa(nsx);
        }
        
        public System.Threading.Tasks.Task XoaAsync(WebWCF.QuanLyNhaSXServiceReference.NhaSX nsx) {
            return base.Channel.XoaAsync(nsx);
        }
    }
}
