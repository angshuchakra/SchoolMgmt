﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolMgmt.SchoolMgmtDAL;

namespace SchoolMgmt.Migrations
{
    [DbContext(typeof(SchoolMgmtDB))]
    partial class SchoolMgmtDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.AcademicClasses", b =>
                {
                    b.Property<int>("AcademicClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassStream")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassSubjectCombination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("date");

                    b.HasKey("AcademicClassID");

                    b.ToTable("AcademicClasses");
                });

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.LocalGuardian", b =>
                {
                    b.Property<int>("LocalGuardianID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("LGAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LGContactNumer")
                        .HasColumnType("int");

                    b.Property<string>("LGName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LGOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithParent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("date");

                    b.HasKey("LocalGuardianID");

                    b.ToTable("LocalGuardians");
                });

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.ParentDtails", b =>
                {
                    b.Property<int>("ParentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("FathersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocalGuardianID")
                        .HasColumnType("int");

                    b.Property<string>("MothersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentContactNumer")
                        .HasColumnType("int");

                    b.Property<string>("ParentOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("date");

                    b.HasKey("ParentID");

                    b.HasIndex("LocalGuardianID");

                    b.ToTable("ParentDetails");
                });

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.StudentDetail", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int")
                        .HasMaxLength(15);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("CurrentAddress")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int?>("LocalGuardianID")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentDtailsParentID")
                        .HasColumnType("int");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("StudentAge")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("StudentClass")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("StudentRollNumber")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("date");

                    b.Property<string>("studentSex")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("StudentID");

                    b.HasIndex("LocalGuardianID");

                    b.HasIndex("ParentDtailsParentID");

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.StudentToClassRelation", b =>
                {
                    b.Property<int>("StudentToClassRelationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicClassID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("date");

                    b.HasKey("StudentToClassRelationID");

                    b.ToTable("StudentToClassRelations");
                });

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.ParentDtails", b =>
                {
                    b.HasOne("SchoolMgmt.SchoolMgmtDAL.LocalGuardian", null)
                        .WithMany("ParentDtails")
                        .HasForeignKey("LocalGuardianID");
                });

            modelBuilder.Entity("SchoolMgmt.SchoolMgmtDAL.StudentDetail", b =>
                {
                    b.HasOne("SchoolMgmt.SchoolMgmtDAL.LocalGuardian", null)
                        .WithMany("Student")
                        .HasForeignKey("LocalGuardianID");

                    b.HasOne("SchoolMgmt.SchoolMgmtDAL.ParentDtails", null)
                        .WithMany("Student")
                        .HasForeignKey("ParentDtailsParentID");
                });
#pragma warning restore 612, 618
        }
    }
}
