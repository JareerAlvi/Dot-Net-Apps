using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class ConnectedClassWithStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassID",
                table: "Students",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassID",
                table: "Students");
        }
    }
}
