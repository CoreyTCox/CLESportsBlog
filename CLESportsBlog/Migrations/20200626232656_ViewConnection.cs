using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLESportsBlog.Migrations
{
    public partial class ViewConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 19, 26, 55, 677, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 19, 26, 55, 682, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 19, 26, 55, 682, DateTimeKind.Local).AddTicks(430));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 18, 54, 59, 187, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 18, 54, 59, 191, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 18, 54, 59, 191, DateTimeKind.Local).AddTicks(8530));
        }
    }
}
