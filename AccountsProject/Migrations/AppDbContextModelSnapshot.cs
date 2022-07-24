﻿// <auto-generated />
using System;
using AccountsProject.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccountsProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AccountsProject.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PONumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PONumber"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedUserID")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ForeignID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PODate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SearchString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<decimal>("TotalGross")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("TotalNet")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("TotalVat")
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("Void")
                        .HasColumnType("bit");

                    b.HasKey("PONumber");

                    b.HasIndex("SupplierID");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("AccountsProject.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierID"), 1L, 1);

                    b.Property<string>("AccountRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatReg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Void")
                        .HasColumnType("bit");

                    b.HasKey("SupplierID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("AccountsProject.Models.PurchaseOrder", b =>
                {
                    b.HasOne("AccountsProject.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
