using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuanLyUserService" in both code and config file together.
    [ServiceContract]
    public interface IQuanLyUserService
    {
        [OperationContract]
        List<KhachHang> ListUser();
        
        [OperationContract]
        List<KhachHang> FindByName(string name);

        [OperationContract]
        int Login(string username, string password);

        [OperationContract]
        KhachHang FindById(int id);

        [OperationContract]
        bool AddUser(KhachHang kh);

        [OperationContract]
        bool AddUserForFacebook(KhachHang kh);

        [OperationContract]
        bool UpdateUser(int id, KhachHang kh);
        [OperationContract]
        KhachHang FindByUsername(string username);
    }
}
