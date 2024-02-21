using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data;

public partial class ZooContext : DbContext
{
    public ZooContext()
    {
    }

    public ZooContext(DbContextOptions<ZooContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodType> GoodTypes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderGood> OrderGoods { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<ShipmentGood> ShipmentGoods { get; set; }

    public virtual DbSet<ShipmentGoodList> ShipmentGoodLists { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockLocation> StockLocations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=94.241.175.205;Port=60345;Database=zoo;Username=postgres;Password=IhateP0stgr4sM0m4nt");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasKey(e => e.GoodId).HasName("Good_pkey");

            entity.ToTable("Good");

            entity.Property(e => e.GoodId)
                .ValueGeneratedNever()
                .HasColumnName("GoodID");
            entity.Property(e => e.GoodTypeId).HasColumnName("GoodTypeID");
            entity.Property(e => e.PriceId).HasColumnName("PriceID");

            entity.HasOne(d => d.GoodType).WithMany(p => p.Goods)
                .HasForeignKey(d => d.GoodTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GoodTypeFK");

            entity.HasOne(d => d.Price).WithMany(p => p.Goods)
                .HasForeignKey(d => d.PriceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GoodPriceFK");
        });

        modelBuilder.Entity<GoodType>(entity =>
        {
            entity.HasKey(e => e.GoodTypeId).HasName("GoodType_pkey");

            entity.ToTable("GoodType");

            entity.Property(e => e.GoodTypeId)
                .ValueGeneratedNever()
                .HasColumnName("GoodTypeID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("Order_pkey");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.OrderGoodsId).HasColumnName("OrderGoodsID");
            entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_DATE");

            entity.HasOne(d => d.Client).WithMany(p => p.OrderClients)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OrderClientFK");

            entity.HasOne(d => d.Employee).WithMany(p => p.OrderEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OrderEmployeeFK");

            entity.HasOne(d => d.OrderGoods).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderGoodsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OrderGoodsFK");
        });

        modelBuilder.Entity<OrderGood>(entity =>
        {
            entity.HasKey(e => e.OrderGoodsId).HasName("OrderGoods_pkey");

            entity.Property(e => e.OrderGoodsId)
                .ValueGeneratedNever()
                .HasColumnName("OrderGoodsID");
            entity.Property(e => e.StockId).HasColumnName("StockID");

            entity.HasOne(d => d.Stock).WithMany(p => p.OrderGoods)
                .HasForeignKey(d => d.StockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OrderGoodsStockFK");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasKey(e => e.PriceId).HasName("Price_pkey");

            entity.ToTable("Price");

            entity.Property(e => e.PriceId)
                .ValueGeneratedNever()
                .HasColumnName("PriceID");
            entity.Property(e => e.DateSet).HasDefaultValueSql("CURRENT_DATE");
            entity.Property(e => e.Value).HasColumnType("money");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("Provider_pkey");

            entity.ToTable("Provider");

            entity.Property(e => e.ProviderId)
                .ValueGeneratedNever()
                .HasColumnName("ProviderID");
        });

        modelBuilder.Entity<ShipmentGood>(entity =>
        {
            entity.HasKey(e => e.ShipmentGoodId).HasName("ShipmentGood_pkey");

            entity.ToTable("ShipmentGood");

            entity.Property(e => e.ShipmentGoodId)
                .ValueGeneratedNever()
                .HasColumnName("ShipmentGoodID");
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<ShipmentGoodList>(entity =>
        {
            entity.HasKey(e => e.ShipmentGoodsId).HasName("ShipmentGoodList_pkey");

            entity.ToTable("ShipmentGoodList");

            entity.Property(e => e.ShipmentGoodsId)
                .ValueGeneratedNever()
                .HasColumnName("ShipmentGoodsID");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.ShipmentGoodId).HasColumnName("ShipmentGoodID");
            entity.Property(e => e.Time).HasDefaultValueSql("CURRENT_DATE");

            entity.HasOne(d => d.Provider).WithMany(p => p.ShipmentGoodLists)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ShipmentGoodsProvider");

            entity.HasOne(d => d.ShipmentGoods).WithOne(p => p.ShipmentGoodList)
                .HasForeignKey<ShipmentGoodList>(d => d.ShipmentGoodsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ShipmentGoodID");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.StockId).HasName("Stock_pkey");

            entity.ToTable("Stock");

            entity.Property(e => e.StockId)
                .ValueGeneratedNever()
                .HasColumnName("StockID");
            entity.Property(e => e.GoodId).HasColumnName("GoodID");
            entity.Property(e => e.ShipmentGoodsId).HasColumnName("ShipmentGoodsID");
            entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

            entity.HasOne(d => d.Good).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("StockGoodFK");

            entity.HasOne(d => d.ShipmentGoods).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ShipmentGoodsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("StockShipmentListFK");

            entity.HasOne(d => d.StockLocation).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.StockLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("StockLocationFK");
        });

        modelBuilder.Entity<StockLocation>(entity =>
        {
            entity.HasKey(e => e.StockLocationId).HasName("StockLocationID_pkey");

            entity.ToTable("StockLocation");

            entity.Property(e => e.StockLocationId)
                .ValueGeneratedNever()
                .HasColumnName("StockLocationID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("Employee_pkey");

            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.Patronymic).HasColumnType("character varying");
            entity.Property(e => e.Salt).HasMaxLength(255);
            entity.Property(e => e.Surname).HasMaxLength(255);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

            entity.HasOne(d => d.UserType).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EmployeeTypeFK");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.HasKey(e => e.EmployeeTypeId).HasName("EmployeeType_pkey");

            entity.ToTable("UserType");

            entity.Property(e => e.EmployeeTypeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeTypeID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
