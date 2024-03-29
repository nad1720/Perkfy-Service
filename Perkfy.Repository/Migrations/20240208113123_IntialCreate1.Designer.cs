﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perkfy.Repository;

#nullable disable

namespace Perkfy.Repository.Migrations
{
    [DbContext(typeof(PerkfyContext))]
    [Migration("20240208113123_IntialCreate1")]
    partial class IntialCreate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e4affa76-a4df-4677-8e82-ef3758ffc8dd",
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "ea77f861-f8d1-44bf-8dfc-2cf0b4df900d",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERaDMIN"
                        },
                        new
                        {
                            Id = "da6e5e19-af95-454d-963a-6fe24eb272dc",
                            Name = "ClientAdmin",
                            NormalizedName = "CLIENTADMIN"
                        },
                        new
                        {
                            Id = "144299b5-8671-480c-bf0a-45cae8f7ea3d",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        },
                        new
                        {
                            Id = "168b3b8f-dc4e-4e50-afbf-40b171fb8f79",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2c31cf46-40c7-4d90-8a22-11c7dbd180cd",
                            Name = "Casheir",
                            NormalizedName = "CASHEIR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Logo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("NumberOfUsers")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RenewDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Perkfy.Data.Models.PointSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("GainMoney")
                        .HasColumnType("money");

                    b.Property<int?>("GainPoints")
                        .HasColumnType("int");

                    b.Property<decimal?>("RedeemMoney")
                        .HasColumnType("money");

                    b.Property<int?>("RedeemPoints")
                        .HasColumnType("int");

                    b.Property<int?>("SettingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.ToTable("PointSetting", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.PunchCardSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuyerCupType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("NumberOfBuyedCup")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfRewardCup")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("RewardCupType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SettingId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SettingId");

                    b.ToTable("PunchCardSettings");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Qoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime");

                    b.Property<string>("QouteContent")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Qoute", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.RewardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("PointsCount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SettingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SettingId");

                    b.ToTable("RewardItem", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.RewardItemGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("RewardItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RewardItemId");

                    b.ToTable("RewardItemGallery", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Setting", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgroundColor")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("backgroundColor");

                    b.Property<string>("FontFamily")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MainColor")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SecoundColor")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("secoundColor");

                    b.HasKey("Id");

                    b.ToTable("Theme", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CashierId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("PointsCount")
                        .HasColumnType("int");

                    b.Property<int?>("SettingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TransactionTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LoginCount")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Perkfy.Data.Models.UserBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Balance")
                        .HasColumnType("int");

                    b.Property<int?>("SettingId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("UserBalance", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Perkfy.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Perkfy.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Perkfy.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Perkfy.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Perkfy.Data.Models.Brand", b =>
                {
                    b.HasOne("Perkfy.Data.Models.Theme", "Theme")
                        .WithMany("Brands")
                        .HasForeignKey("ThemeId")
                        .HasConstraintName("FK_Brands_Theme");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("Perkfy.Data.Models.PointSetting", b =>
                {
                    b.HasOne("Perkfy.Data.Models.Setting", "Setting")
                        .WithMany("PointSettings")
                        .HasForeignKey("SettingId")
                        .HasConstraintName("FK_PointSetting_PointSetting");

                    b.Navigation("Setting");
                });

            modelBuilder.Entity("Perkfy.Data.Models.PunchCardSetting", b =>
                {
                    b.HasOne("Perkfy.Data.Models.Product", "Product")
                        .WithMany("PunchCardSettings")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_PunchCardSettings_Product");

                    b.HasOne("Perkfy.Data.Models.Setting", "Setting")
                        .WithMany("PunchCardSettings")
                        .HasForeignKey("SettingId")
                        .HasConstraintName("FK_PunchCardSettings_Setting");

                    b.Navigation("Product");

                    b.Navigation("Setting");
                });

            modelBuilder.Entity("Perkfy.Data.Models.RewardItem", b =>
                {
                    b.HasOne("Perkfy.Data.Models.Product", "Product")
                        .WithMany("RewardItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_RewardItem_Product");

                    b.HasOne("Perkfy.Data.Models.Setting", "Setting")
                        .WithMany("RewardItems")
                        .HasForeignKey("SettingId")
                        .HasConstraintName("FK_RewardItem_Setting");

                    b.Navigation("Product");

                    b.Navigation("Setting");
                });

            modelBuilder.Entity("Perkfy.Data.Models.RewardItemGallery", b =>
                {
                    b.HasOne("Perkfy.Data.Models.RewardItem", "RewardItem")
                        .WithMany("RewardItemGalleries")
                        .HasForeignKey("RewardItemId")
                        .HasConstraintName("FK_RewardItemGallery_RewardItem");

                    b.Navigation("RewardItem");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Setting", b =>
                {
                    b.HasOne("Perkfy.Data.Models.Brand", "Brand")
                        .WithMany("Settings")
                        .HasForeignKey("BrandId")
                        .HasConstraintName("FK_Setting_Brands");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Transaction", b =>
                {
                    b.HasOne("Perkfy.Data.Models.Setting", "Setting")
                        .WithMany("Transactions")
                        .HasForeignKey("SettingId")
                        .HasConstraintName("FK_Transaction_Setting");

                    b.Navigation("Setting");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Brand", b =>
                {
                    b.Navigation("Settings");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Product", b =>
                {
                    b.Navigation("PunchCardSettings");

                    b.Navigation("RewardItems");
                });

            modelBuilder.Entity("Perkfy.Data.Models.RewardItem", b =>
                {
                    b.Navigation("RewardItemGalleries");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Setting", b =>
                {
                    b.Navigation("PointSettings");

                    b.Navigation("PunchCardSettings");

                    b.Navigation("RewardItems");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Perkfy.Data.Models.Theme", b =>
                {
                    b.Navigation("Brands");
                });
#pragma warning restore 612, 618
        }
    }
}
