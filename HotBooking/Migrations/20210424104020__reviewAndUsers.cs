using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBooking.Migrations
{
    public partial class _reviewAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "7834a46a-c90e-41fb-ad08-6c740dce8e3d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58f9aaed-20c9-417e-a8c2-4b4d15431631", "AQAAAAEAACcQAAAAEKStTNC4op8MJlnsilYgKWiOHCLBllzsMhGcLsvoJinhMbKz/g7wKuayfY+UYVoR/w==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(2958));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "28ce9ffd-f9d1-4674-9d32-8897579c103e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9f3c667-22f9-4de8-b8e0-8532392b27c9", "AQAAAAEAACcQAAAAEGWeqpKeP4vCMRVZAwqFL3/Wi1UEzkcs5YzLUhcpFwkAK4POdFqmfnVtewdAL46nKg==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 23, 14, 4, 13, 30, DateTimeKind.Utc).AddTicks(2665));
        }
    }
}
