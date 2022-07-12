using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventarios_BE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    PRO_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRO_MARCA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PRO_FECHA_INGRESO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRO_MODELO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRO_SERIAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_COD_ACTIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_GEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_NUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_ASIGNADO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_USO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_USER_WIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_WIN_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_NOMBRE_PRODUCTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_DIRECCION_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_ANYDESK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_CON_ANYDESK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_SO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_OFFICE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_FILESERVER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRO_ANTIVIRUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.PRO_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
