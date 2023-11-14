using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Course_API.Migrations
{
    /// <inheritdoc />
    public partial class dayhour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonDaysId",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "LessonHoursId",
                table: "LessonDays");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<int>>(
                name: "LessonDaysId",
                table: "LessonHours",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AddColumn<List<int>>(
                name: "LessonHoursId",
                table: "LessonDays",
                type: "integer[]",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 1,
                column: "LessonHoursId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 2,
                column: "LessonHoursId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 3,
                column: "LessonHoursId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 4,
                column: "LessonHoursId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 5,
                column: "LessonHoursId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 6,
                column: "LessonHoursId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 1,
                column: "LessonDaysId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 2,
                column: "LessonDaysId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 3,
                column: "LessonDaysId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 4,
                column: "LessonDaysId",
                value: null);

            migrationBuilder.UpdateData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 5,
                column: "LessonDaysId",
                value: null);
        }
    }
}
