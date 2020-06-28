using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolMgmt.Migrations
{
    public partial class _1stCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicClasses",
                columns: table => new
                {
                    AcademicClassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    ClassStream = table.Column<string>(nullable: true),
                    ClassSubjectCombination = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicClasses", x => x.AcademicClassID);
                });

            migrationBuilder.CreateTable(
                name: "LocalGuardians",
                columns: table => new
                {
                    LocalGuardianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LGName = table.Column<string>(nullable: true),
                    LGAddress = table.Column<string>(nullable: true),
                    LGContactNumer = table.Column<int>(nullable: false),
                    LGOccupation = table.Column<string>(nullable: true),
                    RelationWithParent = table.Column<string>(nullable: true),
                    AdharNumber = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGuardians", x => x.LocalGuardianID);
                });

            migrationBuilder.CreateTable(
                name: "StudentToClassRelations",
                columns: table => new
                {
                    StudentToClassRelationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    AcademicClassID = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentToClassRelations", x => x.StudentToClassRelationID);
                });

            migrationBuilder.CreateTable(
                name: "ParentDetails",
                columns: table => new
                {
                    ParentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FathersName = table.Column<string>(nullable: true),
                    MothersName = table.Column<string>(nullable: true),
                    ParentAddress = table.Column<string>(nullable: true),
                    ParentContactNumer = table.Column<int>(nullable: false),
                    ParentOccupation = table.Column<string>(nullable: true),
                    AdharNumber = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true),
                    LocalGuardianID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentDetails", x => x.ParentID);
                    table.ForeignKey(
                        name: "FK_ParentDetails_LocalGuardians_LocalGuardianID",
                        column: x => x.LocalGuardianID,
                        principalTable: "LocalGuardians",
                        principalColumn: "LocalGuardianID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRollNumber = table.Column<int>(nullable: false),
                    StudentClass = table.Column<string>(maxLength: 20, nullable: true),
                    StudentName = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    StudentAge = table.Column<int>(maxLength: 20, nullable: false),
                    studentSex = table.Column<string>(maxLength: 100, nullable: true),
                    CurrentAddress = table.Column<string>(maxLength: 500, nullable: true),
                    PermanentAddress = table.Column<string>(maxLength: 500, nullable: true),
                    ContactNumber = table.Column<int>(maxLength: 15, nullable: false),
                    Nationality = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true),
                    LocalGuardianID = table.Column<int>(nullable: true),
                    ParentDtailsParentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_StudentDetails_LocalGuardians_LocalGuardianID",
                        column: x => x.LocalGuardianID,
                        principalTable: "LocalGuardians",
                        principalColumn: "LocalGuardianID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentDetails_ParentDetails_ParentDtailsParentID",
                        column: x => x.ParentDtailsParentID,
                        principalTable: "ParentDetails",
                        principalColumn: "ParentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetails_LocalGuardianID",
                table: "ParentDetails",
                column: "LocalGuardianID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_LocalGuardianID",
                table: "StudentDetails",
                column: "LocalGuardianID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_ParentDtailsParentID",
                table: "StudentDetails",
                column: "ParentDtailsParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicClasses");

            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DropTable(
                name: "StudentToClassRelations");

            migrationBuilder.DropTable(
                name: "ParentDetails");

            migrationBuilder.DropTable(
                name: "LocalGuardians");
        }
    }
}
