using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolucionNewShore.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transportes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companiaAerea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroDeVuelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Viajes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viajes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    transporteid = table.Column<int>(type: "int", nullable: false),
                    Viajeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vuelos_Transportes_transporteid",
                        column: x => x.transporteid,
                        principalTable: "Transportes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vuelos_Viajes_Viajeid",
                        column: x => x.Viajeid,
                        principalTable: "Viajes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Viajeid = table.Column<int>(type: "int", nullable: false),
                    Vueloid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.id);
                    table.ForeignKey(
                        name: "FK_Factura_Viajes_Viajeid",
                        column: x => x.Viajeid,
                        principalTable: "Viajes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Vuelos_Vueloid",
                        column: x => x.Vueloid,
                        principalTable: "Vuelos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Viajeid",
                table: "Factura",
                column: "Viajeid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Vueloid",
                table: "Factura",
                column: "Vueloid");

            migrationBuilder.CreateIndex(
                name: "IX_Vuelos_transporteid",
                table: "Vuelos",
                column: "transporteid");

            migrationBuilder.CreateIndex(
                name: "IX_Vuelos_Viajeid",
                table: "Vuelos",
                column: "Viajeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Vuelos");

            migrationBuilder.DropTable(
                name: "Transportes");

            migrationBuilder.DropTable(
                name: "Viajes");
        }
    }
}
