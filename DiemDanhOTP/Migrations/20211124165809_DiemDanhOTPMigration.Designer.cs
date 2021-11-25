﻿// <auto-generated />
using System;
using DiemDanhOTP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiemDanhOTP.Migrations
{
    [DbContext(typeof(DIEMDANH_APIContext))]
    [Migration("20211124165809_DiemDanhOTPMigration")]
    partial class DiemDanhOTPMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiemDanhOTP.Models.Admin", b =>
                {
                    b.Property<byte>("Idadmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("IDAdmin")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Usename")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Idadmin");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Course", b =>
                {
                    b.Property<string>("Idcourse")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("IDCourse");

                    b.Property<string>("CoursetName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte?>("Noc")
                        .HasColumnType("tinyint")
                        .HasColumnName("NOC");

                    b.Property<byte?>("Peroid")
                        .HasColumnType("tinyint");

                    b.HasKey("Idcourse");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.GroupSubject", b =>
                {
                    b.Property<int>("Idgroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDGroup")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("date");

                    b.Property<string>("Idcourse")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("IDCourse");

                    b.Property<int?>("Idteacher")
                        .HasColumnType("int")
                        .HasColumnName("IDTeacher");

                    b.Property<byte?>("Semester")
                        .HasColumnType("tinyint");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Idgroup");

                    b.HasIndex(new[] { "Idcourse" }, "IX_Relationship10");

                    b.HasIndex(new[] { "Idteacher" }, "IX_Relationship12");

                    b.ToTable("GroupSubject");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Session", b =>
                {
                    b.Property<int>("Idsession")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDSession")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classroom")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Day")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Idgroup")
                        .HasColumnType("int")
                        .HasColumnName("IDGroup");

                    b.Property<byte?>("PeriodEnd")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("PeriodStart")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Session1")
                        .HasColumnType("tinyint")
                        .HasColumnName("Session");

                    b.HasKey("Idsession");

                    b.HasIndex(new[] { "Idgroup" }, "IX_Relationship28");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.SessionDetail", b =>
                {
                    b.Property<int>("Idlession")
                        .HasColumnType("int")
                        .HasColumnName("IDLession");

                    b.Property<string>("Idstuddent")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("IDStuddent");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otp")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("OTP");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength(true);

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("Idlession", "Idstuddent");

                    b.HasIndex("Idstuddent");

                    b.ToTable("SessionDetail");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Student", b =>
                {
                    b.Property<string>("Idstudent")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("IDStudent");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Class")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Idstudent");

                    b.HasIndex(new[] { "Id" }, "IX_Relationship27");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Study", b =>
                {
                    b.Property<int>("Idgroup")
                        .HasColumnType("int")
                        .HasColumnName("IDGroup");

                    b.Property<string>("Idstudent")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("IDStudent");

                    b.Property<byte?>("Stt")
                        .HasColumnType("tinyint")
                        .HasColumnName("STT");

                    b.HasIndex("Idgroup");

                    b.HasIndex("Idstudent");

                    b.ToTable("Study");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Teacher", b =>
                {
                    b.Property<int>("Idteacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDTeacher")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<int?>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("SourceTeacher")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Idteacher");

                    b.HasIndex(new[] { "Id" }, "IX_Relationship26");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte?>("Idadmin")
                        .HasColumnType("tinyint")
                        .HasColumnName("IDAdmin");

                    b.Property<string>("Password")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Role")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength(true);

                    b.Property<string>("Usename")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Idadmin" }, "IX_Relationship25");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.GroupSubject", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.Course", "IdcourseNavigation")
                        .WithMany("GroupSubjects")
                        .HasForeignKey("Idcourse")
                        .HasConstraintName("Relationship10");

                    b.HasOne("DiemDanhOTP.Models.Teacher", "IdteacherNavigation")
                        .WithMany("GroupSubjects")
                        .HasForeignKey("Idteacher")
                        .HasConstraintName("Relationship12");

                    b.Navigation("IdcourseNavigation");

                    b.Navigation("IdteacherNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Session", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.GroupSubject", "IdgroupNavigation")
                        .WithMany("Sessions")
                        .HasForeignKey("Idgroup")
                        .HasConstraintName("Relationship28");

                    b.Navigation("IdgroupNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.SessionDetail", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.Session", "IdlessionNavigation")
                        .WithMany("SessionDetails")
                        .HasForeignKey("Idlession")
                        .HasConstraintName("Relationship1")
                        .IsRequired();

                    b.HasOne("DiemDanhOTP.Models.Student", "IdstuddentNavigation")
                        .WithMany("SessionDetails")
                        .HasForeignKey("Idstuddent")
                        .HasConstraintName("Relationship2")
                        .IsRequired();

                    b.Navigation("IdlessionNavigation");

                    b.Navigation("IdstuddentNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Student", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.User", "IdNavigation")
                        .WithMany("Students")
                        .HasForeignKey("Id")
                        .HasConstraintName("Relationship27");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Study", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.GroupSubject", "IdgroupNavigation")
                        .WithMany()
                        .HasForeignKey("Idgroup")
                        .HasConstraintName("Relationship13")
                        .IsRequired();

                    b.HasOne("DiemDanhOTP.Models.Student", "IdstudentNavigation")
                        .WithMany()
                        .HasForeignKey("Idstudent")
                        .HasConstraintName("Relationship14")
                        .IsRequired();

                    b.Navigation("IdgroupNavigation");

                    b.Navigation("IdstudentNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Teacher", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.User", "IdNavigation")
                        .WithMany("Teachers")
                        .HasForeignKey("Id")
                        .HasConstraintName("Relationship26");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.User", b =>
                {
                    b.HasOne("DiemDanhOTP.Models.Admin", "IdadminNavigation")
                        .WithMany("Users")
                        .HasForeignKey("Idadmin")
                        .HasConstraintName("Relationship25");

                    b.Navigation("IdadminNavigation");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Admin", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Course", b =>
                {
                    b.Navigation("GroupSubjects");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.GroupSubject", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Session", b =>
                {
                    b.Navigation("SessionDetails");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Student", b =>
                {
                    b.Navigation("SessionDetails");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.Teacher", b =>
                {
                    b.Navigation("GroupSubjects");
                });

            modelBuilder.Entity("DiemDanhOTP.Models.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
