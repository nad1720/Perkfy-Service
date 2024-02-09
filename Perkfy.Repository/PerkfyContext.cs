using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Perkfy.Data.Models;
namespace Perkfy.Repository;

public partial class PerkfyContext : IdentityDbContext<User, IdentityRole, string>
{
    public PerkfyContext() { }

    public PerkfyContext(DbContextOptions<PerkfyContext> options) : base(options) { }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<PointSetting> PointSettings { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<PunchCardSetting> PunchCardSettings { get; set; }

    public virtual DbSet<Qoute> Qoutes { get; set; }

    public virtual DbSet<RewardItem> RewardItems { get; set; }

    public virtual DbSet<RewardItemGallery> RewardItemGalleries { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    //public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserBalance> UserBalances { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    //    => optionsBuilder.UseSqlServer("Data Source=LinkTSP13;Initial Catalog=Perkfy;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(
           new IdentityRole { Name = "Owner", NormalizedName = "OWNER" },
           new IdentityRole { Name = "SuperAdmin", NormalizedName = "SUPERaDMIN" },
           new IdentityRole { Name = "ClientAdmin", NormalizedName = "CLIENTADMIN" },
           new IdentityRole { Name = "Member", NormalizedName = "MEMBER" },
           new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
           new IdentityRole { Name = "Casheir", NormalizedName = "CASHEIR" }
       );

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.Property(e => e.Logo).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.RenewDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Theme).WithMany(p => p.Brands)
                .HasForeignKey(d => d.ThemeId)
                .HasConstraintName("FK_Brands_Theme");
        });

        modelBuilder.Entity<PointSetting>(entity =>
        {
            entity.ToTable("PointSetting");

            entity.Property(e => e.GainMoney).HasColumnType("money");
            entity.Property(e => e.RedeemMoney).HasColumnType("money");

            entity.HasOne(d => d.Setting).WithMany(p => p.PointSettings)
                .HasForeignKey(d => d.SettingId)
                .HasConstraintName("FK_PointSetting_PointSetting");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PunchCardSetting>(entity =>
        {
            entity.Property(e => e.BuyerCupType).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.RewardCupType).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Product).WithMany(p => p.PunchCardSettings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_PunchCardSettings_Product");

            entity.HasOne(d => d.Setting).WithMany(p => p.PunchCardSettings)
                .HasForeignKey(d => d.SettingId)
                .HasConstraintName("FK_PunchCardSettings_Setting");
        });

        modelBuilder.Entity<Qoute>(entity =>
        {
            entity.ToTable("Qoute");

            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.QouteContent).HasMaxLength(500);
        });

        modelBuilder.Entity<RewardItem>(entity =>
        {
            entity.ToTable("RewardItem");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.RewardItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_RewardItem_Product");

            entity.HasOne(d => d.Setting).WithMany(p => p.RewardItems)
                .HasForeignKey(d => d.SettingId)
                .HasConstraintName("FK_RewardItem_Setting");
        });

        modelBuilder.Entity<RewardItemGallery>(entity =>
        {
            entity.ToTable("RewardItemGallery");

            entity.Property(e => e.ImageUrl).HasMaxLength(500);

            entity.HasOne(d => d.RewardItem).WithMany(p => p.RewardItemGalleries)
                .HasForeignKey(d => d.RewardItemId)
                .HasConstraintName("FK_RewardItemGallery_RewardItem");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting");

            entity.HasOne(d => d.Brand).WithMany(p => p.Settings)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Setting_Brands");
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.ToTable("Theme");

            entity.Property(e => e.BackgroundColor)
                .HasMaxLength(200)
                .HasColumnName("backgroundColor");
            entity.Property(e => e.FontFamily).HasMaxLength(200);
            entity.Property(e => e.MainColor).HasMaxLength(200);
            entity.Property(e => e.SecoundColor)
                .HasMaxLength(200)
                .HasColumnName("secoundColor");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transaction");

            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.TransactionTime).HasColumnType("datetime");

            entity.HasOne(d => d.Setting).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.SettingId)
                .HasConstraintName("FK_Transaction_Setting");
        });

        //modelBuilder.Entity<User>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("User");

        //    entity.Property(e => e.Birthday).HasColumnType("datetime");
        //    entity.Property(e => e.FirstName).HasMaxLength(50);
        //    entity.Property(e => e.Gender).ValueGeneratedOnAdd();
        //    entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
        //    entity.Property(e => e.LastName).HasMaxLength(50);
        //    entity.Property(e => e.ProfileImageUrl).HasMaxLength(500);
        //});

        modelBuilder.Entity<UserBalance>(entity =>
        {
            entity.ToTable("UserBalance");

            entity.Property(e => e.UserId).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
