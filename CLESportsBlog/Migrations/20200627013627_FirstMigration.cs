using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLESportsBlog.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { 1, "Lebron", "Cavs Post", new DateTime(2020, 6, 26, 21, 36, 26, 632, DateTimeKind.Local).AddTicks(1931), 1, "Cavs" },
                    { 2, "Lindor", "Indinas Post", new DateTime(2020, 6, 26, 21, 36, 26, 636, DateTimeKind.Local).AddTicks(4640), 2, "Indians" },
                    { 3, "Kosar", "Browns Post", new DateTime(2020, 6, 26, 21, 36, 26, 636, DateTimeKind.Local).AddTicks(4763), 3, "Browns" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ImageLink", "Name" },
                values: new object[,]
                {
                    { 1, "./images/cavslogo.png", "Cavs" },
                    { 2, "./images/indianslogo.png", "Indians" },
                    { 3, "./images/brownslogo.png", "Browns" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
