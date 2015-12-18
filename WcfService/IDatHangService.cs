using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDatHangService" in both code and config file together.
    [ServiceContract]
    public interface IDatHangService
    {
        [OperationContract(Name = "CartService")]
        bool DatHang(string ten, string sdt, string email, string diachi, string total, string id, List<CartItem> cart);

        [OperationContract]
        List<object> History(int id);
    }
}
