using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWeek8.EF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    IdMenu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    IdUtente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.IdUtente);
                });

            migrationBuilder.CreateTable(
                name: "Piatti",
                columns: table => new
                {
                    IdPiatto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descrizione = table.Column<string>(maxLength: 200, nullable: false),
                    Tipologia = table.Column<int>(nullable: false),
                    Prezzo = table.Column<decimal>(nullable: false),
                    MenuID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piatti", x => x.IdPiatto);
                    table.ForeignKey(
                        name: "FK_Piatti_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "IdMenu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "IdMenu", "Nome" },
                values: new object[,]
                {
                    { 1, "Menu giornaliero" },
                    { 2, "Menu serale" }
                });

            migrationBuilder.InsertData(
                table: "Utenti",
                columns: new[] { "IdUtente", "Email", "Password", "Tipo" },
                values: new object[,]
                {
                    { 1, "Giovanni.Storti@gmail.com", "pdor", 0 },
                    { 2, "Giacomino.Poretti@gmail.com", "tafazzi", 1 },
                    { 3, "Aldo.Baglio@gmail.com", "rolando", 1 }
                });

            migrationBuilder.InsertData(
                table: "Piatti",
                columns: new[] { "IdPiatto", "Descrizione", "MenuID", "Nome", "Prezzo", "Tipologia" },
                values: new object[,]
                {
                    { 1, "piatto di tagliatelle al ragu di carne, 100g", 1, "Tagliatelle al Ragu", 12.55m, 0 },
                    { 2, "selezione di verdure miste", 1, "Verdure miste", 12.55m, 2 },
                    { 3, "brodo di carne di manzo ", 2, "Brodo di carne", 12.55m, 0 },
                    { 4, "cotoletta alla milanese", 2, "Cotoletta", 12.55m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piatti_MenuID",
                table: "Piatti",
                column: "MenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piatti");

            migrationBuilder.DropTable(
                name: "Utenti");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
