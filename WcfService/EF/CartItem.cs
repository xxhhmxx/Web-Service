using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using WcfService.EF;

namespace Service.Models
{
    [Serializable]
    [DataContract]
    public class CartItem
    {
        [DataMember]
        public SanPham Product { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}