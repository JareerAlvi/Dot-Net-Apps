using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class FixAddedBoardAdmissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardAdmission_Students_StudentId",
                table: "BoardAdmission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoardAdmission",
                table: "BoardAdmission");

            migrationBuilder.RenameTable(
                name: "BoardAdmission",
                newName: "BoardAdmissions");

            migrationBuilder.RenameIndex(
                name: "IX_BoardAdmission_StudentId",
                table: "BoardAdmissions",
                newName: "IX_BoardAdmissions_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoardAdmissions",
                table: "BoardAdmissions",
                column: "BoardAdmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardAdmissions_Students_StudentId",
                table: "BoardAdmissions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardAdmissions_Students_StudentId",
                table: "BoardAdmissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoardAdmissions",
                table: "BoardAdmissions");

            migrationBuilder.RenameTable(
                name: "BoardAdmissions",
                newName: "BoardAdmission");

            migrationBuilder.RenameIndex(
                name: "IX_BoardAdmissions_StudentId",
                table: "BoardAdmission",
                newName: "IX_BoardAdmission_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoardAdmission",
                table: "BoardAdmission",
                column: "BoardAdmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardAdmission_Students_StudentId",
                table: "BoardAdmission",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
