using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Da1CoffeeContext : DbContext
{
    public Da1CoffeeContext()
    {
    }

    public Da1CoffeeContext(DbContextOptions<Da1CoffeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DichVuPhatSinh> DichVuPhatSinhs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<MemberShipRank> MemberShipRanks { get; set; }

    public virtual DbSet<NguyenLieu> NguyenLieus { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhaChe> PhaChes { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ISORA;Initial Catalog=DA1_Coffee;Persist Security Info=True;\n        Integrated Security = True; Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DichVuPhatSinh>(entity =>
        {
            entity.HasKey(e => e.IddichVuPhatSinh).HasName("PK__DichVuPh__87E4E2CEA6015F0F");

            entity.ToTable("DichVuPhatSinh");

            entity.Property(e => e.IddichVuPhatSinh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDDichVuPhatSinh");
            entity.Property(e => e.ChiTiet).HasMaxLength(50);
            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDHoaDon");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.DichVuPhatSinhs)
                .HasForeignKey(d => d.IdhoaDon)
                .HasConstraintName("fk_HD_DVPS");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdhoaDon).HasName("PK__HoaDon__5B896F49AD788A91");

            entity.ToTable("HoaDon");

            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDHoaDon");
            entity.Property(e => e.IdkhachHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDKhachHang");
            entity.Property(e => e.IdnhanVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNhanVien");
            entity.Property(e => e.Idvoucher)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDVoucher");
            entity.Property(e => e.NgayBan).HasColumnType("date");

            entity.HasOne(d => d.IdkhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdkhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_KH_HD");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdnhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_NV_HD");

            entity.HasOne(d => d.IdvoucherNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.Idvoucher)
                .HasConstraintName("fk_V_HD");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdhoaDonChiTiet).HasName("PK__HoaDonCh__21C2367756B5946E");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.IdhoaDonChiTiet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDHoaDonChiTiet");
            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDHoaDon");
            entity.Property(e => e.IdsanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDSanPham");
            entity.Property(e => e.NgayXuatDon).HasColumnType("date");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdhoaDon)
                .HasConstraintName("fk_HD_HDCT");

            entity.HasOne(d => d.IdsanPhamNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdsanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SP_HDCT");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdkhachHang).HasName("PK__KhachHan__5A7167B5F3BE4020");

            entity.ToTable("KhachHang");

            entity.Property(e => e.IdkhachHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDKhachHang");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Idrank)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDRank");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");

            entity.HasOne(d => d.IdrankNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.Idrank)
                .HasConstraintName("fk_MR_KH");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.IdloaiSanPham).HasName("PK__LoaiSanP__6CB987C5F92C44E4");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.IdloaiSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDLoaiSanPham");
            entity.Property(e => e.IdnhanVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNhanVien");
            entity.Property(e => e.TenLoaiSanPham).HasMaxLength(50);
        });

        modelBuilder.Entity<MemberShipRank>(entity =>
        {
            entity.HasKey(e => e.Idrank).HasName("PK__MemberSh__AFFF681D5594D262");

            entity.ToTable("MemberShipRank");

            entity.Property(e => e.Idrank)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDRank");
            entity.Property(e => e.RankName).HasMaxLength(50);
        });

        modelBuilder.Entity<NguyenLieu>(entity =>
        {
            entity.HasKey(e => e.IdnguyenLieu).HasName("PK__NguyenLi__209F08FF0C99F5CB");

            entity.ToTable("NguyenLieu");

            entity.Property(e => e.IdnguyenLieu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNguyenLieu");
            entity.Property(e => e.NgayHetHan).HasColumnType("date");
            entity.Property(e => e.NgayNhap).HasColumnType("date");
            entity.Property(e => e.TenNguyenLieu).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdnhanVien).HasName("PK__NhanVien__7AC2D9F754D236BD");

            entity.ToTable("NhanVien");

            entity.Property(e => e.IdnhanVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNhanVien");
            entity.Property(e => e.LoginName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PhaChe>(entity =>
        {
            entity.HasKey(e => e.IdphaChe).HasName("PK__PhaChe__1035F7DE292D911C");

            entity.ToTable("PhaChe");

            entity.Property(e => e.IdphaChe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDPhaChe");
            entity.Property(e => e.IdnguyenLieu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNguyenLieu");
            entity.Property(e => e.IdsanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDSanPham");

            entity.HasOne(d => d.IdnguyenLieuNavigation).WithMany(p => p.PhaChes)
                .HasForeignKey(d => d.IdnguyenLieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_NL_PC");

            entity.HasOne(d => d.IdsanPhamNavigation).WithMany(p => p.PhaChes)
                .HasForeignKey(d => d.IdsanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SP_PC");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Idsale).HasName("PK__Sale__C6F3BA0B0FCBAB93");

            entity.ToTable("Sale");

            entity.Property(e => e.Idsale)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDSale");
            entity.Property(e => e.IdsanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDSanPham");
            entity.Property(e => e.NgayBatDau).HasColumnType("date");
            entity.Property(e => e.NgayKetThuc).HasColumnType("date");
            entity.Property(e => e.TenChuongTrinh).HasMaxLength(50);

            entity.HasOne(d => d.IdsanPhamNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdsanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SP_S");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdsanPham).HasName("PK__SanPham__9D45E58A53D8F413");

            entity.ToTable("SanPham");

            entity.Property(e => e.IdsanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDSanPham");
            entity.Property(e => e.HinhAnh).HasMaxLength(100);
            entity.Property(e => e.IdloaiSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDLoaiSanPham");
            entity.Property(e => e.TenSanPham).HasMaxLength(50);

            entity.HasOne(d => d.IdloaiSanPhamNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdloaiSanPham)
                .HasConstraintName("fk_LSP_SP");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Idvoucher).HasName("PK__Voucher__50249A27E1DEB5F2");

            entity.ToTable("Voucher");

            entity.Property(e => e.Idvoucher)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDVoucher");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateEnd).HasColumnType("date");
            entity.Property(e => e.DateStart).HasColumnType("date");
            entity.Property(e => e.DieuKienApDung).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
