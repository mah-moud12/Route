using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solve_Task.Migrations.HospitalDb
{
    /// <inheritdoc />
    public partial class InitialCreationHospital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "Drug_Brands",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drug_Brands", x => new { x.Code, x.Brand });
                    table.ForeignKey(
                        name: "FK_Drug_Brands_Drugs_Code",
                        column: x => x.Code,
                        principalTable: "Drugs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nurse_Num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wards_Nurses_Nurse_Num",
                        column: x => x.Nurse_Num,
                        principalTable: "Nurses",
                        principalColumn: "Number");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBarth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ward_Id = table.Column<int>(type: "int", nullable: false),
                    Cons_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Consultants_Cons_Id",
                        column: x => x.Cons_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Wards_Ward_Id",
                        column: x => x.Ward_Id,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Consultants",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Cons_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Consultants", x => new { x.Patient_Id, x.Cons_Id });
                    table.ForeignKey(
                        name: "FK_Patient_Consultants_Consultants_Cons_Id",
                        column: x => x.Cons_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Consultants_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient_Drug_Nurses",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    Nurse_Number = table.Column<int>(type: "int", nullable: false),
                    Drug_Code = table.Column<int>(type: "int", nullable: false),
                    Dossage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Drug_Nurses", x => new { x.Patient_Id, x.Date, x.Time });
                    table.ForeignKey(
                        name: "FK_Patient_Drug_Nurses_Drugs_Drug_Code",
                        column: x => x.Drug_Code,
                        principalTable: "Drugs",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Patient_Drug_Nurses_Nurses_Nurse_Number",
                        column: x => x.Nurse_Number,
                        principalTable: "Nurses",
                        principalColumn: "Number");
                    table.ForeignKey(
                        name: "FK_Patient_Drug_Nurses_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Consultants_Cons_Id",
                table: "Patient_Consultants",
                column: "Cons_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Drug_Nurses_Drug_Code",
                table: "Patient_Drug_Nurses",
                column: "Drug_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Drug_Nurses_Nurse_Number",
                table: "Patient_Drug_Nurses",
                column: "Nurse_Number");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Cons_Id",
                table: "Patients",
                column: "Cons_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_Nurse_Num",
                table: "Wards",
                column: "Nurse_Num",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drug_Brands");

            migrationBuilder.DropTable(
                name: "Patient_Consultants");

            migrationBuilder.DropTable(
                name: "Patient_Drug_Nurses");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "Nurses");
        }
    }
}
