using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class Ficesdadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "BoardAdmissions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "BoardAdmissions");
        }
    }
}
