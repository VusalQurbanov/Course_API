﻿// <auto-generated />
using System;
using Course_API.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Course_API.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231024074721_student")]
    partial class student
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseRoom", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.HasKey("CourseId", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("CourseRoom");
                });

            modelBuilder.Entity("Course_API.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "CodeAcademy"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Matrix"
                        });
                });

            modelBuilder.Entity("Course_API.Entities.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("LessonId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LessonId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("Course_API.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LessonId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("LessonName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LessonId");

                    b.HasIndex("CourseId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("Course_API.Entities.LessonDays", b =>
                {
                    b.Property<int>("LessonDaysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LessonDaysId"));

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LessonDaysId");

                    b.ToTable("LessonDays");

                    b.HasData(
                        new
                        {
                            LessonDaysId = 1,
                            Day = "Bazar Ertesi"
                        },
                        new
                        {
                            LessonDaysId = 2,
                            Day = "Cersenbe Axsami"
                        },
                        new
                        {
                            LessonDaysId = 3,
                            Day = "Cersenbe"
                        },
                        new
                        {
                            LessonDaysId = 4,
                            Day = "Cume Axsami"
                        },
                        new
                        {
                            LessonDaysId = 5,
                            Day = "Cume"
                        },
                        new
                        {
                            LessonDaysId = 6,
                            Day = "Senbe"
                        });
                });

            modelBuilder.Entity("Course_API.Entities.LessonHours", b =>
                {
                    b.Property<int>("LessonHoursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LessonHoursId"));

                    b.Property<string>("Hours")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LessonHoursId");

                    b.ToTable("LessonHours");

                    b.HasData(
                        new
                        {
                            LessonHoursId = 1,
                            Hours = "10:00-12:00"
                        },
                        new
                        {
                            LessonHoursId = 2,
                            Hours = "12:00-14:00"
                        },
                        new
                        {
                            LessonHoursId = 3,
                            Hours = "14:00-16:00"
                        },
                        new
                        {
                            LessonHoursId = 4,
                            Hours = "16:00-18:00"
                        },
                        new
                        {
                            LessonHoursId = 5,
                            Hours = "18:00-20:00"
                        });
                });

            modelBuilder.Entity("Course_API.Entities.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomId"));

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoomId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Course_API.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("GroupId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Course_API.Entities.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeacherId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("LessonId")
                        .HasColumnType("integer");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TeacherSurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TeacherId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LessonId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("GroupLessonDays", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("LessonDaysId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId", "LessonDaysId");

                    b.HasIndex("LessonDaysId");

                    b.ToTable("GroupLessonDays");
                });

            modelBuilder.Entity("GroupLessonHours", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("LessonHoursId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId", "LessonHoursId");

                    b.HasIndex("LessonHoursId");

                    b.ToTable("GroupLessonHours");
                });

            modelBuilder.Entity("CourseRoom", b =>
                {
                    b.HasOne("Course_API.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course_API.Entities.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Course_API.Entities.Group", b =>
                {
                    b.HasOne("Course_API.Entities.Course", null)
                        .WithMany("Group")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course_API.Entities.Lesson", null)
                        .WithMany("Groups")
                        .HasForeignKey("LessonId");

                    b.HasOne("Course_API.Entities.Teacher", null)
                        .WithMany("Group")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Course_API.Entities.Lesson", b =>
                {
                    b.HasOne("Course_API.Entities.Course", null)
                        .WithMany("Lesson")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Course_API.Entities.Student", b =>
                {
                    b.HasOne("Course_API.Entities.Course", null)
                        .WithMany("Student")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course_API.Entities.Group", null)
                        .WithMany("Student")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Course_API.Entities.Teacher", b =>
                {
                    b.HasOne("Course_API.Entities.Course", null)
                        .WithMany("Teacher")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course_API.Entities.Lesson", null)
                        .WithMany("Teacher")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupLessonDays", b =>
                {
                    b.HasOne("Course_API.Entities.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course_API.Entities.LessonDays", null)
                        .WithMany()
                        .HasForeignKey("LessonDaysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupLessonHours", b =>
                {
                    b.HasOne("Course_API.Entities.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Course_API.Entities.LessonHours", null)
                        .WithMany()
                        .HasForeignKey("LessonHoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Course_API.Entities.Course", b =>
                {
                    b.Navigation("Group");

                    b.Navigation("Lesson");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Course_API.Entities.Group", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("Course_API.Entities.Lesson", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Course_API.Entities.Teacher", b =>
                {
                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
