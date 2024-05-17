﻿// <auto-generated />
using System;
using LspCertification.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LspCertification.Migrations
{
    [DbContext(typeof(WebDbContext))]
    partial class WebDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("LspCertification.Data.Entities.Distributor", b =>
                {
                    b.Property<Guid>("DistributorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DistributorCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("DistributorName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("DistributorId");

                    b.ToTable("Distributors");
                });

            modelBuilder.Entity("LspCertification.Data.Entities.Spectacle", b =>
                {
                    b.Property<Guid>("SpectacleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DistributorId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.Property<string>("SpectacleBrand")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("SpectacleCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("SpectacleType")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("SpectacleId");

                    b.HasIndex("DistributorId");

                    b.ToTable("Spectacles");
                });

            modelBuilder.Entity("LspCertification.Data.Entities.Spectacle", b =>
                {
                    b.HasOne("LspCertification.Data.Entities.Distributor", "Distributor")
                        .WithMany("Spectacles")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");
                });

            modelBuilder.Entity("LspCertification.Data.Entities.Distributor", b =>
                {
                    b.Navigation("Spectacles");
                });
#pragma warning restore 612, 618
        }
    }
}