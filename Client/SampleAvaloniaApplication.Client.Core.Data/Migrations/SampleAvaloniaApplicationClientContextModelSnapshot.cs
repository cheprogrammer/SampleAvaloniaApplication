﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleAvaloniaApplication.Client.Core.Data;

namespace SampleAvaloniaApplication.Client.Core.Data.Migrations
{
    [DbContext(typeof(SampleAvaloniaApplicationClientContext))]
    partial class SampleAvaloniaApplicationClientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("SampleAvaloniaApplication.Client.Core.Data.ClientEmployee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT")
                        .HasMaxLength(4096);

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1024);

                    b.Property<bool>("IsAcrhived")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRegisteredOnThePortal")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSuperUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("PrimaryPhone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("SecondaryPhone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("121dd305-fd55-4fc1-a44b-37b29a70161a"),
                            BirthDate = new DateTime(2020, 2, 24, 20, 37, 8, 736, DateTimeKind.Local).AddTicks(2855),
                            Email = "administrator@test.com",
                            FirstName = "Admin",
                            IsAcrhived = false,
                            IsRegisteredOnThePortal = false,
                            IsSuperUser = true,
                            LastName = "Admin",
                            MiddleName = "Admin",
                            Password = "administrator",
                            Sex = 0,
                            Username = "administrator"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
