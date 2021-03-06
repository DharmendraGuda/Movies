// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesAPI.DBContext;

namespace MoviesAPI.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20220116075228_SeedInitialData")]
    partial class SeedInitialData
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

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            AverageRating = 3.6680000000000001,
                            NumberRated = 5,
                            RunningTime = 120,
                            Title = "Promising Young Woman",
                            YearOfRelease = 2021
                        },
                        new
                        {
                            MovieId = 2,
                            AverageRating = 4.6600000000000001,
                            NumberRated = 10,
                            RunningTime = 120,
                            Title = "A Quiet Place Part II",
                            YearOfRelease = 2000
                        },
                        new
                        {
                            MovieId = 3,
                            AverageRating = 3.6600000000000001,
                            NumberRated = 25,
                            RunningTime = 120,
                            Title = "Tenet",
                            YearOfRelease = 2021
                        },
                        new
                        {
                            MovieId = 4,
                            AverageRating = 3.9900000000000002,
                            NumberRated = 15,
                            RunningTime = 120,
                            Title = "Another Round",
                            YearOfRelease = 2021
                        },
                        new
                        {
                            MovieId = 5,
                            AverageRating = 4.9800000000000004,
                            NumberRated = 52,
                            RunningTime = 120,
                            Title = "Toy Story",
                            YearOfRelease = 2021
                        },
                        new
                        {
                            MovieId = 6,
                            AverageRating = 4.6600000000000001,
                            NumberRated = 54,
                            RunningTime = 120,
                            Title = "Late Spring",
                            YearOfRelease = 2021
                        },
                        new
                        {
                            MovieId = 7,
                            AverageRating = 3.1600000000000001,
                            NumberRated = 55,
                            RunningTime = 120,
                            Title = "Tokyo Story",
                            YearOfRelease = 1945
                        },
                        new
                        {
                            MovieId = 8,
                            AverageRating = 2.23,
                            NumberRated = 65,
                            RunningTime = 120,
                            Title = "Mad Money",
                            YearOfRelease = 2020
                        },
                        new
                        {
                            MovieId = 9,
                            AverageRating = 1.45,
                            NumberRated = 75,
                            RunningTime = 120,
                            Title = "Bad Dreams",
                            YearOfRelease = 2021
                        },
                        new
                        {
                            MovieId = 10,
                            AverageRating = 2.6600000000000001,
                            NumberRated = 85,
                            RunningTime = 120,
                            Title = "Dreams",
                            YearOfRelease = 2021
                        });
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

                    b.HasData(
                        new
                        {
                            MovieGenreId = 1,
                            GenreType = "Crime",
                            MovieId = 1
                        },
                        new
                        {
                            MovieGenreId = 2,
                            GenreType = "Comedy",
                            MovieId = 1
                        },
                        new
                        {
                            MovieGenreId = 3,
                            GenreType = "Comedy",
                            MovieId = 2
                        },
                        new
                        {
                            MovieGenreId = 4,
                            GenreType = "Drama",
                            MovieId = 2
                        },
                        new
                        {
                            MovieGenreId = 5,
                            GenreType = "Drama",
                            MovieId = 3
                        },
                        new
                        {
                            MovieGenreId = 6,
                            GenreType = "Crime",
                            MovieId = 4
                        },
                        new
                        {
                            MovieGenreId = 7,
                            GenreType = "Sci-Fi",
                            MovieId = 4
                        },
                        new
                        {
                            MovieGenreId = 8,
                            GenreType = "Thriller",
                            MovieId = 5
                        },
                        new
                        {
                            MovieGenreId = 9,
                            GenreType = "Crime",
                            MovieId = 6
                        },
                        new
                        {
                            MovieGenreId = 10,
                            GenreType = "Crime",
                            MovieId = 8
                        },
                        new
                        {
                            MovieGenreId = 11,
                            GenreType = "Horror",
                            MovieId = 9
                        },
                        new
                        {
                            MovieGenreId = 12,
                            GenreType = "Crime",
                            MovieId = 10
                        },
                        new
                        {
                            MovieGenreId = 13,
                            GenreType = "Comedy",
                            MovieId = 10
                        },
                        new
                        {
                            MovieGenreId = 14,
                            GenreType = "Drama",
                            MovieId = 10
                        },
                        new
                        {
                            MovieGenreId = 15,
                            GenreType = "Horror",
                            MovieId = 7
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "Mathew"
                        },
                        new
                        {
                            UserId = 2,
                            Name = "Dan"
                        },
                        new
                        {
                            UserId = 3,
                            Name = "Mary "
                        },
                        new
                        {
                            UserId = 4,
                            Name = "Tony"
                        },
                        new
                        {
                            UserId = 5,
                            Name = "Lisa"
                        },
                        new
                        {
                            UserId = 6,
                            Name = "Nicole"
                        },
                        new
                        {
                            UserId = 7,
                            Name = "Karen"
                        },
                        new
                        {
                            UserId = 8,
                            Name = "Mike"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            MovieId = 1,
                            Rating = 4.5
                        },
                        new
                        {
                            UserId = 1,
                            MovieId = 2,
                            Rating = 3.0
                        },
                        new
                        {
                            UserId = 1,
                            MovieId = 3,
                            Rating = 5.0
                        },
                        new
                        {
                            UserId = 1,
                            MovieId = 4,
                            Rating = 3.5
                        },
                        new
                        {
                            UserId = 1,
                            MovieId = 5,
                            Rating = 2.5
                        },
                        new
                        {
                            UserId = 1,
                            MovieId = 6,
                            Rating = 1.5
                        },
                        new
                        {
                            UserId = 2,
                            MovieId = 1,
                            Rating = 4.5
                        },
                        new
                        {
                            UserId = 2,
                            MovieId = 4,
                            Rating = 3.5
                        },
                        new
                        {
                            UserId = 3,
                            MovieId = 5,
                            Rating = 5.0
                        },
                        new
                        {
                            UserId = 3,
                            MovieId = 8,
                            Rating = 5.0
                        },
                        new
                        {
                            UserId = 4,
                            MovieId = 6,
                            Rating = 5.0
                        },
                        new
                        {
                            UserId = 5,
                            MovieId = 7,
                            Rating = 5.0
                        },
                        new
                        {
                            UserId = 6,
                            MovieId = 8,
                            Rating = 5.0
                        },
                        new
                        {
                            UserId = 7,
                            MovieId = 9,
                            Rating = 5.0
                        });
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
