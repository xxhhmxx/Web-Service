using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICT_DHService" in both code and config file together.
    [ServiceContract]
    public interface ICT_DHService
    {
        [OperationContract]
        List<CT_DonDH> HienThiCT_DonDH(CT_DonDH ct);
        [OperationContract]
        void Xoa(CT_DonDH ct);
    }
}
