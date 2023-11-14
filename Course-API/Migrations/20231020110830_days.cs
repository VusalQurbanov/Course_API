using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Course_API.Migrations
{
    /// <inheritdoc />
    public partial class days : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_LessonDays_LessonDaysId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_LessonHours_LessonHoursId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonDays_Group_GroupId",
                table: "LessonDays");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonHours_Group_GroupId",
                table: "LessonHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Course_CourseId",
                table: "Room");

            migrationBuilder.DropTable(
                name: "LessonDaysLessonHours");

            migrationBuilder.DropIndex(
                name: "IX_Room_CourseId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_LessonHours_GroupId",
                table: "LessonHours");

            migrationBuilder.DropIndex(
                name: "IX_LessonDays_GroupId",
                table: "LessonDays");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_LessonDaysId",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_LessonHoursId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "LessonDays");

            migrationBuilder.DropColumn(
                name: "LessonDaysId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "LessonHoursId",
                table: "Lesson");

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

            migrationBuilder.CreateTable(
                name: "CourseRoom",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRoom", x => new { x.CourseId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_CourseRoom_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRoom_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupLessonDays",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "integer", nullable: false),
                    LessonDaysId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupLessonDays", x => new { x.GroupId, x.LessonDaysId });
                    table.ForeignKey(
                        name: "FK_GroupLessonDays_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupLessonDays_LessonDays_LessonDaysId",
                        column: x => x.LessonDaysId,
                        principalTable: "LessonDays",
                        principalColumn: "LessonDaysId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupLessonHours",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "integer", nullable: false),
                    LessonHoursId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupLessonHours", x => new { x.GroupId, x.LessonHoursId });
                    table.ForeignKey(
                        name: "FK_GroupLessonHours_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupLessonHours_LessonHours_LessonHoursId",
                        column: x => x.LessonHoursId,
                        principalTable: "LessonHours",
                        principalColumn: "LessonHoursId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LessonDays",
                columns: new[] { "LessonDaysId", "Day", "LessonHoursId" },
                values: new object[,]
                {
                    { 1, "Bazar Ertesi", null },
                    { 2, "Cersenbe Axsami", null },
                    { 3, "Cersenbe", null },
                    { 4, "Cume Axsami", null },
                    { 5, "Cume", null },
                    { 6, "Senbe", null }
                });

            migrationBuilder.InsertData(
                table: "LessonHours",
                columns: new[] { "LessonHoursId", "Hours", "LessonDaysId" },
                values: new object[,]
                {
                    { 1, "10:00-12:00", null },
                    { 2, "12:00-14:00", null },
                    { 3, "14:00-16:00", null },
                    { 4, "16:00-18:00", null },
                    { 5, "18:00-20:00", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRoom_RoomId",
                table: "CourseRoom",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupLessonDays_LessonDaysId",
                table: "GroupLessonDays",
                column: "LessonDaysId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupLessonHours_LessonHoursId",
                table: "GroupLessonHours",
                column: "LessonHoursId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRoom");

            migrationBuilder.DropTable(
                name: "GroupLessonDays");

            migrationBuilder.DropTable(
                name: "GroupLessonHours");

            migrationBuilder.DeleteData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonDays",
                keyColumn: "LessonDaysId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonHours",
                keyColumn: "LessonHoursId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "LessonDaysId",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "LessonHoursId",
                table: "LessonDays");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Room",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "LessonHours",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "LessonDays",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonDaysId",
                table: "Lesson",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonHoursId",
                table: "Lesson",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LessonDaysLessonHours",
                columns: table => new
                {
                    DaysLessonDaysId = table.Column<int>(type: "integer", nullable: false),
                    HoursLessonHoursId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonDaysLessonHours", x => new { x.DaysLessonDaysId, x.HoursLessonHoursId });
                    table.ForeignKey(
                        name: "FK_LessonDaysLessonHours_LessonDays_DaysLessonDaysId",
                        column: x => x.DaysLessonDaysId,
                        principalTable: "LessonDays",
                        principalColumn: "LessonDaysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonDaysLessonHours_LessonHours_HoursLessonHoursId",
                        column: x => x.HoursLessonHoursId,
                        principalTable: "LessonHours",
                        principalColumn: "LessonHoursId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_CourseId",
                table: "Room",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonHours_GroupId",
                table: "LessonHours",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonDays_GroupId",
                table: "LessonDays",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_LessonDaysId",
                table: "Lesson",
                column: "LessonDaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_LessonHoursId",
                table: "Lesson",
                column: "LessonHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonDaysLessonHours_HoursLessonHoursId",
                table: "LessonDaysLessonHours",
                column: "HoursLessonHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_LessonDays_LessonDaysId",
                table: "Lesson",
                column: "LessonDaysId",
                principalTable: "LessonDays",
                principalColumn: "LessonDaysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_LessonHours_LessonHoursId",
                table: "Lesson",
                column: "LessonHoursId",
                principalTable: "LessonHours",
                principalColumn: "LessonHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonDays_Group_GroupId",
                table: "LessonDays",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonHours_Group_GroupId",
                table: "LessonHours",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Course_CourseId",
                table: "Room",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
