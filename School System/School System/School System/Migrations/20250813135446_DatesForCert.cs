using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_System.Migrations
{
    /// <inheritdoc />
    public partial class DatesForCert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "arrivalDte",
                table: "Certificates",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "receivedDate",
                table: "Certificates",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "arrivalDte",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "receivedDate",
                table: "Certificates");
        }
    }
}
