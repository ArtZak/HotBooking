using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBooking.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "InspirationItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspirationItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d3ddd39e-f1e1-4fec-b364-dd4a2ba4ee8e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0087ed45-0a78-4a7b-b747-714fabc5d76b", "AQAAAAEAACcQAAAAEFZxy0hAahwv7Af52jUs7C2CU1x0TXedu0A99vIO9PuulM+AVB7ba24en2IZl6ff5w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2021, 3, 18, 14, 1, 37, 889, DateTimeKind.Utc).AddTicks(4938), "Contacts" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2021, 3, 18, 14, 1, 37, 889, DateTimeKind.Utc).AddTicks(3091), "Home" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "CodeWord", "DateAdded", "Title" },
                values: new object[] { "PageInspiration", new DateTime(2021, 3, 18, 14, 1, 37, 889, DateTimeKind.Utc).AddTicks(4886), "Inspiration for travel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InspirationItems");

            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Cities");

            migrationBuilder.CreateTable(
                name: "ServiceItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "874e2e3b-58ab-40d5-b8bf-8b018b8db097");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d40f9f3d-3851-4386-869c-254828cb7f5d", "AQAAAAEAACcQAAAAEHTgILgAlVytMUKBjpS7QRBvj2RyXN7NnZWZQGFAbO8EQwhhKcrA7CrVLT5YtFNE6w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2021, 3, 17, 20, 30, 20, 923, DateTimeKind.Utc).AddTicks(2192), "Контакты" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2021, 3, 17, 20, 30, 20, 923, DateTimeKind.Utc).AddTicks(388), "Главная" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "CodeWord", "DateAdded", "Title" },
                values: new object[] { "PageServices", new DateTime(2021, 3, 17, 20, 30, 20, 923, DateTimeKind.Utc).AddTicks(2136), "Наши услуги" });
        }
    }
}
