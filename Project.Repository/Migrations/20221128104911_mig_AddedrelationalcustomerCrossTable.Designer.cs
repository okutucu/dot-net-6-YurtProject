﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Repository.Context;

#nullable disable

namespace Project.Repository.Migrations
{
    [DbContext(typeof(YurtDbContext))]
    [Migration("20221128104911_mig_AddedrelationalcustomerCrossTable")]
    partial class mig_AddedrelationalcustomerCrossTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CustomerCustomerImageFile", b =>
                {
                    b.Property<int>("CustomerImageFilesId")
                        .HasColumnType("int");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.HasKey("CustomerImageFilesId", "CustomersId");

                    b.HasIndex("CustomersId");

                    b.ToTable("CustomerCustomerImageFile");
                });

            modelBuilder.Entity("Project.Core.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4860),
                            Password = "$2a$11$6.1NhhQ.IJLM.geodBTAper6qewZ/MzzykZaLPFRoy3z6.Oh8gMCS",
                            Role = 1,
                            UpdatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4914),
                            UserName = "superadmin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4924),
                            Password = "$2a$11$BJXiFsn8LdEs3MskFa66c.Ml7iuLfbwc3r6kGvS.JOu0JxBVrOr.u",
                            Role = 2,
                            UpdatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4930),
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4933),
                            Password = "$2a$11$Qfd52wt4Q.MVv7N1LapJ5uEWNQir60d.Q/h0saUA.RMIYLyVjeoOi",
                            Role = 3,
                            UpdatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4984),
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Project.Core.Models.AppUserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("AppUserDetail");
                });

            modelBuilder.Entity("Project.Core.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("Depart")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Discount")
                        .HasColumnType("bit");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("DownPayment")
                        .HasColumnType("bit");

                    b.Property<decimal>("DownPaymentPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("date");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdentityNo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RelativeNameSurname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RelativePhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Project.Core.Models.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExchangeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ExchangeRates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3603),
                            ExchangeName = "Dollar",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3667),
                            ExchangeName = "Euro",
                            Price = 10m
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3678),
                            ExchangeName = "Sterling",
                            Price = 10m
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3683),
                            ExchangeName = "Tl",
                            Price = 1m
                        });
                });

            modelBuilder.Entity("Project.Core.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");

                    b.HasDiscriminator<string>("Discriminator").HasValue("File");
                });

            modelBuilder.Entity("Project.Core.Models.IncomeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Exchange")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("MoneyOfTheDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("PaymentMethod")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<int>("PaymentName")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("IncomeDetails");
                });

            modelBuilder.Entity("Project.Core.Models.PaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Exchange")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("MoneyOfTheDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("PaymentMethod")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<int>("PaymentName")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("Project.Core.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Depart")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("date");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdentityNo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RelativeNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelativePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomName")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("Project.Core.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentCapacity")
                        .HasColumnType("int");

                    b.Property<decimal>("Debt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Lack")
                        .HasColumnType("bit");

                    b.Property<string>("LackDetail")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Project.Core.Models.RoomIncome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Exchange")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("MoneyOfTheDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("PaymentMethod")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomIncomes");
                });

            modelBuilder.Entity("Project.Core.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("IncreasedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoomType");
                });

            modelBuilder.Entity("Project.Core.Models.CustomerImageFile", b =>
                {
                    b.HasBaseType("Project.Core.Models.File");

                    b.HasDiscriminator().HasValue("CustomerImageFile");
                });

            modelBuilder.Entity("Project.Core.Models.OtherIncomeImageFile", b =>
                {
                    b.HasBaseType("Project.Core.Models.File");

                    b.HasDiscriminator().HasValue("OtherIncomeImageFile");
                });

            modelBuilder.Entity("Project.Core.Models.PaymentImageFile", b =>
                {
                    b.HasBaseType("Project.Core.Models.File");

                    b.HasDiscriminator().HasValue("PaymentImageFile");
                });

            modelBuilder.Entity("Project.Core.Models.RoomIncomesImageFile", b =>
                {
                    b.HasBaseType("Project.Core.Models.File");

                    b.HasDiscriminator().HasValue("RoomIncomesImageFile");
                });

            modelBuilder.Entity("CustomerCustomerImageFile", b =>
                {
                    b.HasOne("Project.Core.Models.CustomerImageFile", null)
                        .WithMany()
                        .HasForeignKey("CustomerImageFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Core.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Core.Models.AppUserDetail", b =>
                {
                    b.HasOne("Project.Core.Models.AppUser", "AppUser")
                        .WithOne("AppUserDetail")
                        .HasForeignKey("Project.Core.Models.AppUserDetail", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Project.Core.Models.Customer", b =>
                {
                    b.HasOne("Project.Core.Models.Room", "Room")
                        .WithMany("Customers")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Project.Core.Models.IncomeDetail", b =>
                {
                    b.HasOne("Project.Core.Models.Room", "Room")
                        .WithMany("IncomeDetails")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Project.Core.Models.PaymentDetail", b =>
                {
                    b.HasOne("Project.Core.Models.Room", "Room")
                        .WithMany("PaymentDetails")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Project.Core.Models.Room", b =>
                {
                    b.HasOne("Project.Core.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("Project.Core.Models.RoomIncome", b =>
                {
                    b.HasOne("Project.Core.Models.Room", "Room")
                        .WithMany("RoomIncomes")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Project.Core.Models.AppUser", b =>
                {
                    b.Navigation("AppUserDetail");
                });

            modelBuilder.Entity("Project.Core.Models.Room", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("IncomeDetails");

                    b.Navigation("PaymentDetails");

                    b.Navigation("RoomIncomes");
                });

            modelBuilder.Entity("Project.Core.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
