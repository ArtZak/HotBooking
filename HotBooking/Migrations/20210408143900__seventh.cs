using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBooking.Migrations
{
    public partial class _seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c85b72a1-7a63-4e35-adf6-1a8be201847d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e11b95d0-5693-4c1f-88cd-4d3905a3876f", "AQAAAAEAACcQAAAAEEXHcGll3oVko2ll6umqFIa8MXjEv7eRM79iuOrj0vcm1ZO8MTkLndJcINykg2bZdQ==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 313, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 314, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 313, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 313, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 8, 14, 39, 0, 313, DateTimeKind.Utc).AddTicks(8462));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c29d2f29-fa29-4e94-8496-9087bae30aaa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d15b77b2-efdb-4fa1-bdc7-0e45060e613c", "AQAAAAEAACcQAAAAEBekR24QrQN5mMPUs8VRn+rfiyezD3hx1yNRz0P5Zf4L4CJ3EsJpz2GuKDAkK2g/eQ==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 5, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(699));
        }
    }
}
