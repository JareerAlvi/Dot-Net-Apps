using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsAssignedToSubjectsClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAssigned",
                table: "Subjects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAssigned",
                table: "Subjects");
        }
    }
}
