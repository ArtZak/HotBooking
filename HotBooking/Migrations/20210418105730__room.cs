using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBooking.Migrations
{
    public partial class _room : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "0822527b-71e0-4918-af52-fcddfe932b2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1235f54-a232-4fc8-88ab-9836da1a6e6b", "AQAAAAEAACcQAAAAEKvlEseNop7hrc7LZzR1LYFmteKOmVx73oojqyWSVBJ5eAnvXJtFL0BDWSHwc/f/aA==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 573, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 10, 57, 29, 572, DateTimeKind.Utc).AddTicks(6546));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "3d527918-605c-4278-95ec-d3379942500a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1263356-ebe3-491a-baa3-6650ddeba75c", "AQAAAAEAACcQAAAAEEbU3NS0mVx5InGVGuqimEVFEwEyI4g2myWnBUrjJiBvnfPB2Pv1WlwZ/AekyZt/GQ==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 18, 9, 58, 32, 512, DateTimeKind.Utc).AddTicks(5752));
        }
    }
}
