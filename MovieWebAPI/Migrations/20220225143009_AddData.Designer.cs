// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieWebAPI.Models;

namespace MovieWebAPI.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20220225143009_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("MovieWebAPI.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Human",
                            FullName = "Iron Man",
                            Gender = "Male",
                            PictureUrl = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/e/e9/Iron_Man_AIW_Profile.jpg/revision/latest?cb=20180518212029"
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Human",
                            FullName = "Captain America",
                            Gender = "Male",
                            PictureUrl = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/6/66/Captain_America_AIW_Profile.jpg/revision/latest?cb=20180518211704"
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Human",
                            FullName = "Hulk",
                            Gender = "Male",
                            PictureUrl = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/c/c3/Hulk_AIW_Profile.jpg/revision/latest?cb=20180518211829"
                        },
                        new
                        {
                            Id = 4,
                            Alias = "Asgardian",
                            FullName = "Thor",
                            Gender = "Male",
                            PictureUrl = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/4/45/Thor_AIW_Profile.jpg/revision/latest?cb=20180518212120"
                        },
                        new
                        {
                            Id = 5,
                            Alias = "Human",
                            FullName = "Black Widow",
                            Gender = "Female",
                            PictureUrl = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/5/50/Black_Widow_AIW_Profile.jpg/revision/latest?cb=20180518212205"
                        },
                        new
                        {
                            Id = 6,
                            Alias = "Human",
                            FullName = "Hawkeye",
                            Gender = "Maale",
                            PictureUrl = "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/6/6f/CW_Textless_Shield_Poster_02.jpg/revision/latest?cb=20180417151836"
                        });
                });

            modelBuilder.Entity("MovieWebAPI.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Franchise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Marvel Cinematic Universe"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lord of the Rings"
                        });
                });

            modelBuilder.Entity("MovieWebAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Trailer")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2015,
                            Title = "Iron Man",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 2,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2008,
                            Title = "The Incredible Hulk",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 3,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2015,
                            Title = "Iron Man 2",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 4,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2011,
                            Title = "Thor",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 5,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2011,
                            Title = "Captain America",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 6,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2012,
                            Title = "Avengers, The",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 7,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Action",
                            PictureUrl = "",
                            ReleaseYear = 2015,
                            Title = "Iron Man 3",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 8,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2013,
                            Title = "Thor: The Dark World",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 9,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2014,
                            Title = "Captain America: The Winter Soldier",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 10,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2014,
                            Title = "Guardians of the Galaxy",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 11,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2015,
                            Title = "Avengers: Age of Ultron",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 12,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2015,
                            Title = "Ant-Man",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 13,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2016,
                            Title = "Captain America: Civil War",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 14,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2016,
                            Title = "Doctor Strange",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 15,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2017,
                            Title = "Guardians of the Galaxy Vol. 2",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 16,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2017,
                            Title = "Spider-Man: Homecoming",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 17,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2017,
                            Title = "Thor: Ragnarok",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 18,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2018,
                            Title = "Black Panther",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 19,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2018,
                            Title = "Avengers: Infinity War",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 20,
                            Director = "",
                            FranchiseId = 1,
                            Genre = "Science Fiction",
                            PictureUrl = "",
                            ReleaseYear = 2018,
                            Title = "Ant-Man and the Wasp",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 21,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2001,
                            Title = "The Fellowship of the Ring",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 22,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2003,
                            Title = "The Two Towers",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 23,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2005,
                            Title = "The Return of the King",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 24,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Fantasy",
                            PictureUrl = "",
                            ReleaseYear = 2010,
                            Title = "Hobbit",
                            Trailer = ""
                        });
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("MovieWebAPI.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieWebAPI.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieWebAPI.Models.Movie", b =>
                {
                    b.HasOne("MovieWebAPI.Models.Franchise", "Franchise")
                        .WithMany("Movies")
                        .HasForeignKey("FranchiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Franchise");
                });

            modelBuilder.Entity("MovieWebAPI.Models.Franchise", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
