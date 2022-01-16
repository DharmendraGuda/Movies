﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesAPI.DBContext;

namespace MoviesAPI.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20220115195643_MoviesToDB")]
    partial class MoviesToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesAPI.Domain.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageRating")
                        .HasColumnType("float");

                    b.Property<int>("NumberRated")
                        .HasColumnType("int");

                    b.Property<int>("RunningTime")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfRelease")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesAPI.Domain.MovieGenre", b =>
                {
                    b.Property<int>("MovieGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("MovieGenreId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("MoviesAPI.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MoviesAPI.Domain.UserMovieRating", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("UserId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("UserRatings");
                });

            modelBuilder.Entity("MoviesAPI.Domain.MovieGenre", b =>
                {
                    b.HasOne("MoviesAPI.Domain.Movie", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesAPI.Domain.UserMovieRating", b =>
                {
                    b.HasOne("MoviesAPI.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesAPI.Domain.User", null)
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviesAPI.Domain.Movie", b =>
                {
                    b.Navigation("Genres");
                });

            modelBuilder.Entity("MoviesAPI.Domain.User", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}