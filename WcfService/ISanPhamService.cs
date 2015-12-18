using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISanPhamService" in both code and config file together.
    [ServiceContract]
    public interface ISanPhamService
    {
        [OperationContract(Name ="ShowListProduct")]
        List<SanPham> DsSanPham();

        [OperationContract(Name ="FindByID")]
        SanPham TimTheoId(int id);

        [OperationContract(Name ="AddProduct")]
        int ThemSanPham(SanPham sp);

        [OperationContract(Name ="UpdateProduct")]
        bool SuaSanPham(int id, SanPham sp);
        
        [OperationContract(Name = "FindByName")]
        List<SanPham> TimTheoTen(string ten_sp);
        
        [OperationContract(Name = "FindByManu")]
        List<SanPham> TimTheoNhaSX(string nhaSx);

        [OperationContract(Name = "Delete")]
        bool XoaSanPham(int id);
    }
}
