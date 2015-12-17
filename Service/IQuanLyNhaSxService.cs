﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.EF;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuanLyNhaSxService" in both code and config file together.
    [ServiceContract]
    public interface IQuanLyNhaSxService
    {
        [OperationContract]
        List<NhaSX> HienThiNhaSX();
        [OperationContract]
        void Them(NhaSX nsx);
        [OperationContract]
        void Sua(NhaSX nsx);
        [OperationContract]
        void Xoa(NhaSX nsx);
    }
}
