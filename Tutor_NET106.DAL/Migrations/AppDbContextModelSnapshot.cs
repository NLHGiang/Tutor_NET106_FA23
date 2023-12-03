﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tutor_NET106.DAL.ApplicationDbContext;

#nullable disable

namespace Tutor_NET106.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tutor_NET106.DAL.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"),
                            Name = "Cate 1"
                        });
                });

            modelBuilder.Entity("Tutor_NET106.DAL.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8aae76a7-7065-4a90-b376-6707f9228b6d"),
                            Amount = 100,
                            CategoryId = new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"),
                            Price = 1000.5f,
                            ProductName = "Pro 1"
                        },
                        new
                        {
                            Id = new Guid("2065e0f4-c270-41ff-a707-ddd12d98756b"),
                            Amount = 200,
                            CategoryId = new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"),
                            Price = 2000.5f,
                            ProductName = "Pro 2"
                        });
                });

            modelBuilder.Entity("Tutor_NET106.DAL.Models.Product", b =>
                {
                    b.HasOne("Tutor_NET106.DAL.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Tutor_NET106.DAL.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
