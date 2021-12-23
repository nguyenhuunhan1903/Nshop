﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nshop.Models;

namespace Nshop.Migrations
{
    [DbContext(typeof(NShopContext))]
    partial class NShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"),
                            RoleId = new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Nshop.Models.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6"),
                            ConcurrencyStamp = "6c8e78f8-f105-4235-8515-88f79693005e",
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Nshop.Models.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b52078d3-4220-424e-adda-76d113da9157",
                            Dob = new DateTime(2001, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenhuunhan1903@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nhan",
                            LastName = "Nguyen",
                            LockoutEnabled = false,
                            NormalizedEmail = "nguyenhuunhan1903@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEIstvne3ddQgAfQJ6/PXBycN1pHJVXvIb9f03D1SRlJDUWdni013DPnimThqmQSF8A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Nshop.Models.Catalogs", b =>
                {
                    b.Property<string>("CatalogId")
                        .HasColumnName("CATALOG_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("CatalogName")
                        .HasColumnName("CATALOG_NAME")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("CatalogId")
                        .HasName("PK__CATALOGS__DC3C6591D725476B");

                    b.ToTable("CATALOGS");
                });

            modelBuilder.Entity("Nshop.Models.Orders", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnName("ORDER_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<bool?>("OrderStatus")
                        .HasColumnName("ORDER_STATUS")
                        .HasColumnType("bit");

                    b.Property<string>("ProductId")
                        .HasColumnName("PRODUCT_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<int?>("Quantity")
                        .HasColumnName("QUANTITY")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .HasColumnName("TRANSACTION_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.HasKey("OrderId")
                        .HasName("PK__ORDERS__460A9464D0E0B109");

                    b.HasIndex("ProductId");

                    b.HasIndex("TransactionId");

                    b.ToTable("ORDERS");
                });

            modelBuilder.Entity("Nshop.Models.Products", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnName("PRODUCT_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("CatalogId")
                        .HasColumnName("CATALOG_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("Descriptions")
                        .HasColumnName("DESCRIPTIONS")
                        .HasColumnType("ntext");

                    b.Property<string>("Detail")
                        .HasColumnName("DETAIL")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("Discount")
                        .HasColumnName("DISCOUNT")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .HasColumnName("IMAGE_LINK")
                        .HasColumnType("ntext");

                    b.Property<decimal?>("Price")
                        .HasColumnName("PRICE")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<string>("ProductName")
                        .HasColumnName("PRODUCT_NAME")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Quantity")
                        .HasColumnName("QUANTITY")
                        .HasColumnType("int");

                    b.HasKey("ProductId")
                        .HasName("PK__PRODUCTS__52B41763D50E6E50");

                    b.HasIndex("CatalogId");

                    b.ToTable("PRODUCTS");
                });

            modelBuilder.Entity("Nshop.Models.Transactions", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnName("TRANSACTION_ID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<decimal?>("Amount")
                        .HasColumnName("AMOUNT")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<DateTime?>("CreateDay")
                        .HasColumnName("CREATE_DAY")
                        .HasColumnType("datetime");

                    b.Property<string>("MessageT")
                        .HasColumnName("MESSAGE_T")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Payment")
                        .HasColumnName("PAYMENT")
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.Property<Guid>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TransactionId")
                        .HasName("PK__TRANSACT__16998B61D7E98AD9");

                    b.HasIndex("Userid");

                    b.ToTable("TRANSACTIONS");
                });

            modelBuilder.Entity("Nshop.Models.Orders", b =>
                {
                    b.HasOne("Nshop.Models.Products", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_PRODUCT");

                    b.HasOne("Nshop.Models.Transactions", "Transaction")
                        .WithMany("Orders")
                        .HasForeignKey("TransactionId")
                        .HasConstraintName("FK_ORDER");
                });

            modelBuilder.Entity("Nshop.Models.Products", b =>
                {
                    b.HasOne("Nshop.Models.Catalogs", "Catalog")
                        .WithMany("Products")
                        .HasForeignKey("CatalogId")
                        .HasConstraintName("FK_CATALOGS");
                });

            modelBuilder.Entity("Nshop.Models.Transactions", b =>
                {
                    b.HasOne("Nshop.Models.AppUser", "AppUser")
                        .WithMany("Transactions")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
