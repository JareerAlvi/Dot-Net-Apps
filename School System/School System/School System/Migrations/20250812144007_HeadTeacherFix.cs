using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class HeadTeacherFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadTeacher",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "HeadTeacherID",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "Classes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadTeacherID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "Classes");

            migrationBuilder.AddColumn<bool>(
                name: "HeadTeacher",
                table: "Classes",
                type: "bit",
                nullable: true,
                defaultValue: false);
        }
    }
}
