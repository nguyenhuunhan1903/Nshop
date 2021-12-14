using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class NShopContext : DbContext
    {
        public NShopContext()
        {
        }

        public NShopContext(DbContextOptions<NShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Catalogs> Catalogs { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=NShop;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__ADMINS__59AF14B5C7CC4DE1");

                entity.ToTable("ADMINS");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(36);

                entity.Property(e => e.Userpassword)
                    .HasColumnName("USERPASSWORD")
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

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

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
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

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_TRANSACTION");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__USERS__7B9E7F351F29AAF4");

                entity.ToTable("USERS");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDay)
                    .HasColumnName("CREATE_DAY")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("USER_PASSWORD")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.YourAddress)
                    .HasColumnName("YOUR_ADDRESS")
                    .HasMaxLength(128);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
