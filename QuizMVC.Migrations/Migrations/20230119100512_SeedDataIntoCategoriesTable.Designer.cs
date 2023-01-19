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
    [Migration("20230119100512_SeedDataIntoCategoriesTable")]
    partial class SeedDataIntoCategoriesTable
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Test your English.",
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Programming languages"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Find out how much you really know about computers.",
                            Name = "Computer science"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Put your knowledge to the test.",
                            Name = "General Knowledge"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Math quiz helps us to increase our knowledge.",
                            Name = "Math"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Music quizzes will challenge music lovers of all genres and time periods.",
                            Name = "Music"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Take this literature quiz to test your knowledge on a variety of literature topics.",
                            Name = "World Literature"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Test your knowledge of science facts and applications of scientific principles.",
                            Name = "Science"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Test your knowledge of Mythology.",
                            Name = "Mythology"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Basic world history quiz.",
                            Name = "History"
                        });
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
