using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solve_Task.Migrations.MusicianDb
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PH_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musician_Instruments",
                columns: table => new
                {
                    Musician_id = table.Column<int>(type: "int", nullable: false),
                    Inst_id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician_Instruments", x => new { x.Musician_id, x.Inst_id });
                    table.ForeignKey(
                        name: "FK_Musician_Instruments_Instruments_Inst_id",
                        column: x => x.Inst_id,
                        principalTable: "Instruments",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musician_Instruments_Musicians_Musician_id",
                        column: x => x.Musician_id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musician_Songs",
                columns: table => new
                {
                    Mus_id = table.Column<int>(type: "int", nullable: false),
                    Song_title = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician_Songs", x => new { x.Mus_id, x.Song_title });
                    table.ForeignKey(
                        name: "FK_Musician_Songs_Musicians_Mus_id",
                        column: x => x.Mus_id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musician_Songs_Songs_Song_title",
                        column: x => x.Song_title,
                        principalTable: "Songs",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Album_Songs",
                columns: table => new
                {
                    Album_id = table.Column<int>(type: "int", nullable: false),
                    song_title = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album_Songs", x => x.Album_id);
                    table.ForeignKey(
                        name: "FK_Album_Songs_Albums_Album_id",
                        column: x => x.Album_id,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Album_Songs_Songs_song_title",
                        column: x => x.song_title,
                        principalTable: "Songs",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_Songs_song_title",
                table: "Album_Songs",
                column: "song_title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_Mus_Id",
                table: "Albums",
                column: "Mus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Musician_Instruments_Inst_id",
                table: "Musician_Instruments",
                column: "Inst_id");

            migrationBuilder.CreateIndex(
                name: "IX_Musician_Songs_Song_title",
                table: "Musician_Songs",
                column: "Song_title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album_Songs");

            migrationBuilder.DropTable(
                name: "Musician_Instruments");

            migrationBuilder.DropTable(
                name: "Musician_Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
