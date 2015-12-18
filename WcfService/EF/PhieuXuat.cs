namespace WcfService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuat")]
    public partial class PhieuXuat
    {
        [Key]
        public int MaPhieuXuat { get; set; }

        public int MaDonDH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXuat { get; set; }

        public virtual CT_PhieuXuat CT_PhieuXuat { get; set; }
    }
}
