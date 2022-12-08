using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAFM.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableClientesUpdateTableRolPermisosUsuarioPermisoRolesUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "RolesUsuario",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "RolesUsuario",
                newName: "IdRol");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "PermisosRol",
                newName: "IdRol");

            migrationBuilder.RenameColumn(
                name: "PermisoId",
                table: "PermisosRol",
                newName: "IdPermiso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "RolesUsuario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "RolesUsuario",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "PermisosRol",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "IdPermiso",
                table: "PermisosRol",
                newName: "PermisoId");
        }
    }
}
