﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebWCF.QuanLyDonHangServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DonDH", Namespace="http://schemas.datacontract.org/2004/07/WcfService.EF")]
    [System.SerializableAttribute()]
    public partial class DonDH : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GhiChuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaDonDHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaKhachHangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgayDatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> NgayGiaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SDTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TinhTrangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TongTienField;
        
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
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GhiChu {
            get {
                return this.GhiChuField;
            }
            set {
                if ((object.ReferenceEquals(this.GhiChuField, value) != true)) {
                    this.GhiChuField = value;
                    this.RaisePropertyChanged("GhiChu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaDonDH {
            get {
                return this.MaDonDHField;
            }
            set {
                if ((this.MaDonDHField.Equals(value) != true)) {
                    this.MaDonDHField = value;
                    this.RaisePropertyChanged("MaDonDH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaKhachHang {
            get {
                return this.MaKhachHangField;
            }
            set {
                if ((this.MaKhachHangField.Equals(value) != true)) {
                    this.MaKhachHangField = value;
                    this.RaisePropertyChanged("MaKhachHang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NgayDat {
            get {
                return this.NgayDatField;
            }
            set {
                if ((this.NgayDatField.Equals(value) != true)) {
                    this.NgayDatField = value;
                    this.RaisePropertyChanged("NgayDat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> NgayGiao {
            get {
                return this.NgayGiaoField;
            }
            set {
                if ((this.NgayGiaoField.Equals(value) != true)) {
                    this.NgayGiaoField = value;
                    this.RaisePropertyChanged("NgayGiao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SDT {
            get {
                return this.SDTField;
            }
            set {
                if ((object.ReferenceEquals(this.SDTField, value) != true)) {
                    this.SDTField = value;
                    this.RaisePropertyChanged("SDT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ten {
            get {
                return this.TenField;
            }
            set {
                if ((object.ReferenceEquals(this.TenField, value) != true)) {
                    this.TenField = value;
                    this.RaisePropertyChanged("Ten");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TinhTrang {
            get {
                return this.TinhTrangField;
            }
            set {
                if ((object.ReferenceEquals(this.TinhTrangField, value) != true)) {
                    this.TinhTrangField = value;
                    this.RaisePropertyChanged("TinhTrang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TongTien {
            get {
                return this.TongTienField;
            }
            set {
                if ((this.TongTienField.Equals(value) != true)) {
                    this.TongTienField = value;
                    this.RaisePropertyChanged("TongTien");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuanLyDonHangServiceReference.IQuanLyDonHang")]
    public interface IQuanLyDonHang {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/HienThiDonDH", ReplyAction="http://tempuri.org/IQuanLyDonHang/HienThiDonDHResponse")]
        System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> HienThiDonDH();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/HienThiDonDH", ReplyAction="http://tempuri.org/IQuanLyDonHang/HienThiDonDHResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> HienThiDonDHAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/TimKiem_MaDH", ReplyAction="http://tempuri.org/IQuanLyDonHang/TimKiem_MaDHResponse")]
        System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> TimKiem_MaDH(string madondh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/TimKiem_MaDH", ReplyAction="http://tempuri.org/IQuanLyDonHang/TimKiem_MaDHResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> TimKiem_MaDHAsync(string madondh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/TimKiem_NgayDat", ReplyAction="http://tempuri.org/IQuanLyDonHang/TimKiem_NgayDatResponse")]
        System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> TimKiem_NgayDat(System.DateTime ngaydat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/TimKiem_NgayDat", ReplyAction="http://tempuri.org/IQuanLyDonHang/TimKiem_NgayDatResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> TimKiem_NgayDatAsync(System.DateTime ngaydat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/TimKiem_TinhTrang", ReplyAction="http://tempuri.org/IQuanLyDonHang/TimKiem_TinhTrangResponse")]
        System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> TimKiem_TinhTrang(string tinhtrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/TimKiem_TinhTrang", ReplyAction="http://tempuri.org/IQuanLyDonHang/TimKiem_TinhTrangResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> TimKiem_TinhTrangAsync(string tinhtrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/Sua_DH", ReplyAction="http://tempuri.org/IQuanLyDonHang/Sua_DHResponse")]
        void Sua_DH(WebWCF.QuanLyDonHangServiceReference.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/Sua_DH", ReplyAction="http://tempuri.org/IQuanLyDonHang/Sua_DHResponse")]
        System.Threading.Tasks.Task Sua_DHAsync(WebWCF.QuanLyDonHangServiceReference.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/Xoa", ReplyAction="http://tempuri.org/IQuanLyDonHang/XoaResponse")]
        void Xoa(WebWCF.QuanLyDonHangServiceReference.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuanLyDonHang/Xoa", ReplyAction="http://tempuri.org/IQuanLyDonHang/XoaResponse")]
        System.Threading.Tasks.Task XoaAsync(WebWCF.QuanLyDonHangServiceReference.DonDH ddh);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuanLyDonHangChannel : WebWCF.QuanLyDonHangServiceReference.IQuanLyDonHang, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuanLyDonHangClient : System.ServiceModel.ClientBase<WebWCF.QuanLyDonHangServiceReference.IQuanLyDonHang>, WebWCF.QuanLyDonHangServiceReference.IQuanLyDonHang {
        
        public QuanLyDonHangClient() {
        }
        
        public QuanLyDonHangClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuanLyDonHangClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuanLyDonHangClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuanLyDonHangClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> HienThiDonDH() {
            return base.Channel.HienThiDonDH();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> HienThiDonDHAsync() {
            return base.Channel.HienThiDonDHAsync();
        }
        
        public System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> TimKiem_MaDH(string madondh) {
            return base.Channel.TimKiem_MaDH(madondh);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> TimKiem_MaDHAsync(string madondh) {
            return base.Channel.TimKiem_MaDHAsync(madondh);
        }
        
        public System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> TimKiem_NgayDat(System.DateTime ngaydat) {
            return base.Channel.TimKiem_NgayDat(ngaydat);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> TimKiem_NgayDatAsync(System.DateTime ngaydat) {
            return base.Channel.TimKiem_NgayDatAsync(ngaydat);
        }
        
        public System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH> TimKiem_TinhTrang(string tinhtrang) {
            return base.Channel.TimKiem_TinhTrang(tinhtrang);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebWCF.QuanLyDonHangServiceReference.DonDH>> TimKiem_TinhTrangAsync(string tinhtrang) {
            return base.Channel.TimKiem_TinhTrangAsync(tinhtrang);
        }
        
        public void Sua_DH(WebWCF.QuanLyDonHangServiceReference.DonDH ddh) {
            base.Channel.Sua_DH(ddh);
        }
        
        public System.Threading.Tasks.Task Sua_DHAsync(WebWCF.QuanLyDonHangServiceReference.DonDH ddh) {
            return base.Channel.Sua_DHAsync(ddh);
        }
        
        public void Xoa(WebWCF.QuanLyDonHangServiceReference.DonDH ddh) {
            base.Channel.Xoa(ddh);
        }
        
        public System.Threading.Tasks.Task XoaAsync(WebWCF.QuanLyDonHangServiceReference.DonDH ddh) {
            return base.Channel.XoaAsync(ddh);
        }
    }
}
