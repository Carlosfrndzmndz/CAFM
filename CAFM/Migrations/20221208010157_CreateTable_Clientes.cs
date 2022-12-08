using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAFM.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Abonado = table.Column<bool>(type: "bit", nullable: false),
                    IdModalidad = table.Column<int>(type: "int", nullable: false),
                    FechaVencAbono = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVencCertFact = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuntoDeVenta = table.Column<int>(type: "int", nullable: false),
                    CertificadoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificadoPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
