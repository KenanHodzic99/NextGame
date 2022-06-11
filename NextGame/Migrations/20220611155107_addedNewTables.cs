using Microsoft.EntityFrameworkCore.Migrations;

namespace NextGame.Migrations
{
    public partial class addedNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Igrice");

            migrationBuilder.DropColumn(
                name: "Zanrovi",
                table: "Igrice");

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Igrice",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Platforme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IgricaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platforme_Igrice_IgricaId",
                        column: x => x.IgricaId,
                        principalTable: "Igrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zanrovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IgricaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanrovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zanrovi_Igrice_IgricaId",
                        column: x => x.IgricaId,
                        principalTable: "Igrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Igrice_TipId",
                table: "Igrice",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Platforme_IgricaId",
                table: "Platforme",
                column: "IgricaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zanrovi_IgricaId",
                table: "Zanrovi",
                column: "IgricaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Igrice_Tipovi_TipId",
                table: "Igrice",
                column: "TipId",
                principalTable: "Tipovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Igrice_Tipovi_TipId",
                table: "Igrice");

            migrationBuilder.DropTable(
                name: "Platforme");

            migrationBuilder.DropTable(
                name: "Tipovi");

            migrationBuilder.DropTable(
                name: "Zanrovi");

            migrationBuilder.DropIndex(
                name: "IX_Igrice_TipId",
                table: "Igrice");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Igrice");

            migrationBuilder.AddColumn<string>(
                name: "Tip",
                table: "Igrice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zanrovi",
                table: "Igrice",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
