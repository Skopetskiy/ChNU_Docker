﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationsDbContext))]
    partial class ApplicationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Core.Model.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int?>("IconId");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IconId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.Core.Model.Control", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Token");

                    b.HasKey("Id");

                    b.ToTable("Controls");
                });

            modelBuilder.Entity("Domain.Core.Model.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId");

                    b.Property<int?>("IconId");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("IconId");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("Domain.Core.Model.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("BoolValue");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<double?>("DoubleValue");

                    b.Property<int?>("IntValue");

                    b.Property<int>("SensorId");

                    b.Property<string>("StringValue");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("Domain.Core.Model.Icon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("Icons");
                });

            modelBuilder.Entity("Domain.Core.Model.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId");

                    b.Property<int>("HistoryId");

                    b.Property<bool>("IsRead");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("HistoryId")
                        .IsUnique();

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Core.Model.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("NotificationType")
                        .IsRequired();

                    b.Property<string>("Rule")
                        .IsRequired();

                    b.Property<int>("SensorId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Domain.Core.Model.ReportElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DashboardId");

                    b.Property<int>("Height");

                    b.Property<int>("Hours");

                    b.Property<bool>("IsLocked");

                    b.Property<int?>("SensorId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("Width");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.HasIndex("SensorId");

                    b.ToTable("ReportElements");
                });

            modelBuilder.Entity("Domain.Core.Model.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppUserId");

                    b.Property<string>("Comment");

                    b.Property<DateTimeOffset?>("CreatedOn");

                    b.Property<int?>("IconId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsValid");

                    b.Property<string>("Name");

                    b.Property<int?>("SensorTypeId");

                    b.Property<Guid>("Token");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("IconId");

                    b.HasIndex("SensorTypeId");

                    b.ToTable("Sensors");
                });

            modelBuilder.Entity("Domain.Core.Model.SensorControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ControlId");

                    b.Property<int?>("IconId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int?>("SensorId");

                    b.Property<int?>("maxValue");

                    b.Property<int?>("minValue");

                    b.HasKey("Id");

                    b.HasIndex("ControlId");

                    b.HasIndex("IconId");

                    b.HasIndex("SensorId");

                    b.ToTable("SensorControls");
                });

            modelBuilder.Entity("Domain.Core.Model.SensorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int?>("IconId");

                    b.Property<bool>("IsControl");

                    b.Property<string>("MeasurementName");

                    b.Property<string>("MeasurementType")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("IconId");

                    b.ToTable("SensorTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Core.Model.AppUser", b =>
                {
                    b.HasOne("Domain.Core.Model.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("Domain.Core.Model.Dashboard", b =>
                {
                    b.HasOne("Domain.Core.Model.AppUser", "AppUser")
                        .WithMany("Dashboards")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Domain.Core.Model.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("Domain.Core.Model.History", b =>
                {
                    b.HasOne("Domain.Core.Model.Sensor", "Sensor")
                        .WithMany("Histories")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Model.Message", b =>
                {
                    b.HasOne("Domain.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("Domain.Core.Model.History", "History")
                        .WithOne("Message")
                        .HasForeignKey("Domain.Core.Model.Message", "HistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Model.Notification", b =>
                {
                    b.HasOne("Domain.Core.Model.Sensor", "Sensor")
                        .WithMany("Notifications")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Model.ReportElement", b =>
                {
                    b.HasOne("Domain.Core.Model.Dashboard", "Dashboard")
                        .WithMany("ReportElements")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.Model.Sensor", "Sensor")
                        .WithMany("ReportElements")
                        .HasForeignKey("SensorId");
                });

            modelBuilder.Entity("Domain.Core.Model.Sensor", b =>
                {
                    b.HasOne("Domain.Core.Model.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("Domain.Core.Model.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");

                    b.HasOne("Domain.Core.Model.SensorType", "SensorType")
                        .WithMany("Sensor")
                        .HasForeignKey("SensorTypeId");
                });

            modelBuilder.Entity("Domain.Core.Model.SensorControl", b =>
                {
                    b.HasOne("Domain.Core.Model.Control", "Control")
                        .WithMany("SensorControls")
                        .HasForeignKey("ControlId");

                    b.HasOne("Domain.Core.Model.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");

                    b.HasOne("Domain.Core.Model.Sensor", "Sensor")
                        .WithMany("SensorControls")
                        .HasForeignKey("SensorId");
                });

            modelBuilder.Entity("Domain.Core.Model.SensorType", b =>
                {
                    b.HasOne("Domain.Core.Model.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
