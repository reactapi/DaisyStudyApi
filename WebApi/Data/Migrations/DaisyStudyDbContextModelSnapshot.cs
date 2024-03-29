﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DaisyStudyDbContext))]
    partial class DaisyStudyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Reply")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("Data.Entities.CourseMember", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseMembers", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LessonName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("LessonId");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons", (string)null);
                });

            modelBuilder.Entity("Data.Entities.New", b =>
                {
                    b.Property<int>("NewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewId"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NewUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("NewId");

                    b.ToTable("News", (string)null);

                    b.HasData(
                        new
                        {
                            NewId = 1,
                            Image = "https://file1.hutech.edu.vn/file/editor/homepage1/686606-hutech-tuyen-sinh-dao-tao-tu-xa.jpg",
                            NewUrl = "https://www.hutech.edu.vn/tuyensinh/tin-tuc/tin-tuyen-sinh/14607496-hutech-thong-bao-nhan-ho-so-xet-tuyen-he-dai-hoc-tu-xa-nam-2022-den-ngay-2012",
                            Title = "HUTECH thông báo nhận hồ sơ xét tuyển hệ Đại học từ xa năm 2022 đến ngày 13/12"
                        },
                        new
                        {
                            NewId = 2,
                            Image = "https://file1.hutech.edu.vn/file/editor/homepage1/94304-hutech-tuyen-sinh-dai-hoc-tu-xa.jpg",
                            NewUrl = "https://www.hutech.edu.vn/tuyensinh/tin-tuc/tin-tuyen-sinh/14606971-hutech-thong-bao-nhan-ho-so-xet-tuyen-he-dai-hoc-tu-xa-nam-2022-den-ngay-3011",
                            Title = "HUTECH thông báo nhận hồ sơ xét tuyển hệ Đại học từ xa năm 2022 đến ngày 30/11"
                        },
                        new
                        {
                            NewId = 3,
                            Image = "https://file1.hutech.edu.vn/file/editor/tuyensinh/903160-sinh-vien-hutech-tim-hieu-ve-linh-vuc-fintech-cung-nha-sang-lap-bin-corporation-group16.jpg",
                            NewUrl = "https://www.hutech.edu.vn/homepage/tin-tuc/tin-hutech/14607649-sinh-vien-hutech-tim-hieu-ve-linh-vuc-fintech-cung-nha-sang-lap-bin-corporation-group",
                            Title = "Sinh viên HUTECH tìm hiểu về lĩnh vực FINTECH cùng nhà sáng lập BIN Corporation Group"
                        });
                });

            modelBuilder.Entity("Data.Entities.Rating", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings", (string)null);
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("EmailConfirm")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Code = 562765,
                            Dob = new DateTime(2001, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenphuduc62001@gmail.com",
                            EmailConfirm = true,
                            FullName = "Nguyễn Phú Đức",
                            Password = "FE9989D5012230C4C8DD97BD7D209DEF"
                        });
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.HasOne("Data.Entities.Lesson", "Lesson")
                        .WithMany("Comments")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Data.Entities.Course", b =>
                {
                    b.HasOne("Data.Entities.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Data.Entities.CourseMember", b =>
                {
                    b.HasOne("Data.Entities.Course", "Course")
                        .WithMany("CourseMembers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany("CourseMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.Lesson", b =>
                {
                    b.HasOne("Data.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data.Entities.Rating", b =>
                {
                    b.HasOne("Data.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.Category", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Data.Entities.Course", b =>
                {
                    b.Navigation("CourseMembers");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("Data.Entities.Lesson", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("CourseMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
