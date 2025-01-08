using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elsewedy_Platform.Migrations
{
    /// <inheritdoc />
    public partial class ElsewedyPlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "instractor_Softwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instractor_Softwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    National_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cousre_Softs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgae = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_instractor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cousre_Softs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cousre_Softs_instractor_Softwares_Id",
                        column: x => x.Id,
                        principalTable: "instractor_Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cousre_As",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_teacher = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cousre_As", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cousre_As_teachers_Id",
                        column: x => x.Id,
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cousre_softStudent",
                columns: table => new
                {
                    cousre_softId = table.Column<int>(type: "int", nullable: false),
                    studentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cousre_softStudent", x => new { x.cousre_softId, x.studentsId });
                    table.ForeignKey(
                        name: "FK_Cousre_softStudent_cousre_Softs_cousre_softId",
                        column: x => x.cousre_softId,
                        principalTable: "cousre_Softs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cousre_softStudent_students_studentsId",
                        column: x => x.studentsId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "video_soft",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Cousre_softId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_video_soft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_video_soft_cousre_Softs_Cousre_softId",
                        column: x => x.Cousre_softId,
                        principalTable: "cousre_Softs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cousre_acStudent",
                columns: table => new
                {
                    cousres_acId = table.Column<int>(type: "int", nullable: false),
                    studentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cousre_acStudent", x => new { x.cousres_acId, x.studentsId });
                    table.ForeignKey(
                        name: "FK_Cousre_acStudent_cousre_As_cousres_acId",
                        column: x => x.cousres_acId,
                        principalTable: "cousre_As",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cousre_acStudent_students_studentsId",
                        column: x => x.studentsId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "video_ac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Cousre_acId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_video_ac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_video_ac_cousre_As_Cousre_acId",
                        column: x => x.Cousre_acId,
                        principalTable: "cousre_As",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cousre_acStudent_studentsId",
                table: "Cousre_acStudent",
                column: "studentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cousre_softStudent_studentsId",
                table: "Cousre_softStudent",
                column: "studentsId");

            migrationBuilder.CreateIndex(
                name: "IX_video_ac_Cousre_acId",
                table: "video_ac",
                column: "Cousre_acId");

            migrationBuilder.CreateIndex(
                name: "IX_video_soft_Cousre_softId",
                table: "video_soft",
                column: "Cousre_softId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cousre_acStudent");

            migrationBuilder.DropTable(
                name: "Cousre_softStudent");

            migrationBuilder.DropTable(
                name: "video_ac");

            migrationBuilder.DropTable(
                name: "video_soft");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "cousre_As");

            migrationBuilder.DropTable(
                name: "cousre_Softs");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "instractor_Softwares");
        }
    }
}
