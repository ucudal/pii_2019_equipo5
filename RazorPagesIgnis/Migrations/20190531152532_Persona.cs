using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesIgnis.Migrations
{
    public partial class Persona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoraJornada = table.Column<int>(nullable: false),
                    CostoHoraBasico = table.Column<int>(nullable: false),
                    CostoHoraAvanzado = table.Column<int>(nullable: false),
                    PrimeraHoraBasico = table.Column<int>(nullable: false),
                    PrimeraHoraAvanzado = table.Column<int>(nullable: false),
                    JornadaBasico = table.Column<int>(nullable: false),
                    JornadaAvanzado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Contrasena = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Edad = table.Column<int>(nullable: true),
                    Presentacion = table.Column<string>(nullable: true),
                    Nivel_experiencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Solicitud_Rol = table.Column<string>(nullable: true),
                    Solicitud_Experiencia = table.Column<string>(nullable: true),
                    Solicitud_Obs = table.Column<string>(nullable: true),
                    TecnicoAsignadoID = table.Column<int>(nullable: true),
                    HorasRealizadas = table.Column<int>(nullable: false),
                    ProyectoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Solicitud_Proyecto_ProyectoID",
                        column: x => x.ProyectoID,
                        principalTable: "Proyecto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Solicitud_Persona_TecnicoAsignadoID",
                        column: x => x.TecnicoAsignadoID,
                        principalTable: "Persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_ProyectoID",
                table: "Solicitud",
                column: "ProyectoID");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_TecnicoAsignadoID",
                table: "Solicitud",
                column: "TecnicoAsignadoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costo");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
