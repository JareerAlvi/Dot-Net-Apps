using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class HeadTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isHeadTeacher",
                table: "Teachers",
                newName: "IsHeadTeacher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsHeadTeacher",
                table: "Teachers",
                newName: "isHeadTeacher");
        }
    }
}
