﻿// <auto-generated />
using System;
using GlobalTickets.Services.Discount.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlobalTickets.Services.Discount.Migrations
{
    [DbContext(typeof(DiscountDbContext))]
    partial class DiscountDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GlobalTickets.Services.Discount.Entities.Coupon", b =>
                {
                    b.Property<Guid>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AlreadyUsed")
                        .HasColumnType("bit");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = new Guid("3416eeca-e569-44fe-a06e-b0eb0d70a855"),
                            AlreadyUsed = false,
                            Amount = 10,
                            Code = "BeNice"
                        },
                        new
                        {
                            CouponId = new Guid("819200b3-f05b-4416-a846-534228c26195"),
                            AlreadyUsed = false,
                            Amount = 20,
                            Code = "Awesome"
                        },
                        new
                        {
                            CouponId = new Guid("aed65b30-071f-4058-b42b-6ac0955ca3b9"),
                            AlreadyUsed = false,
                            Amount = 100,
                            Code = "AlmostFree"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
