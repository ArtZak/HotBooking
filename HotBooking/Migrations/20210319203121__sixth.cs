using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBooking.Migrations
{
    public partial class _sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4513), "images/favoriteCities/yerevan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4681), "images/favoriteCities/london.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3620), "images/favoriteCities/dilijan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4779), "images/favoriteCities/dubai.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4737), "images/favoriteCities/san-francisco.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4757), "images/favoriteCities/venice.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4714), "images/favoriteCities/budapesht.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4558), "images/favoriteCities/sevan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4536), "images/favoriteCities/jermuk.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4582), "images/favoriteCities/caxkadzor.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4655), "images/favoriteCities/paris.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(4463), "images/favoriteCities/goris.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(2998), "images/countries/russia.jpg" });

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
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3040), "images/countries/canada.jpg" });

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
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3061), "images/countries/armenia.jpg" });

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
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(2957), "images/countries/spain.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(1271), "images/countries/germany.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 31, 21, 6, DateTimeKind.Utc).AddTicks(3019), "images/countries/brazil.jpg" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5a5e670f-1640-42c1-b80c-f48ef9c21a73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3f7a8be-0304-4722-84dd-6eb8d2d79893", "AQAAAAEAACcQAAAAEAiMr7jPKozQJC+t0zx+vwGfuZrq5VUVgDTD1Y9FQdgi9tqKYqDgWfOEZqftRGp64A==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(894), "~/images/favoriteCities/yerevan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(995), "~/images/favoriteCities/london.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9941), "~/images/favoriteCities/dilijan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(1072), "~/images/favoriteCities/dubai.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(1035), "~/images/favoriteCities/san-francisco.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(1053), "~/images/favoriteCities/venice.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(1014), "~/images/favoriteCities/budapesht.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(935), "~/images/favoriteCities/sevan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(915), "~/images/favoriteCities/jermuk.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(957), "~/images/favoriteCities/caxkadzor.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(976), "~/images/favoriteCities/paris.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 110, DateTimeKind.Utc).AddTicks(844), "~/images/favoriteCities/goris.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9306), "~/images/countries/russia.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9345), "~/images/countries/canada.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9365), "~/images/countries/armenia.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9268), "~/images/countries/spain.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(7553), "~/images/countries/germany.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(9326), "~/images/countries/brazil.jpg" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 19, 20, 20, 45, 109, DateTimeKind.Utc).AddTicks(7002));
        }
    }
}
