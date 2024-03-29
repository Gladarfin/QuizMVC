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
    [Migration("20230124162309_SomeChangesInModels")]
    partial class SomeChangesInModels
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
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Surname")
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

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            IsActive = true,
                            QuestionText = "Which of the following statements is incorrect about encapsulation?",
                            QuestionTypeId = 2,
                            Updated = new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Local).AddTicks(693)
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 10,
                            IsActive = true,
                            QuestionText = "Place the historical events in chronological order.",
                            QuestionTypeId = 5,
                            Updated = new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Local).AddTicks(707)
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            IsActive = true,
                            QuestionText = "Just like human beings, computers communicate through receiving and sending messages. We refer to those message receiving components as _____ devices and those which send messages as _____ devices.",
                            QuestionTypeId = 6,
                            Updated = new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Local).AddTicks(709)
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 8,
                            IsActive = true,
                            QuestionText = "A scientist is conducting a study to determine how well a new medication treats ear infections. The scientist tells the participants to put 10 drops in their infected ear each day. After two weeks, all participants' ear infections had healed. Which of the following changes to the design of this study would most improve the ability to test if the new medication effectively treats ear infections?",
                            QuestionTypeId = 7,
                            Updated = new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Local).AddTicks(710)
                        });
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

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionAnswers");

                    b.HasData(
                        new
                        {
                            Id = 15,
                            QuestionId = 15,
                            RightAnswer = "56"
                        },
                        new
                        {
                            Id = 16,
                            QuestionId = 16,
                            RightAnswer = "68636164656762706669"
                        },
                        new
                        {
                            Id = 17,
                            QuestionId = 17,
                            RightAnswer = "inputoutput"
                        },
                        new
                        {
                            Id = 18,
                            QuestionId = 18,
                            RightAnswer = "74"
                        });
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

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionChoices");

                    b.HasData(
                        new
                        {
                            Id = 56,
                            Choice = "Encapsulation is the way to add functions in a user defined structure.",
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 57,
                            Choice = "Encapsulation is defined as the process of enclosing one or more items within a physical or logical package.",
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 58,
                            Choice = "Abstraction allows making relevant information visible and encapsulation enables a programmer to implement the desired level of abstraction.",
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 59,
                            Choice = "Encapsulation, in object oriented programming methodology, prevents access to implementation details.",
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 60,
                            Choice = "All of above",
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 61,
                            Choice = "Last great Roman–Persian War.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 62,
                            Choice = "War of the Grand Alliance with France; also called \"Nine Years \" or \"War of the League of Augsburg\" or \"King William's War\"",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 63,
                            Choice = "Sui dynasty in China.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 64,
                            Choice = "Christianization of Kievan Rus'",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 65,
                            Choice = "The Bible is translated into English by John Wycliffe.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 66,
                            Choice = "Alexander III dies. His son Nicholas II succeeds him as emperor.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 67,
                            Choice = "Vasco da Gama begins his first voyage from Europe to India and back.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 68,
                            Choice = "War of Pacification in Nanzhong.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 69,
                            Choice = "Theodore Roosevelt becomes the 26th President of the United States.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 70,
                            Choice = "Otto von Bismarck was born.",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 71,
                            Choice = "",
                            QuestionId = 17
                        },
                        new
                        {
                            Id = 72,
                            Choice = "Have participants put ear drops in both their infected ear and healthy ear",
                            QuestionId = 18
                        },
                        new
                        {
                            Id = 73,
                            Choice = "Create a second group of participants with ear infections who do not use any ear drops",
                            QuestionId = 18
                        },
                        new
                        {
                            Id = 74,
                            Choice = "Have participants use ear drops for only one week",
                            QuestionId = 18
                        },
                        new
                        {
                            Id = 75,
                            Choice = "Create a second group of participants with ear infections who use 15 drops a day",
                            QuestionId = 18
                        });
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");
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

            modelBuilder.Entity("QuizMVC.Models.Quiz.Question", b =>
                {
                    b.HasOne("QuizMVC.Models.Quiz.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMVC.Models.Quiz.QuestionType", "QuestionType")
                        .WithMany()
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("QuestionType");
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.QuestionAnswer", b =>
                {
                    b.HasOne("QuizMVC.Models.Quiz.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizMVC.Models.Quiz.QuestionChoice", b =>
                {
                    b.HasOne("QuizMVC.Models.Quiz.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });
#pragma warning restore 612, 618
        }
    }
}
