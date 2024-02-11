using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LLC._Dishes
{
    public partial class LLCDishesContext : DbContext
    {
        public LLCDishesContext()
        {
        }

        public LLCDishesContext(DbContextOptions<LLCDishesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Dish> Dishes { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<PickUpPoint> PickUpPoints { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS01; database=LLC Dishes; Trusted_Connection = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("Category");

                entity.Property(e => e.IdCategory)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Category");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Category");
            });

            modelBuilder.Entity<Dish>(entity =>
            {
                entity.HasKey(e => e.Article);

                entity.Property(e => e.Article)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveDiscount).HasColumnName("Active_Discount");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.DishName)
                    .HasMaxLength(50)
                    .HasColumnName("Dish_Name");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_ID");

                entity.Property(e => e.MaxDiscount).HasColumnName("Max_Discount");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Dishes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dishes_Category");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Dishes)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dishes_Manufacturer");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Dishes)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dishes_Supplier");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.IdManufacturer);

                entity.ToTable("Manufacturer");

                entity.Property(e => e.IdManufacturer)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Manufacturer");

                entity.Property(e => e.NameManufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("Name_Manufacturer");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("Order_ID");

                entity.Property(e => e.AmountOrder).HasColumnName("Amount_Order");

                entity.Property(e => e.ClientFio)
                    .HasMaxLength(50)
                    .HasColumnName("Client_FIO");

                entity.Property(e => e.IdPickUp).HasColumnName("ID_PickUp");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_Date");

                entity.Property(e => e.OrderDoneDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_DoneDate");

                entity.Property(e => e.OrderList)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_List");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.PickUpCode).HasColumnName("PickUp_Code");

                entity.HasOne(d => d.IdPickUpNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdPickUp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_PickUpPoints");

                entity.HasOne(d => d.OrderListNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderList)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Dishes");
            });

            modelBuilder.Entity<PickUpPoint>(entity =>
            {
                entity.HasKey(e => e.PickUpId);

                entity.Property(e => e.PickUpId)
                    .ValueGeneratedNever()
                    .HasColumnName("PickUp_Id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("City_Name");

                entity.Property(e => e.HouseNumber).HasColumnName("House_Number");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(50)
                    .HasColumnName("Street_Name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.Property(e => e.IdRole).ValueGeneratedNever();

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("Supplier_Id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .HasColumnName("Supplier_Name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .HasColumnName("FIO");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
