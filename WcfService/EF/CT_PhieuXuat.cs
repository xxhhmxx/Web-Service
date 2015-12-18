namespace WcfService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PhieuXuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuXuat { get; set; }

        public int SP_ID { get; set; }

        public int SoLuongXuat { get; set; }

        public int DonGiaXuat { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }
    }
}
