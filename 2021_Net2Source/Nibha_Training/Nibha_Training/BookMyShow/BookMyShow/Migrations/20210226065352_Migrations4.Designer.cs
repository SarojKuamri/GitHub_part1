﻿// <auto-generated />
using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMyShow.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20210226065352_Migrations4")]
    partial class Migrations4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookMyShow.Models.LocationModel", b =>
                {
                    b.Property<int>("LocqationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocqationId");

                    b.ToTable("locationModels");
                });

            modelBuilder.Entity("BookMyShow.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MoviePrice")
                        .HasColumnType("int");

                    b.Property<string>("MovieType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("MovieModels");
                });

            modelBuilder.Entity("BookMyShow.Models.RatingModel", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("MovieRatings")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("MovieId");

                    b.ToTable("RatingModels");
                });

            modelBuilder.Entity("BookMyShow.Models.TheaterModel", b =>
                {
                    b.Property<int>("TheaterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ThreaterLoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreaterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TheaterId");

                    b.ToTable("TheaterModels");
                });

            modelBuilder.Entity("BookMyShow.Models.RatingModel", b =>
                {
                    b.HasOne("BookMyShow.Models.MovieModel", "MovieModel")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
