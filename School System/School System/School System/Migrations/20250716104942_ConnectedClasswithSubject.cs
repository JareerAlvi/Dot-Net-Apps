using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class ConnectedClasswithSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSubjects");

            migrationBuilder.AddColumn<int>(
       name: "ClassId",
       table: "Subjects",
       type: "int",
       nullable: true);


            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ClassId",
                table: "Subjects",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Classes_ClassId",
                table: "Subjects",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Classes_ClassId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ClassId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Subjects");

            migrationBuilder.CreateTable(
                name: "ClassSubjects",
                columns: table => new
                {
                    ClassSubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: true),
                    SubjectID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClassSub__79A97339F0A17125", x => x.ClassSubjectID);
                    table.ForeignKey(
                        name: "FK__ClassSubj__Class__45F365D3",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK__ClassSubj__Subje__46E78A0C",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_ClassID",
                table: "ClassSubjects",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_SubjectID",
                table: "ClassSubjects",
                column: "SubjectID");
        }
    }
}
