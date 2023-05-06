﻿// <auto-generated />
using System;
using EventManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventManagement.Infrastructure.Migrations
{
    [DbContext(typeof(EventManagementDBContext))]
    [Migration("20230505152102_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventManagement.Domain.Entities.UserContextEntities.RoleEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 5, 5, 18, 21, 2, 373, DateTimeKind.Local).AddTicks(5133),
                            Description = "This is a role for admin users.",
                            Name = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 5, 5, 18, 21, 2, 373, DateTimeKind.Local).AddTicks(5147),
                            Description = "This is a role for standard users.",
                            Name = "Standard"
                        });
                });

            modelBuilder.Entity("EventManagement.Domain.Entities.UserContextEntities.UserEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 5, 5, 18, 21, 2, 373, DateTimeKind.Local).AddTicks(8744),
                            Email = "admin@xyz.com",
                            Name = "Admin",
                            PasswordHash = "7621e5c63ac7b718709bfc509a91e4b9368253c8b72849a8d68bfa857ae27c8800c2fc0b586dea78ac4cf1031fe15e653e2af7619800c12f4af14ec771d3f9ea",
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("EventManagement.Domain.Entities.UserContextEntities.UserRoleEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 5, 5, 18, 21, 2, 373, DateTimeKind.Local).AddTicks(6869),
                            RoleID = 1,
                            UserID = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
