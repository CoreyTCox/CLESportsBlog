using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLESportsBlog.Migrations
{
    public partial class ChangedIndiansLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 21, 36, 59, 584, DateTimeKind.Local).AddTicks(8476));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 22, 36, 138, DateTimeKind.Local).AddTicks(3893));
        }
    }
}
