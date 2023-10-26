﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationAPI.Data;

namespace RegistrationAPI.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("BookAPI.Models.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookAPI.Models.BookGenre", b =>
                {
                    b.Property<Guid>("BookGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookGenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            BookGenreId = new Guid("de9cd5f5-8f93-4504-aa25-f0641864be8d"),
                            Genre = "Fiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("eaf4e809-7fad-436c-ba60-fdd0a1734806"),
                            Genre = "Mystery & Thriller"
                        },
                        new
                        {
                            BookGenreId = new Guid("a4e5a562-72a4-4b9e-bc5e-c8994a759970"),
                            Genre = "Nonfiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("f34210d1-af73-42e8-8b35-287f154c9252"),
                            Genre = "Science & Technology"
                        },
                        new
                        {
                            BookGenreId = new Guid("eeb07f13-38f8-4de1-b943-65d77efac5e9"),
                            Genre = "Historical Fiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("ad5e03fe-691a-4acc-a4da-476048ffa3fa"),
                            Genre = "Science & Technology"
                        },
                        new
                        {
                            BookGenreId = new Guid("6fda8bb9-7a34-40b4-a836-cb0291ac3e21"),
                            Genre = "Fantasy"
                        },
                        new
                        {
                            BookGenreId = new Guid("b7cf09f6-b658-4f1f-ba36-7ee0219cf9a1"),
                            Genre = "Romance"
                        },
                        new
                        {
                            BookGenreId = new Guid("c7480849-9cc8-4fbd-bea1-fc61e2238672"),
                            Genre = "Horror"
                        });
                });

            modelBuilder.Entity("RegistrationAPI.Models.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("cd033916-a65b-4354-8bc8-1e2c35106d33"),
                            Age = 65,
                            Country = "Unites States",
                            Name = "Bill Gates"
                        },
                        new
                        {
                            AuthorId = new Guid("516d8b7e-f4be-4820-a7fa-7116bb47d427"),
                            Age = 48,
                            Country = "United Kingdom",
                            Name = "Matthew Walker"
                        },
                        new
                        {
                            AuthorId = new Guid("1afc6632-7d0b-4217-9d73-72f88e928e96"),
                            Age = 51,
                            Country = "Unites States",
                            Name = "Hope Jahren"
                        },
                        new
                        {
                            AuthorId = new Guid("7cd56e95-ab42-4684-9c98-1ecb5ab675b6"),
                            Age = 45,
                            Country = "United Kingdom",
                            Name = "Matt Haig"
                        },
                        new
                        {
                            AuthorId = new Guid("fcc53275-4d46-41c9-b19f-5d7574213beb"),
                            Age = 35,
                            Country = "United Kingdom",
                            Name = "Lucy Foley"
                        });
                });

            modelBuilder.Entity("BookAPI.Models.Book", b =>
                {
                    b.HasOne("RegistrationAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
