using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuanLyDonHang" in both code and config file together.
    [ServiceContract]
    public interface IQuanLyDonHang
    {
        [OperationContract]
        List<DonDH> HienThiDonDH();
        [OperationContract]
        List<DonDH> TimKiem_MaDH(string madondh);
        [OperationContract]
        List<DonDH> TimKiem_NgayDat(DateTime ngaydat);
        [OperationContract]
        List<DonDH> TimKiem_TinhTrang(string tinhtrang);
        //[OperationContract]
        //void Them(DonDH ddh);
        [OperationContract]
        void Sua_DH(DonDH ddh);
        //[OperationContract]
        //void SuaTinhTrang(DonDH ddh);
        [OperationContract]
        void Xoa(DonDH ddh);
    }
}
