using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuanLyTonKho" in both code and config file together.
    [ServiceContract]
    public interface IQuanLyTonKho
    {
        [OperationContract]
        List<TonKho> HienThiTonKho();
        [OperationContract]
        List<TonKho> TimKiemTonKho_SPID(TonKho tk);
        [OperationContract]
        List<TonKho> TimKiemTonKho_Ngay(DateTime ngaytu, DateTime ngayden);
        [OperationContract]
        List<TonKho> TimKiemTonKho_SoLuongTon(int k);
        [OperationContract]
        void Them_Moi(TonKho tk);
        [OperationContract]
        void Them_Nhap(TonKho tk);
        [OperationContract]
        void Them_Xuat(TonKho tk);
        [OperationContract]
        void Xoa(TonKho tk);

        [OperationContract]
        TonKho TimTheoSPID(int id);
    }
}
