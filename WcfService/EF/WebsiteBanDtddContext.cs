namespace WcfService.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebsiteBanDtddContext : DbContext
    {
        public WebsiteBanDtddContext()
            : base("name=WebsiteBanDtddContext")
        {
        }

        public virtual DbSet<CT_PhieuNhap> CT_PhieuNhap { get; set; }
        public virtual DbSet<CT_PhieuXuat> CT_PhieuXuat { get; set; }
        public virtual DbSet<DonDH> DonDHs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaSX> NhaSXes { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<CT_DonDH> CT_DonDH { get; set; }
        public virtual DbSet<TonKho> TonKhoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_PhieuXuat>()
                .HasOptional(e => e.PhieuXuat)
                .WithRequired(e => e.CT_PhieuXuat);

            modelBuilder.Entity<DonDH>()
                .HasMany(e => e.CT_DonDH)
                .WithRequired(e => e.DonDH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasOptional(e => e.CT_PhieuNhap)
                .WithRequired(e => e.PhieuNhap);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Manhinh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.RAM)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.CPU)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Hinh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CT_PhieuNhap)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CT_DonDH)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.TonKhoes)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);
        }
    }
}
