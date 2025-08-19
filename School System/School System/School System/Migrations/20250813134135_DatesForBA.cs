using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class DatesForBA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "RecievedDate",
                table: "BoardAdmissions",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "SentDate",
                table: "BoardAdmissions",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecievedDate",
                table: "BoardAdmissions");

            migrationBuilder.DropColumn(
                name: "SentDate",
                table: "BoardAdmissions");
        }
    }
}
