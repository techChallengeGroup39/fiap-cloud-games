using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario.Role",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    CriadoPor = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    ModificadoPor = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario.Role", x => x.Guid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario.Role");
        }
    }
}
