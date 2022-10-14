﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApiApp.Data;

namespace MyWebApiApp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWebApiApp.Data.DonHang", b =>
                {
                    b.Property<Guid>("MaDh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiGiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrangDonHang")
                        .HasColumnType("int");

                    b.HasKey("MaDh");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("MyWebApiApp.Data.DonHangChiTiet", b =>
                {
                    b.Property<Guid>("Mahh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaDh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Mahh", "MaDh");

                    b.HasIndex("MaDh");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("MyWebApiApp.Data.HangHoa", b =>
                {
                    b.Property<Guid>("Mahh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int?>("MaLoai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenhh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Mahh");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("MyWebApiApp.Data.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("MyWebApiApp.Data.DonHangChiTiet", b =>
                {
                    b.HasOne("MyWebApiApp.Data.DonHang", "donHang")
                        .WithMany("donHangChiTiets")
                        .HasForeignKey("MaDh")
                        .HasConstraintName("FK_DonHangCT_DonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebApiApp.Data.HangHoa", "hangHoa")
                        .WithMany("donHangChiTiets")
                        .HasForeignKey("Mahh")
                        .HasConstraintName("FK_DonHangCT_HangHoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("donHang");

                    b.Navigation("hangHoa");
                });

            modelBuilder.Entity("MyWebApiApp.Data.HangHoa", b =>
                {
                    b.HasOne("MyWebApiApp.Data.Loai", "Loai")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaLoai");

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("MyWebApiApp.Data.DonHang", b =>
                {
                    b.Navigation("donHangChiTiets");
                });

            modelBuilder.Entity("MyWebApiApp.Data.HangHoa", b =>
                {
                    b.Navigation("donHangChiTiets");
                });

            modelBuilder.Entity("MyWebApiApp.Data.Loai", b =>
                {
                    b.Navigation("HangHoas");
                });
#pragma warning restore 612, 618
        }
    }
}
