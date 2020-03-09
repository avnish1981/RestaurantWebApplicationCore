﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantApp.data;

namespace RestaurantApp.data.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    partial class RestaurantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantApp.core.Restaurant", b =>
                {
                    b.Property<int>("resId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuisinType");

                    b.Property<string>("resLocation")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("resName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("resId");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
