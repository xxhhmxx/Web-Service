namespace WcfService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonDH")]
    public partial class DonDH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonDH()
        {
            CT_DonDH = new HashSet<CT_DonDH>();
        }

        [Key]
        public int MaDonDH { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string DiaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGiao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public int TongTien { get; set; }

        public int? MaKhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonDH> CT_DonDH { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
