using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Nshop.Extensions;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class NShopContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public NShopContext()
        {
        }

        public NShopContext(DbContextOptions<NShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catalogs> Catalogs { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }//thêm vào bảng để thuận tiện truy vấn dữ liệu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("ConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("AppUsers");
                entity.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
                entity.Property(x => x.LastName).HasMaxLength(50).IsRequired();
                entity.Property(x => x.Dob).IsRequired();
                entity.Property(x => x.address).HasColumnName("Address");

            });
            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.ToTable("AppRoles");
                entity.Property(x => x.Description).HasMaxLength(200).IsRequired();
            });
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            modelBuilder.Entity<Catalogs>(entity =>
            {
                entity.HasKey(e => e.CatalogId)
                    .HasName("PK__CATALOGS__DC3C6591D725476B");

                entity.ToTable("CATALOGS");

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CATALOG_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CatalogName)
                    .HasColumnName("CATALOG_NAME")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__ORDERS__460A9464D0E0B109");

                entity.ToTable("ORDERS");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderStatus).HasColumnName("ORDER_STATUS");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TRANSACTION_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PRODUCT");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_ORDER");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__PRODUCTS__52B41763D50E6E50");

                entity.ToTable("PRODUCTS");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CATALOG_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descriptions)
                    .HasColumnName("DESCRIPTIONS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Detail)
                    .HasColumnName("DETAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.ImageLink)
                    .HasColumnName("IMAGE_LINK")
                    .HasColumnType("ntext");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ProductName)
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("FK_CATALOGS");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__TRANSACT__16998B61D7E98AD9");
                entity.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.Userid);
                entity.ToTable("TRANSACTIONS");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TRANSACTION_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreateDay)
                    .HasColumnName("CREATE_DAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageT)
                    .HasColumnName("MESSAGE_T")
                    .HasMaxLength(255);

                entity.Property(e => e.Payment)
                    .HasColumnName("PAYMENT")
                    .HasMaxLength(32)
                    .IsUnicode(false);

               
            });
            //data seeding
            modelBuilder.seed();
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
