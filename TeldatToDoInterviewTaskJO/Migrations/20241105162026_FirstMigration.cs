using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeldatToDoInterviewTaskJO.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assigments",
                columns: table => new
                {
                    AssigmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssigmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssigmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssigmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assigments", x => x.AssigmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assigments");
        }
    }
}
