﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QuizMVC.Data;

#nullable disable

namespace QuizMVC.Migrations.Migrations
{
    [DbContext(typeof(QuizMvcDbContext))]
    [Migration("20230119120344_SeedDataIntoQuestionChoicesTable")]
    partial class SeedDataIntoQuestionChoicesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("QuizMVC.Models.Main.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.QuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("RightAnswer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.QuestionChoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("QuestionChoices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Choice = "Hanover, Germany",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 2,
                            Choice = "Munich, Germany",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Choice = "Salzburg, Austria",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Choice = "Copenhagen, Denmark",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Choice = "1966",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 6,
                            Choice = "1961",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 7,
                            Choice = "1971",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 8,
                            Choice = "1976",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 9,
                            Choice = "night",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Choice = "site",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            Choice = "light",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            Choice = "daylight",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            Choice = "Paul McCartney",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            Choice = "Brian Wilson",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            Choice = "Robert Plant",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            Choice = "Freddie Mercury",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 17,
                            Choice = "",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 18,
                            Choice = "Simone Simons",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 19,
                            Choice = "Floor Jansen",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 20,
                            Choice = "Tarja Turunen",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 21,
                            Choice = "Amy Lee",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 22,
                            Choice = "Eagle",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 23,
                            Choice = "Scorpion",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 24,
                            Choice = "Dragon",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 25,
                            Choice = "Snake",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 26,
                            Choice = "Dog",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 27,
                            Choice = "Cat",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 28,
                            Choice = "Frog",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 29,
                            Choice = "",
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 30,
                            Choice = "Slash",
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 31,
                            Choice = "Muddy",
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 32,
                            Choice = "Diamond",
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 33,
                            Choice = "La leyenda de La Mancha",
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 34,
                            Choice = "A king of magic",
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 35,
                            Choice = "Abbey Road",
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 36,
                            Choice = "The Dark Side of the Moon",
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 37,
                            Choice = "Shiva",
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 38,
                            Choice = "Minerva",
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 39,
                            Choice = "Athena",
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 40,
                            Choice = "Kali",
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 41,
                            Choice = "",
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 42,
                            Choice = "The Skeleton Key",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 43,
                            Choice = "Delicate Sound of Thunder",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 44,
                            Choice = "Real Rock Drive",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 45,
                            Choice = "We'll burn the sky",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 46,
                            Choice = "Rock Around the Clock",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 47,
                            Choice = "I Don’t Want to Miss a Thing",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 48,
                            Choice = "The Battle of Evermore",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 49,
                            Choice = "Dream On",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 50,
                            Choice = "I Don't Want to Miss a Thing",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 51,
                            Choice = "Hole in my Soul",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 52,
                            Choice = "Wish I had an angel",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 53,
                            Choice = "The Phantom Agony",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 54,
                            Choice = "Livin' On The Edge",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 55,
                            Choice = "Toys in the Attic",
                            QuestionId = 14
                        });
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Completed")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("FinalScore")
                        .HasColumnType("real");

                    b.Property<DateTime>("Started")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<string>>("UserAnswers")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}