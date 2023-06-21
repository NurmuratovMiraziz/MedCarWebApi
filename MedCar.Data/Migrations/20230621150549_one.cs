using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KasalikNomlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasalikNomlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KlinikaLar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manzili = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlinikaLar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Belgilari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasalikNomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belgilari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Belgilari_KasalikNomlari_KasalikNomisId",
                        column: x => x.KasalikNomisId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DavolanishJadvallari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Malumot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavolanishJadvallari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DavolanishJadvallari_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DavoUsulLari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavoUsulLari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DavoUsulLari_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KasalikSabablari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasalikSabablari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KasalikSabablari_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KutilganKasaliklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KutilganKasaliklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KutilganKasaliklar_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParhezTaomlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParhezTaomlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParhezTaomlar_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sanatoriyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanatoriyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sanatoriyalar_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KasalikNomiKlinika",
                columns: table => new
                {
                    KasalikNomiId = table.Column<int>(type: "int", nullable: false),
                    KlinikaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasalikNomiKlinika", x => new { x.KasalikNomiId, x.KlinikaId });
                    table.ForeignKey(
                        name: "FK_KasalikNomiKlinika_KasalikNomlari_KasalikNomiId",
                        column: x => x.KasalikNomiId,
                        principalTable: "KasalikNomlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasalikNomiKlinika_KlinikaLar_KlinikaId",
                        column: x => x.KlinikaId,
                        principalTable: "KlinikaLar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Belgilari_KasalikNomisId",
                table: "Belgilari",
                column: "KasalikNomisId");

            migrationBuilder.CreateIndex(
                name: "IX_DavolanishJadvallari_KasalikNomiId",
                table: "DavolanishJadvallari",
                column: "KasalikNomiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DavoUsulLari_KasalikNomiId",
                table: "DavoUsulLari",
                column: "KasalikNomiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KasalikNomiKlinika_KlinikaId",
                table: "KasalikNomiKlinika",
                column: "KlinikaId");

            migrationBuilder.CreateIndex(
                name: "IX_KasalikSabablari_KasalikNomiId",
                table: "KasalikSabablari",
                column: "KasalikNomiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KutilganKasaliklar_KasalikNomiId",
                table: "KutilganKasaliklar",
                column: "KasalikNomiId");

            migrationBuilder.CreateIndex(
                name: "IX_ParhezTaomlar_KasalikNomiId",
                table: "ParhezTaomlar",
                column: "KasalikNomiId");

            migrationBuilder.CreateIndex(
                name: "IX_Sanatoriyalar_KasalikNomiId",
                table: "Sanatoriyalar",
                column: "KasalikNomiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Belgilari");

            migrationBuilder.DropTable(
                name: "DavolanishJadvallari");

            migrationBuilder.DropTable(
                name: "DavoUsulLari");

            migrationBuilder.DropTable(
                name: "KasalikNomiKlinika");

            migrationBuilder.DropTable(
                name: "KasalikSabablari");

            migrationBuilder.DropTable(
                name: "KutilganKasaliklar");

            migrationBuilder.DropTable(
                name: "ParhezTaomlar");

            migrationBuilder.DropTable(
                name: "Sanatoriyalar");

            migrationBuilder.DropTable(
                name: "KlinikaLar");

            migrationBuilder.DropTable(
                name: "KasalikNomlari");
        }
    }
}
