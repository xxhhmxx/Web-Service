namespace WcfService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        public int MaPhieuNhap { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        public int TongTien { get; set; }

        public virtual CT_PhieuNhap CT_PhieuNhap { get; set; }
    }
}
