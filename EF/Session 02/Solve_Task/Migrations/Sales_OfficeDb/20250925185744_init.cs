using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solve_Task.Migrations.Sales_OfficeDb
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Owner_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prop_id = table.Column<int>(type: "int", nullable: false),
                    Precent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Owner_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Office_Num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales__Offices",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales__Offices", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Sales__Offices_Employees_Emp_id",
                        column: x => x.Emp_id,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Office_Num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Sales__Offices_Office_Num",
                        column: x => x.Office_Num,
                        principalTable: "Sales__Offices",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property_Owners",
                columns: table => new
                {
                    Owner_Id = table.Column<int>(type: "int", nullable: false),
                    Prop_id = table.Column<int>(type: "int", nullable: false),
                    Precent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_Owners", x => new { x.Owner_Id, x.Prop_id });
                    table.ForeignKey(
                        name: "FK_property_Owners_Owners_Owner_Id",
                        column: x => x.Owner_Id,
                        principalTable: "Owners",
                        principalColumn: "Owner_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_property_Owners_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Office_Num",
                table: "Employees",
                column: "Office_Num");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Office_Num",
                table: "Properties",
                column: "Office_Num");

            migrationBuilder.CreateIndex(
                name: "IX_property_Owners_PropertyId",
                table: "property_Owners",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales__Offices_Emp_id",
                table: "Sales__Offices",
                column: "Emp_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sales__Offices_Office_Num",
                table: "Employees",
                column: "Office_Num",
                principalTable: "Sales__Offices",
                principalColumn: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sales__Offices_Office_Num",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "property_Owners");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Sales__Offices");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
