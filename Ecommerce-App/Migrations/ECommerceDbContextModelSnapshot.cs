﻿// <auto-generated />
using System;
using Ecommerce_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce_App.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    partial class ECommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce_App.Auth.AuthUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Ecommerce_App.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DBCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Zoas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Polyps"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Montiporas"
                        });
                });

            modelBuilder.Entity("Ecommerce_App.Models.CategoryProducts", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("DBCategoryProducts");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 9
                        });
                });

            modelBuilder.Entity("Ecommerce_App.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DBProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Red Bull Zoanthids",
                            Price = 40m
                        },
                        new
                        {
                            Id = 2,
                            Name = "WarLock Zoanthids",
                            Price = 80m
                        },
                        new
                        {
                            Id = 3,
                            Name = "SuperStar Zoanthids",
                            Price = 180m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gold Schalagger Polyps",
                            Price = 40m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Marsian Man Polyps",
                            Price = 20m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Utter Chaos Polyps",
                            Price = 20m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sunset Montipora",
                            Price = 75m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Northern Light Montipora",
                            Price = 40m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Jason fox Brain Freeze",
                            Price = 200m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "administrator",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "editor",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "writer",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Writer",
                            NormalizedName = "WRITER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "permissions",
                            ClaimValue = "delete",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "writer"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "writer"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ecommerce_App.Models.CategoryProducts", b =>
                {
                    b.HasOne("Ecommerce_App.Models.Category", "Category")
                        .WithMany("CategoryProductsList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce_App.Models.Product", "Product")
                        .WithMany("CategoryProductList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Ecommerce_App.Auth.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ecommerce_App.Auth.AuthUser", null)
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

                    b.HasOne("Ecommerce_App.Auth.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ecommerce_App.Auth.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
