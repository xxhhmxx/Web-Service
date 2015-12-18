using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.EF
{
    [DataContract]
    class LoginModel
    {
        [DataMember]
        [Required(ErrorMessage ="Vui lòng nhập tài khoản")]
        public string Username { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }
    }
}
