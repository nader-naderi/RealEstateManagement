﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateManagement.Data;

#nullable disable

namespace RealEstateManagement.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240307061903_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Lease", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<decimal>("MonthlyRent")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("MonthlyRent");

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("TenantId");

                    b.ToTable("Leases");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Offer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<DateTime>("OfferDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("OfferDate");

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("TenantId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Property", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("AgentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBathrooms")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBedrooms")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("SquareFeet")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Properties");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMRole", b =>
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
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMRoleClaim", b =>
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

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserClaim", b =>
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

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserLogin", b =>
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

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserToken", b =>
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

            modelBuilder.Entity("RealEstateManagement.Models.Entities.CommercialProperty", b =>
                {
                    b.HasBaseType("RealEstateManagement.Models.Entities.Property");

                    b.Property<string>("OfficeSpaceSquareFeet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CommercialProperties");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.LandProperty", b =>
                {
                    b.HasBaseType("RealEstateManagement.Models.Entities.Property");

                    b.Property<string>("LotSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("LandProperties");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.ResidentialProperty", b =>
                {
                    b.HasBaseType("RealEstateManagement.Models.Entities.Property");

                    b.Property<int>("NumberOfFloors")
                        .HasColumnType("int");

                    b.Property<int>("ResidentialType")
                        .HasColumnType("int");

                    b.ToTable("ResidentialProperties");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Agent", b =>
                {
                    b.HasBaseType("RealEstateManagement.Models.Entities.REMUser");

                    b.Property<string>("AgencyAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("AgencyCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AgencyCountry")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AgencyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AgencyState")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AgencyZipCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Owner", b =>
                {
                    b.HasBaseType("RealEstateManagement.Models.Entities.REMUser");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Tenant", b =>
                {
                    b.HasBaseType("RealEstateManagement.Models.Entities.REMUser");

                    b.Property<DateTime>("MoveInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MoveOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PropertyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("PropertyId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Lease", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.Property", null)
                        .WithMany("Leases")
                        .HasForeignKey("PropertyId");

                    b.HasOne("RealEstateManagement.Models.Entities.Tenant", null)
                        .WithMany("Leases")
                        .HasForeignKey("TenantId");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Offer", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.Property", null)
                        .WithMany("Offers")
                        .HasForeignKey("PropertyId");

                    b.HasOne("RealEstateManagement.Models.Entities.Tenant", null)
                        .WithMany("Offers")
                        .HasForeignKey("TenantId");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Property", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.Agent", null)
                        .WithMany("Properties")
                        .HasForeignKey("AgentId");

                    b.HasOne("RealEstateManagement.Models.Entities.Owner", null)
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMRoleClaim", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserClaim", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserLogin", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserRole", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", "User")
                        .WithMany("Role")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUserToken", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.CommercialProperty", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.Property", null)
                        .WithOne()
                        .HasForeignKey("RealEstateManagement.Models.Entities.CommercialProperty", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.LandProperty", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.Property", null)
                        .WithOne()
                        .HasForeignKey("RealEstateManagement.Models.Entities.LandProperty", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.ResidentialProperty", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.Property", null)
                        .WithOne()
                        .HasForeignKey("RealEstateManagement.Models.Entities.ResidentialProperty", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Agent", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", null)
                        .WithOne()
                        .HasForeignKey("RealEstateManagement.Models.Entities.Agent", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Owner", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", null)
                        .WithOne()
                        .HasForeignKey("RealEstateManagement.Models.Entities.Owner", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Tenant", b =>
                {
                    b.HasOne("RealEstateManagement.Models.Entities.REMUser", null)
                        .WithOne()
                        .HasForeignKey("RealEstateManagement.Models.Entities.Tenant", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateManagement.Models.Entities.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Property", b =>
                {
                    b.Navigation("Leases");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.REMUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Role");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Agent", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Owner", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RealEstateManagement.Models.Entities.Tenant", b =>
                {
                    b.Navigation("Leases");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
