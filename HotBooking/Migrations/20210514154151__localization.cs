using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotBooking.Migrations
{
    public partial class _localization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TextFields",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "TextFields",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "TextFields",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Rooms",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Rooms",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "Rooms",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "RoomFacilities",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "RoomFacilities",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "RoomFacilities",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "InspirationItems",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "InspirationItems",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "InspirationItems",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Hotels",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Hotels",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "Hotels",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "HotelFacilities",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "HotelFacilities",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "HotelFacilities",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Countries",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Countries",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "Countries",
                newName: "TextEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Cities",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Cities",
                newName: "TitleArm");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "Cities",
                newName: "TextEn");

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "RoomFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "RoomFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "RoomFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "InspirationItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "InspirationItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "InspirationItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "HotelFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "HotelFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "HotelFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleArm",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleEn",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextArm",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "deb7ce98-d15f-4564-bef8-dd45bb767ee7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa32fd0f-a896-41af-9fd4-207793d88ab8", "AQAAAAEAACcQAAAAEH8w4Y5PrQLOhat53kFp7Mu+FT8Q17FcnHyRBbwIHCZLId9p4YT/TPWnaGOzOeaB5w==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c04f6ca-c936-4d71-8937-f7cd772df28e"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(3877), "It is called “a Pink City” but don’t expect it to take your breath away or fall in love with it from the very first sight.", "Yerevan is the capital and largest city of Armenia and one of the world's oldest continuously inhabited cities. Situated along the Hrazdan River, Yerevan is the administrative, cultural, and industrial center of the country. It has been the capital since 1918, the thirteenth in the history of Armenia. The total area of the 12 districts of Yerevan is 227 square kilometres (88 square miles).", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4051), "The Medieval Goris Cave Dwellings were inhabited by locals until the mid-twentieth century.", "Goris is a town in the north-eastern part of the Syunik province, in the south of Armenia. Goris is located on the intersection of Yerevan-Artsakh and Yerevan-Meghri-Iran interstate highways. Located in the valley of the river Goris (Vararakn) it is 235 km away from the Armenia capital Yerevan and 67 km from the regional center Kapan. The town has an average elevation of 1398 metres above sea level.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2955), "Steeped in history, home to incredible hospitality and buzzing with new initiatives, Dilijan is known as Armenia's Switzerland.", "Dilijan is one of the most important and beautiful towns in Tavush region. It is located on the banks of Aghstev River and is surrounded by mountains covered with thick forests. It is a major resort town of Armenia. Dilijan National Park is a beautiful place rich with natural and cultural monuments and healing mineral water. There are nearly 20 mineral water springs in the area of the city.The picturesque Parz Lake is located within the Dilijan National Park.The word “parz” means “clear” in Armenian. The water of the lake reflects the sky and the surrounding forest making a fascinating view. Not too far from the Parz lake is the ancient Monastery of Haghartsin(10 - 13th centuries); one of the most popular monasteries in Armenia.The monastery includes three churches: St.Astvatsatsin(1281), St.Gregory(1244), St.Stepanos(1232), as well as two courtyards, refectory, prayer halls and khachkars(cross-stones). The Monastery is also located within the thick forests of Dilijan National Park. Goshavank is another legendary Monastery in the Tavush Region.Goshavank is a medieval monastery complex of 12 - 13th centuries located in the village of Gosh at the left bank of Getik River.The Monastery is named after the famous Armenian scientist, historian, parable writer, and teacher Mkhitar Gosh, who lived and worked in this monastery. There are some other small churches in Dilijan as well, such as Jukhtak Vank and Matosavank. The town of Dilijan is itself very interesting.The relief of the town is mountainous covered with forests and gardens. It has preserved its unique style of traditional Armenian architecture. The view of old small houses embracing nature is really splendid. Armenians call Dilijan “Our small Switzerland”. This small town has many hotels, resort houses, and sanatoriums of the highest standards. The restaurants are famous for their delicious food and good service. The town is also home to the United World College Dilijan which is the 14th member of the United World Colleges movement, one of eighteen colleges around the world.It has been operating in Dilijan since 2014.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4139), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4096), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4117), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4073), "It is called “a Pink City” but don’t expect it to take your breath away or fall in love with it from the very first sight.", "Yerevan is the capital and largest city of Armenia and one of the world's oldest continuously inhabited cities. Situated along the Hrazdan River, Yerevan is the administrative, cultural, and industrial center of the country. It has been the capital since 1918, the thirteenth in the history of Armenia. The total area of the 12 districts of Yerevan is 227 square kilometres (88 square miles).", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(3924), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(3902), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4003), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(4030), "Steeped in history, home to incredible hospitality and buzzing with new initiatives, Dilijan is known as Armenia's Switzerland.", "Dilijan is one of the most important and beautiful towns in Tavush region. It is located on the banks of Aghstev River and is surrounded by mountains covered with thick forests. It is a major resort town of Armenia. Dilijan National Park is a beautiful place rich with natural and cultural monuments and healing mineral water. There are nearly 20 mineral water springs in the area of the city.The picturesque Parz Lake is located within the Dilijan National Park.The word “parz” means “clear” in Armenian. The water of the lake reflects the sky and the surrounding forest making a fascinating view. Not too far from the Parz lake is the ancient Monastery of Haghartsin(10 - 13th centuries); one of the most popular monasteries in Armenia.The monastery includes three churches: St.Astvatsatsin(1281), St.Gregory(1244), St.Stepanos(1232), as well as two courtyards, refectory, prayer halls and khachkars(cross-stones). The Monastery is also located within the thick forests of Dilijan National Park. Goshavank is another legendary Monastery in the Tavush Region.Goshavank is a medieval monastery complex of 12 - 13th centuries located in the village of Gosh at the left bank of Getik River.The Monastery is named after the famous Armenian scientist, historian, parable writer, and teacher Mkhitar Gosh, who lived and worked in this monastery. There are some other small churches in Dilijan as well, such as Jukhtak Vank and Matosavank. The town of Dilijan is itself very interesting.The relief of the town is mountainous covered with forests and gardens. It has preserved its unique style of traditional Armenian architecture. The view of old small houses embracing nature is really splendid. Armenians call Dilijan “Our small Switzerland”. This small town has many hotels, resort houses, and sanatoriums of the highest standards. The restaurants are famous for their delicious food and good service. The town is also home to the United World College Dilijan which is the 14th member of the United World Colleges movement, one of eighteen colleges around the world.It has been operating in Dilijan since 2014.", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                columns: new[] { "DateAdded", "SubtitleEn", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(3828), "The Medieval Goris Cave Dwellings were inhabited by locals until the mid-twentieth century.", "Goris is a town in the north-eastern part of the Syunik province, in the south of Armenia. Goris is located on the intersection of Yerevan-Artsakh and Yerevan-Meghri-Iran interstate highways. Located in the valley of the river Goris (Vararakn) it is 235 km away from the Armenia capital Yerevan and 67 km from the regional center Kapan. The town has an average elevation of 1398 metres above sea level.", null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2313), "Սա առավել անսովոր երկրներից մեկն է, որը ունի անզուգական խորության մշակութային եւ պատմական հարստություններ, ինչպես նաեւ լանդշաֆտներ, որոնք ոգեշնչում են արվեստագետների և բանաստեղծների բազմաթիվ սերունդներ։", "It is one of the most extraordinary countries in the world, with an almost matchless depth of cultural and historical riches, and landscapes that have inspired artists and poets for generations.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Spanning over one-eighth of the planet’s inhabited areas, Russia is a colossal country straddling Eastern Europe and Northern Asia. From the sunken hills of the Urals to the dense forests of Siberia and volcanic terrain of the Far East, its multifaceted landscapes are dotted with culture-rich cities and breathtaking natural sights. Russia’s long and intriguing history is the top draw for most visitors, and this is showcased beautifully in its main cities of Moscow and Saint Petersburg. The former, Russia’s mammoth capital, is home to the iconic Red Square – take a stroll along its black cobblestones and soak up the far-reaching brick walls of the Kremlin, Saint Basil’s Cathedral and Lenin’s Mausoleum. The Hermitage in Saint Petersburg offers a vast collection of treasures, ranging from Roman coins to prehistoric art. Both cities serve up delicious local dishes such piroshki (small pies with various fillings) or national delicacy caviar – best paired with a good vodka. For the intrepid traveller exploring Russia’s wild side, endless adventures await. A ride along the Trans-Siberian Railway is something on many a bucket list. The longest railway route in the world crosses seven time zones and lets you explore the dramatic scenery of Siberia. At the outer limits of the Far East, the acid lakes, volcanoes and Valley of the Geysers feature along the 1,250 km-long peninsula of Kamchatka. Russia’s accommodation choices are as wide as its geography, with hordes of hotels, hostels, apartments and guest houses scattered all over. For outdoor lovers, holiday camps (known as turbazy) and rural spas (sanatory) are also common.", "Ռուսաստան" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2487), "Եթե մտքի խաղաղությունը, հին քաղաքը եւ սնունդը ձեզ համար են, դուք կկարոտեք Իսպանիան!", "The expanse of Canada's natural beauty, from mountains and glaciers to secluded lakes and forests, is almost unparalleled worldwide.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Canada is renowned for its endless variety of landscapes. Soaring mountains, lush pine forests and windswept beaches are all here, spread across seven regions. You might be tempted to head straight to the wilderness, but consider seeing the sights Toronto and other great cities have to offer before you do. There’s the skyscraping CN Tower in the capital, the beautiful botanical gardens of Montreal, and Vancouver’s Stanley Park makes for an unforgettable stroll in spring or summer. Bordering the USA, there’s Niagara Falls, the roaring crossroads of waterfalls that Canada is so well known for. Further north, Banff National Park promises a world of adventure, no matter the season. Come in summer and be rewarded with picturesque views of emerald lakes backed by glinting glaciers, and sightings of grizzly bears, wolves and moose roaming through the forest. Or choose winter, when the snow-covered Rockies become an adventure playground. You can stay in Banff, where there is a choice of three ski resorts, or head down to Whistler, the country’s prime resort, famed for its staggering peak-to-peak gondola. Alternatively, surf the swells of Nova Scotia or wander the stunning fortifications of Old Québec – there’s always an adventure waiting around every corner. Homely apartments and cozy lodges are available to rent throughout the country, but you'll also find a good choice of luxury hotels and budget-friendly hostels.", "Միացյալ Էմիրություններ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2424), "Եթե մտքի խաղաղությունը, հին քաղաքը եւ սնունդը ձեզ համար են, դուք կկարոտեք Իսպանիան!", "If tranquillity, old town and food are for you, don’t miss out on Spain!", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Wild landscapes and walled cities, rugged mountains and rolling olive groves, whitewashed villages and bright blue ocean fronts. Spain is a lot more than 'sun, sea, sand and sangria' – a stereotype that could not be further from the truth. This country is as multi-layered as its history, with a compelling, richly influenced culture. From the pre-Romanesque ruins of northern Asturias, to Segovia’s fully intact Roman aqueduct, southern Andalucia’s majestic Moorish palaces and countless monumental cathedrals built by the all-conquering Christians, every civilisation has left its mark. The cosmopolitan capital, Madrid, buzzes with energy, while the extraordinary architecture of Barcelona justifies a visit to the Iberian Peninsula all on its own. You'll be in awe as you gaze up at the intricately carved ceilings of Antoni Gaudí’s magnificent Sagrada Família. And to experience Spain’s infinite adventure playground, go hiking, skiing, climbing or kayaking in mountain ranges like The Pyrenees, Sierra Nevada and Picos de Europa. But Spain is not just a nirvana for naturalists and history buffs. Sights like Bilbao’s Guggenheim Museum, Valencia’s City of Arts and Sciences and Madrid’s Prado Museum prove it’s also a centre of innovation and cutting-edge art. Two of the world’s most renowned surrealist artists also hail from Spain – you can visit Salvador Dali’s self-designed museum in his hometown of Figueres in Catalonia, as well as Pablo Picasso’s birthplace in Málaga, Andalucia. But, lest we forget, Spain is also home to some of Europe’s finest white-sand beaches, which draw the bulk of visitors to its sun-kissed coastlines. Join the masses on the Costa del Sol, or strike out to the virtually undeveloped Costa de Almeria, where pristine, often empty stretches abound. Spain offers practically every kind of accommodation imaginable, from high-end hotels and luxury villas, to friendly B&Bs, cheap hostels and remote eco-lodges.", "Իտալիա" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2356), "Կանադայի բնական գեղեցկությունը, լեռներից եւ սառցադաշտերից մինչեւ մեկուսի լճեր եւ անտառներ, չունի նմանը ամբողջ աշխարհում:", "The expanse of Canada's natural beauty, from mountains and glaciers to secluded lakes and forests, is almost unparalleled worldwide.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Canada is renowned for its endless variety of landscapes. Soaring mountains, lush pine forests and windswept beaches are all here, spread across seven regions. You might be tempted to head straight to the wilderness, but consider seeing the sights Toronto and other great cities have to offer before you do. There’s the skyscraping CN Tower in the capital, the beautiful botanical gardens of Montreal, and Vancouver’s Stanley Park makes for an unforgettable stroll in spring or summer. Bordering the USA, there’s Niagara Falls, the roaring crossroads of waterfalls that Canada is so well known for. Further north, Banff National Park promises a world of adventure, no matter the season. Come in summer and be rewarded with picturesque views of emerald lakes backed by glinting glaciers, and sightings of grizzly bears, wolves and moose roaming through the forest. Or choose winter, when the snow-covered Rockies become an adventure playground. You can stay in Banff, where there is a choice of three ski resorts, or head down to Whistler, the country’s prime resort, famed for its staggering peak-to-peak gondola. Alternatively, surf the swells of Nova Scotia or wander the stunning fortifications of Old Québec – there’s always an adventure waiting around every corner. Homely apartments and cozy lodges are available to rent throughout the country, but you'll also find a good choice of luxury hotels and budget-friendly hostels.", "Կանադա" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2467), "Եթե մտքի խաղաղությունը, հին քաղաքը եւ սնունդը ձեզ համար են, դուք կկարոտեք Իսպանիան!", "Hearty food, chaotic streets, and pretty sceneries are some of the reasons to visit Brazil.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "With an enormous land area comes great diversity, and Brazil provides stone-cold – or rather red-hot – proof. Spanning roughly 8.5 million km², its sun-drenched landscapes range from hectic cities to hip surfer towns, powdery white-sand beaches and wild rainforest. Rio de Janeiro is understandably the focus of most traveller itineraries. Wander the lively streets of Santa Teresa, watch the locals play football on Copacabana beach, ascend Sugarloaf Mountain to stand at the feet of Christ the Redeemer, and take in the stunning panoramic views. Later, head to the lively Lapa neighbourhood for a taste of the samba-fuelled nightlife, and dance the night away amidst the locals, affectionately known as ‘cariocas’. After the fast pace of Rio, you may want to recharge. Ilha Grande – a verdant island peppered with unspoiled beaches – is just a couple of hours away, while surfing havens like southerly Florianópolis and Itacaré to the north require a day’s worth of travel. With so many different environments in this huge country, there are all kinds of accommodation available, from luxury villas and beachside hotels, to funky hostels and jungle-immersed cabin lodges. Where you stay depends on the adventure you’re looking for.", "Հունգարիա" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2445), "Եթե մտքի խաղաղությունը, հին քաղաքը եւ սնունդը ձեզ համար են, դուք կկարոտեք Իսպանիան!", "It is one of the most extraordinary countries in the world, with an almost matchless depth of cultural and historical riches, and landscapes that have inspired artists and poets for generations.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Spanning over one-eighth of the planet’s inhabited areas, Russia is a colossal country straddling Eastern Europe and Northern Asia. From the sunken hills of the Urals to the dense forests of Siberia and volcanic terrain of the Far East, its multifaceted landscapes are dotted with culture-rich cities and breathtaking natural sights. Russia’s long and intriguing history is the top draw for most visitors, and this is showcased beautifully in its main cities of Moscow and Saint Petersburg. The former, Russia’s mammoth capital, is home to the iconic Red Square – take a stroll along its black cobblestones and soak up the far-reaching brick walls of the Kremlin, Saint Basil’s Cathedral and Lenin’s Mausoleum. The Hermitage in Saint Petersburg offers a vast collection of treasures, ranging from Roman coins to prehistoric art. Both cities serve up delicious local dishes such piroshki (small pies with various fillings) or national delicacy caviar – best paired with a good vodka. For the intrepid traveller exploring Russia’s wild side, endless adventures await. A ride along the Trans-Siberian Railway is something on many a bucket list. The longest railway route in the world crosses seven time zones and lets you explore the dramatic scenery of Siberia. At the outer limits of the Far East, the acid lakes, volcanoes and Valley of the Geysers feature along the 1,250 km-long peninsula of Kamchatka. Russia’s accommodation choices are as wide as its geography, with hordes of hotels, hostels, apartments and guest houses scattered all over. For outdoor lovers, holiday camps (known as turbazy) and rural spas (sanatory) are also common.", "Անգլիա" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2384), "Հայաստանը սխալմամբ անտեսվել է որպես զբոսաշրջիկների համար նախատեսված վայր, բայց եթե դուք այցելեք, դուք կգտնեք հարուստ մշակութային ժառանգություն, որտեղ առատորեն գտնվում են հնագույն տեսարժան վայրերը եւ համեղ կերակուրը:", "Armenia has wrongly been overlooked as a go-to destination for tourists, but if you visit, you will find a rich cultural heritage where ancient sights and delicious food abound.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Straddling Europe and Asia, Armenia has an ancient and complex history showcased by its stunning ruins and monuments. Medieval monasteries are dotted all over the country, surrounded by breathtaking mountains and fast-flowing rivers. The country’s rugged landscape makes it perfect for sports like rocking climbing, skiing and hiking. Head to the coast and you can try your hand at windsurfing and soak up some rays on the beaches of the Lake Sevan region. To explore the best offerings of museums and other cultural spots, venture into the capital city of Yerevan. Timeworn teahouses brush up against trendy shops and wine bars in this age-old town, and its Republic Square plays host to the famous singing fountains, as well as the National Art Gallery and History Museum of Armenia. Outside of Yerevan, you can explore some of the religious buildings constructed almost 2,000 years ago, including the Etchmiadzin Monastery, a World Heritage Site. Armenia has a wide selection of friendly B&Bs which give a true sense of the local culture. A variety of hotels, hostels and cottages can be found around Yerevan, Lake Sevan and Tzaghkadzor – a popular winter retreat.", "Հայաստան" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2404), "Ֆրանսիան հայտնի տուրիստական ուղղություն է նրանց համար, ովքեր փնտրում են ռոմանտիկ վայր, ծանոթություն նոր մարդկանց հետ կամ պարզապես հանգիստ լողափում:", "France is a popular tourist destination, especially for those who are looking for a romantic location, a place to explore and meet new people, or even just to relax on a beach.", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", "Ֆրանսիա" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2270), "Եթե մտքի խաղաղությունը, հին քաղաքը եւ սնունդը ձեզ համար են, դուք կկարոտեք Իսպանիան!", "If tranquillity, old town and food are for you, don’t miss out on Spain!", "Վայրի լանդշաֆտները եւ քաղաքի պատերին փաթաթված, ժայռոտ լեռներ եւ լեռնոտ ձիթապտղի պուրակներ, սպիտակեցված գյուղեր եւ վառ կապույտ օվկիանոսային ափեր: Իսպանիան շատ ավելին է, քան\" արեւը,ծովը,ավազը եւ սանգրիան\", ստերեոտիպը, որը չի կարող հեռու լինել ճշմարտությունից: Այս երկիրը նույնքան բազմաշերտ է, որքան նրա պատմությունը ՝ անդիմադրելի, հարուստ մշակույթով ։ Հյուսիսային Աստուրիայի նախածննդյան ավերակներից մինչև ամբողջովին անձեռնմխելի հռոմեական ջրանցույց Սեգովիա, Հարավային Անդալուսիայի վեհաշուք Մավրիտանական պալատներ և անհամար մոնումենտալ տաճարներ, որոնք կառուցվել են ամենազոր քրիստոնյաների կողմից, յուրաքանչյուր քաղաքակրթություն իր հետքն է թողել ։ Կոսմոպոլիտ մայրաքաղաք Մադրիդը եռում է էներգիայով, իսկ Բարսելոնայի արտասովոր ճարտարապետությունն ինքնին արդարացնում է Պիրենեյան թերակղզի այցելությունը: Դուք պետք է ոգեւորված նայում բարդ փորագրված առաստաղներ հոյակապ տաճարի Սուրբ Ընտանիքի Antoni Gaudi. Եվ զգալ անվերջ խաղահրապարակ արկածային Իսպանիայում, գնալ Արշավային, Դահուկներ, զբաղվել բարձրանում կամ kayaking է լեռնաշղթաների, ինչպիսիք են Պիրենեյան, Sierra Nevada եւ Picos de Europe. Բայց Իսպանիան պարզապես Նիրվանա չէ բնագետների եւ պատմության սիրահարների համար: Տեսարժան վայրերը, ինչպիսիք են Guggenheim թանգարան Բիլբաո քաղաքում, քաղաքի արվեստի եւ գիտությունների Վալենսիայի եւ Museo del Prado Մադրիդում, վկայում են, որ այն նաեւ կենտրոնը նորարարության եւ առաջադեմ արվեստի. Աշխարհի ամենահայտնի սյուրռեալիստ նկարիչը նաեւ ծագումով Իսպանիայից է, Դուք կարող եք այցելել Սալվադոր Դալիի թանգարան, իր հայրենի Ֆիգերաս քաղաքում, Կատալոնիայում, ինչպես նաեւ Պաբլո Պիկասոյի Ծննդյան վայրը Մալագայում, Անդալուսիայում:", "Wild landscapes and walled cities, rugged mountains and rolling olive groves, whitewashed villages and bright blue ocean fronts. Spain is a lot more than 'sun, sea, sand and sangria' – a stereotype that could not be further from the truth. This country is as multi-layered as its history, with a compelling, richly influenced culture. From the pre-Romanesque ruins of northern Asturias, to Segovia’s fully intact Roman aqueduct, southern Andalucia’s majestic Moorish palaces and countless monumental cathedrals built by the all-conquering Christians, every civilisation has left its mark. The cosmopolitan capital, Madrid, buzzes with energy, while the extraordinary architecture of Barcelona justifies a visit to the Iberian Peninsula all on its own. You'll be in awe as you gaze up at the intricately carved ceilings of Antoni Gaudí’s magnificent Sagrada Família. And to experience Spain’s infinite adventure playground, go hiking, skiing, climbing or kayaking in mountain ranges like The Pyrenees, Sierra Nevada and Picos de Europa. But Spain is not just a nirvana for naturalists and history buffs. Sights like Bilbao’s Guggenheim Museum, Valencia’s City of Arts and Sciences and Madrid’s Prado Museum prove it’s also a centre of innovation and cutting-edge art. Two of the world’s most renowned surrealist artists also hail from Spain – you can visit Salvador Dali’s self-designed museum in his hometown of Figueres in Catalonia, as well as Pablo Picasso’s birthplace in Málaga, Andalucia. But, lest we forget, Spain is also home to some of Europe’s finest white-sand beaches, which draw the bulk of visitors to its sun-kissed coastlines. Join the masses on the Costa del Sol, or strike out to the virtually undeveloped Costa de Almeria, where pristine, often empty stretches abound. Spain offers practically every kind of accommodation imaginable, from high-end hotels and luxury villas, to friendly B&Bs, cheap hostels and remote eco-lodges.", "Իսպանիա" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 524, DateTimeKind.Utc).AddTicks(9701), "Վայելեք ձեր հանգիստը, ռեստորանները եւ գնումները Միացյալ Նահանգներ ձեր հաջորդ ուղևորության ընթացքում:", "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Նույնիսկ եթե դուք երբևէ չեք եղել Միացյալ Նահանգներում, երկրի տեսարժան վայրերը ներկայացման կարիք չունեն։ Ազատության արձանից մինչև Մեծ կիրճ, դա Ծանոթություն է անվերջ ֆիլմերի և հեռուստաշոուների, ինչպես նաև համաշխարհային գերտերության դերի հետ ։ Դրա հսկայական չափը նշանակում է, որ այստեղ կա հիանալի կոկտեյլ տեսարժան վայրերից, հնչյուններից և մշակաբույսերից, որոնք կարելի է ուսումնասիրել: Ամերիկան կարող է համեմատաբար երիտասարդ երկիր է, բայց նա գիտի, թե ինչպես պետք է կառուցել անմոռանալի քաղաքներ. Արևելյան ափին նայեք Նյու Յորքի հայտնի երկնաքերներին եւ Բոստոնում Օմար ուտեք: Արևմտյան ափին զբոսեք Սան Ֆրանցիսկոյի խենթ ոլորուն փողոցներում և այցելեք Լոս Անջելեսի իրական Լա Լենդը: Գտնվելով երկրի խորքում ՝ այցելում են շողշողացող Լաս Վեգաս։ Յուրաքանչյուր աշխարհահռչակ քաղաքում դուք կարող եք գտնել մեկ այլ Ամերիկա։ Բացի այդ, կան breathtaking, էպիկական հեռանկարները. Անհամար. Կա մի պատճառ, որ ճանապարհային ուղեւորություններ այնքան գրավիչ.", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you.", "ԱՄՆ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                columns: new[] { "DateAdded", "SubtitleArm", "SubtitleEn", "TextArm", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 525, DateTimeKind.Utc).AddTicks(2335), "Hearty food, chaotic streets, and pretty sceneries are some of the reasons to visit Brazil.", "Սննդարար սնունդ, քաոսային փողոցներ եւ գեղեցիկ տեսարան-Ահա որոշ պատճառներ այցելել Բրազիլիա։", "Զբաղեցնելով մոլորակի ավելի քան մեկ ութերորդ բնակավայրը ՝ Ռուսաստանը հսկայական երկիր է, որն ընդգրկում է Արևելյան Եվրոպան և Հյուսիսային Ասիան ։ Ուրալի ջրասույզ բլուրներից մինչև Սիբիրի խիտ անտառները և Հեռավոր Արևելքի հրաբխային տեղանքը, նրա բազմաբովանդակ լանդշաֆտները հարթված են մշակույթով հարուստ քաղաքներով և շունչ հաղորդող բնական տեսարժան վայրերով ։ Ռուսաստանի երկար ու հետաքրքիր պատմությունը գրավում է այցելուների մեծամասնության ուշադրությունը, եւ դա հիանալի ցուցադրվում է նրա գլխավոր քաղաքներում ՝ Մոսկվայում եւ Սանկտ Պետերբուրգում: Ռուսաստանի նախկին վիթխարի մայրաքաղաքում է գտնվում հայտնի Կարմիր հրապարակը – զբոսնել նրա սեւ սալիկի վրա եւ հիանալ Կրեմլի, Վասիլի Երանելու տաճարի եւ Լենինի դամբարանի աղյուսե պատերով: Էրմիտաժը Սանկտ Պետերբուրգում առաջարկում է մեծ հավաքածու գանձերի, սկսած հռոմեական մետաղադրամների եւ վերջացրած նախապատմական արվեստի. Երկու քաղաքներում մատուցվում են համեղ տեղական ճաշատեսակներ, ինչպիսիք են կարկանդակները (տարբեր լցոնումներով փոքր Կարկանդակներ) կամ ազգային նրբահամ ձկնկիթը, Լավագույնն այն է, որ ընտրել Զուգտկված լավ օղիով: Ռուսաստանի վայրի կողմը հետազոտող անվախ ճանապարհորդին սպասում են անվերջ արկածներ։ Անդրսիբիրյան մայրուղիով ուղևորությունը մի բան է, որ կան բազմաթիվ ցուցակներում ։ ", "With an enormous land area comes great diversity, and Brazil provides stone-cold – or rather red-hot – proof. Spanning roughly 8.5 million km², its sun-drenched landscapes range from hectic cities to hip surfer towns, powdery white-sand beaches and wild rainforest. Rio de Janeiro is understandably the focus of most traveller itineraries. Wander the lively streets of Santa Teresa, watch the locals play football on Copacabana beach, ascend Sugarloaf Mountain to stand at the feet of Christ the Redeemer, and take in the stunning panoramic views. Later, head to the lively Lapa neighbourhood for a taste of the samba-fuelled nightlife, and dance the night away amidst the locals, affectionately known as ‘cariocas’. After the fast pace of Rio, you may want to recharge. Ilha Grande – a verdant island peppered with unspoiled beaches – is just a couple of hours away, while surfing havens like southerly Florianópolis and Itacaré to the north require a day’s worth of travel. With so many different environments in this huge country, there are all kinds of accommodation available, from luxury villas and beachside hotels, to funky hostels and jungle-immersed cabin lodges. Where you stay depends on the adventure you’re looking for.", "Բրազիլիա" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 524, DateTimeKind.Utc).AddTicks(9205), "Содержание заполняется администратором", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 524, DateTimeKind.Utc).AddTicks(7408), "Содержание заполняется администратором", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "TextEn", "TitleArm" },
                values: new object[] { new DateTime(2021, 5, 14, 15, 41, 50, 524, DateTimeKind.Utc).AddTicks(9114), "Содержание заполняется администратором", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "RoomFacilities");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "RoomFacilities");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "RoomFacilities");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "InspirationItems");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "InspirationItems");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "InspirationItems");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "HotelFacilities");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "HotelFacilities");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "HotelFacilities");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "SubtitleArm",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "SubtitleEn",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "TextArm",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "TextFields",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "TextFields",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "TextFields",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Rooms",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "Rooms",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "Rooms",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "RoomFacilities",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "RoomFacilities",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "RoomFacilities",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "InspirationItems",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "InspirationItems",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "InspirationItems",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Hotels",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "Hotels",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "Hotels",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "HotelFacilities",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "HotelFacilities",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "HotelFacilities",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Countries",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "Countries",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "Countries",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Cities",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "Cities",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextEn",
                table: "Cities",
                newName: "Subtitle");

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
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7021), "It is called “a Pink City” but don’t expect it to take your breath away or fall in love with it from the very first sight.", "Yerevan is the capital and largest city of Armenia and one of the world's oldest continuously inhabited cities. Situated along the Hrazdan River, Yerevan is the administrative, cultural, and industrial center of the country. It has been the capital since 1918, the thirteenth in the history of Armenia. The total area of the 12 districts of Yerevan is 227 square kilometres (88 square miles)." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("148182c4-a064-479b-b043-9d490f06f233"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7117), "The Medieval Goris Cave Dwellings were inhabited by locals until the mid-twentieth century.", "Goris is a town in the north-eastern part of the Syunik province, in the south of Armenia. Goris is located on the intersection of Yerevan-Artsakh and Yerevan-Meghri-Iran interstate highways. Located in the valley of the river Goris (Vararakn) it is 235 km away from the Armenia capital Yerevan and 67 km from the regional center Kapan. The town has an average elevation of 1398 metres above sea level." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("244c1b8e-6146-408c-ba55-51c604d5d2c4"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(6041), "Steeped in history, home to incredible hospitality and buzzing with new initiatives, Dilijan is known as Armenia's Switzerland.", "Dilijan is one of the most important and beautiful towns in Tavush region. It is located on the banks of Aghstev River and is surrounded by mountains covered with thick forests. It is a major resort town of Armenia. Dilijan National Park is a beautiful place rich with natural and cultural monuments and healing mineral water. There are nearly 20 mineral water springs in the area of the city.The picturesque Parz Lake is located within the Dilijan National Park.The word “parz” means “clear” in Armenian. The water of the lake reflects the sky and the surrounding forest making a fascinating view. Not too far from the Parz lake is the ancient Monastery of Haghartsin(10 - 13th centuries); one of the most popular monasteries in Armenia.The monastery includes three churches: St.Astvatsatsin(1281), St.Gregory(1244), St.Stepanos(1232), as well as two courtyards, refectory, prayer halls and khachkars(cross-stones). The Monastery is also located within the thick forests of Dilijan National Park. Goshavank is another legendary Monastery in the Tavush Region.Goshavank is a medieval monastery complex of 12 - 13th centuries located in the village of Gosh at the left bank of Getik River.The Monastery is named after the famous Armenian scientist, historian, parable writer, and teacher Mkhitar Gosh, who lived and worked in this monastery. There are some other small churches in Dilijan as well, such as Jukhtak Vank and Matosavank. The town of Dilijan is itself very interesting.The relief of the town is mountainous covered with forests and gardens. It has preserved its unique style of traditional Armenian architecture. The view of old small houses embracing nature is really splendid. Armenians call Dilijan “Our small Switzerland”. This small town has many hotels, resort houses, and sanatoriums of the highest standards. The restaurants are famous for their delicious food and good service. The town is also home to the United World College Dilijan which is the 14th member of the United World Colleges movement, one of eighteen colleges around the world.It has been operating in Dilijan since 2014." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("441e8562-9884-42a8-8a7f-ab2c2a6a65c5"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7229), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53088e5e-f20f-44ac-a605-4597a1a8f234"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7193), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f50830f-f46b-492b-b600-549d1c73a134"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7210), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9323d16f-534f-407a-ba75-1d17b8ed09d1"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7172), "It is called “a Pink City” but don’t expect it to take your breath away or fall in love with it from the very first sight.", "Yerevan is the capital and largest city of Armenia and one of the world's oldest continuously inhabited cities. Situated along the Hrazdan River, Yerevan is the administrative, cultural, and industrial center of the country. It has been the capital since 1918, the thirteenth in the history of Armenia. The total area of the 12 districts of Yerevan is 227 square kilometres (88 square miles)." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b43ab64a-aed7-4467-8dd8-db63ba4ef02d"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7060), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc8f5c77-208a-4a55-996d-a7cdaafbb539"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7041), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0483c99-2398-4aba-ae0d-2459cd07d92d"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7080), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fad02518-7e13-4887-a3a0-774973ab4197"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(7099), "Steeped in history, home to incredible hospitality and buzzing with new initiatives, Dilijan is known as Armenia's Switzerland.", "Dilijan is one of the most important and beautiful towns in Tavush region. It is located on the banks of Aghstev River and is surrounded by mountains covered with thick forests. It is a major resort town of Armenia. Dilijan National Park is a beautiful place rich with natural and cultural monuments and healing mineral water. There are nearly 20 mineral water springs in the area of the city.The picturesque Parz Lake is located within the Dilijan National Park.The word “parz” means “clear” in Armenian. The water of the lake reflects the sky and the surrounding forest making a fascinating view. Not too far from the Parz lake is the ancient Monastery of Haghartsin(10 - 13th centuries); one of the most popular monasteries in Armenia.The monastery includes three churches: St.Astvatsatsin(1281), St.Gregory(1244), St.Stepanos(1232), as well as two courtyards, refectory, prayer halls and khachkars(cross-stones). The Monastery is also located within the thick forests of Dilijan National Park. Goshavank is another legendary Monastery in the Tavush Region.Goshavank is a medieval monastery complex of 12 - 13th centuries located in the village of Gosh at the left bank of Getik River.The Monastery is named after the famous Armenian scientist, historian, parable writer, and teacher Mkhitar Gosh, who lived and worked in this monastery. There are some other small churches in Dilijan as well, such as Jukhtak Vank and Matosavank. The town of Dilijan is itself very interesting.The relief of the town is mountainous covered with forests and gardens. It has preserved its unique style of traditional Armenian architecture. The view of old small houses embracing nature is really splendid. Armenians call Dilijan “Our small Switzerland”. This small town has many hotels, resort houses, and sanatoriums of the highest standards. The restaurants are famous for their delicious food and good service. The town is also home to the United World College Dilijan which is the 14th member of the United World Colleges movement, one of eighteen colleges around the world.It has been operating in Dilijan since 2014." });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb66f105-b793-4a1a-9008-c1aba0d85fae"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(6971), "The Medieval Goris Cave Dwellings were inhabited by locals until the mid-twentieth century.", "Goris is a town in the north-eastern part of the Syunik province, in the south of Armenia. Goris is located on the intersection of Yerevan-Artsakh and Yerevan-Meghri-Iran interstate highways. Located in the valley of the river Goris (Vararakn) it is 235 km away from the Armenia capital Yerevan and 67 km from the regional center Kapan. The town has an average elevation of 1398 metres above sea level." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3007d4df-8469-49cb-b622-73abf34da587"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5398), "It is one of the most extraordinary countries in the world, with an almost matchless depth of cultural and historical riches, and landscapes that have inspired artists and poets for generations.", "Spanning over one-eighth of the planet’s inhabited areas, Russia is a colossal country straddling Eastern Europe and Northern Asia. From the sunken hills of the Urals to the dense forests of Siberia and volcanic terrain of the Far East, its multifaceted landscapes are dotted with culture-rich cities and breathtaking natural sights. Russia’s long and intriguing history is the top draw for most visitors, and this is showcased beautifully in its main cities of Moscow and Saint Petersburg. The former, Russia’s mammoth capital, is home to the iconic Red Square – take a stroll along its black cobblestones and soak up the far-reaching brick walls of the Kremlin, Saint Basil’s Cathedral and Lenin’s Mausoleum. The Hermitage in Saint Petersburg offers a vast collection of treasures, ranging from Roman coins to prehistoric art. Both cities serve up delicious local dishes such piroshki (small pies with various fillings) or national delicacy caviar – best paired with a good vodka. For the intrepid traveller exploring Russia’s wild side, endless adventures await. A ride along the Trans-Siberian Railway is something on many a bucket list. The longest railway route in the world crosses seven time zones and lets you explore the dramatic scenery of Siberia. At the outer limits of the Far East, the acid lakes, volcanoes and Valley of the Geysers feature along the 1,250 km-long peninsula of Kamchatka. Russia’s accommodation choices are as wide as its geography, with hordes of hotels, hostels, apartments and guest houses scattered all over. For outdoor lovers, holiday camps (known as turbazy) and rural spas (sanatory) are also common." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5056d1f2-02be-4751-981b-59be0b1e3f0d"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5548), "The expanse of Canada's natural beauty, from mountains and glaciers to secluded lakes and forests, is almost unparalleled worldwide.", "Canada is renowned for its endless variety of landscapes. Soaring mountains, lush pine forests and windswept beaches are all here, spread across seven regions. You might be tempted to head straight to the wilderness, but consider seeing the sights Toronto and other great cities have to offer before you do. There’s the skyscraping CN Tower in the capital, the beautiful botanical gardens of Montreal, and Vancouver’s Stanley Park makes for an unforgettable stroll in spring or summer. Bordering the USA, there’s Niagara Falls, the roaring crossroads of waterfalls that Canada is so well known for. Further north, Banff National Park promises a world of adventure, no matter the season. Come in summer and be rewarded with picturesque views of emerald lakes backed by glinting glaciers, and sightings of grizzly bears, wolves and moose roaming through the forest. Or choose winter, when the snow-covered Rockies become an adventure playground. You can stay in Banff, where there is a choice of three ski resorts, or head down to Whistler, the country’s prime resort, famed for its staggering peak-to-peak gondola. Alternatively, surf the swells of Nova Scotia or wander the stunning fortifications of Old Québec – there’s always an adventure waiting around every corner. Homely apartments and cozy lodges are available to rent throughout the country, but you'll also find a good choice of luxury hotels and budget-friendly hostels." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66174b12-579a-4288-9834-d82a906deb5e"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5492), "If tranquillity, old town and food are for you, don’t miss out on Spain!", "Wild landscapes and walled cities, rugged mountains and rolling olive groves, whitewashed villages and bright blue ocean fronts. Spain is a lot more than 'sun, sea, sand and sangria' – a stereotype that could not be further from the truth. This country is as multi-layered as its history, with a compelling, richly influenced culture. From the pre-Romanesque ruins of northern Asturias, to Segovia’s fully intact Roman aqueduct, southern Andalucia’s majestic Moorish palaces and countless monumental cathedrals built by the all-conquering Christians, every civilisation has left its mark. The cosmopolitan capital, Madrid, buzzes with energy, while the extraordinary architecture of Barcelona justifies a visit to the Iberian Peninsula all on its own. You'll be in awe as you gaze up at the intricately carved ceilings of Antoni Gaudí’s magnificent Sagrada Família. And to experience Spain’s infinite adventure playground, go hiking, skiing, climbing or kayaking in mountain ranges like The Pyrenees, Sierra Nevada and Picos de Europa. But Spain is not just a nirvana for naturalists and history buffs. Sights like Bilbao’s Guggenheim Museum, Valencia’s City of Arts and Sciences and Madrid’s Prado Museum prove it’s also a centre of innovation and cutting-edge art. Two of the world’s most renowned surrealist artists also hail from Spain – you can visit Salvador Dali’s self-designed museum in his hometown of Figueres in Catalonia, as well as Pablo Picasso’s birthplace in Málaga, Andalucia. But, lest we forget, Spain is also home to some of Europe’s finest white-sand beaches, which draw the bulk of visitors to its sun-kissed coastlines. Join the masses on the Costa del Sol, or strike out to the virtually undeveloped Costa de Almeria, where pristine, often empty stretches abound. Spain offers practically every kind of accommodation imaginable, from high-end hotels and luxury villas, to friendly B&Bs, cheap hostels and remote eco-lodges." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78064ead-56bf-4a4f-9b77-8a5df72522e7"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5437), "The expanse of Canada's natural beauty, from mountains and glaciers to secluded lakes and forests, is almost unparalleled worldwide.", "Canada is renowned for its endless variety of landscapes. Soaring mountains, lush pine forests and windswept beaches are all here, spread across seven regions. You might be tempted to head straight to the wilderness, but consider seeing the sights Toronto and other great cities have to offer before you do. There’s the skyscraping CN Tower in the capital, the beautiful botanical gardens of Montreal, and Vancouver’s Stanley Park makes for an unforgettable stroll in spring or summer. Bordering the USA, there’s Niagara Falls, the roaring crossroads of waterfalls that Canada is so well known for. Further north, Banff National Park promises a world of adventure, no matter the season. Come in summer and be rewarded with picturesque views of emerald lakes backed by glinting glaciers, and sightings of grizzly bears, wolves and moose roaming through the forest. Or choose winter, when the snow-covered Rockies become an adventure playground. You can stay in Banff, where there is a choice of three ski resorts, or head down to Whistler, the country’s prime resort, famed for its staggering peak-to-peak gondola. Alternatively, surf the swells of Nova Scotia or wander the stunning fortifications of Old Québec – there’s always an adventure waiting around every corner. Homely apartments and cozy lodges are available to rent throughout the country, but you'll also find a good choice of luxury hotels and budget-friendly hostels." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8517b9ae-10d6-4502-920c-9eb94194ea78"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5530), "Hearty food, chaotic streets, and pretty sceneries are some of the reasons to visit Brazil.", "With an enormous land area comes great diversity, and Brazil provides stone-cold – or rather red-hot – proof. Spanning roughly 8.5 million km², its sun-drenched landscapes range from hectic cities to hip surfer towns, powdery white-sand beaches and wild rainforest. Rio de Janeiro is understandably the focus of most traveller itineraries. Wander the lively streets of Santa Teresa, watch the locals play football on Copacabana beach, ascend Sugarloaf Mountain to stand at the feet of Christ the Redeemer, and take in the stunning panoramic views. Later, head to the lively Lapa neighbourhood for a taste of the samba-fuelled nightlife, and dance the night away amidst the locals, affectionately known as ‘cariocas’. After the fast pace of Rio, you may want to recharge. Ilha Grande – a verdant island peppered with unspoiled beaches – is just a couple of hours away, while surfing havens like southerly Florianópolis and Itacaré to the north require a day’s worth of travel. With so many different environments in this huge country, there are all kinds of accommodation available, from luxury villas and beachside hotels, to funky hostels and jungle-immersed cabin lodges. Where you stay depends on the adventure you’re looking for." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c6aeae7-c22e-4552-bbcc-cf5cccf6a696"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5513), "It is one of the most extraordinary countries in the world, with an almost matchless depth of cultural and historical riches, and landscapes that have inspired artists and poets for generations.", "Spanning over one-eighth of the planet’s inhabited areas, Russia is a colossal country straddling Eastern Europe and Northern Asia. From the sunken hills of the Urals to the dense forests of Siberia and volcanic terrain of the Far East, its multifaceted landscapes are dotted with culture-rich cities and breathtaking natural sights. Russia’s long and intriguing history is the top draw for most visitors, and this is showcased beautifully in its main cities of Moscow and Saint Petersburg. The former, Russia’s mammoth capital, is home to the iconic Red Square – take a stroll along its black cobblestones and soak up the far-reaching brick walls of the Kremlin, Saint Basil’s Cathedral and Lenin’s Mausoleum. The Hermitage in Saint Petersburg offers a vast collection of treasures, ranging from Roman coins to prehistoric art. Both cities serve up delicious local dishes such piroshki (small pies with various fillings) or national delicacy caviar – best paired with a good vodka. For the intrepid traveller exploring Russia’s wild side, endless adventures await. A ride along the Trans-Siberian Railway is something on many a bucket list. The longest railway route in the world crosses seven time zones and lets you explore the dramatic scenery of Siberia. At the outer limits of the Far East, the acid lakes, volcanoes and Valley of the Geysers feature along the 1,250 km-long peninsula of Kamchatka. Russia’s accommodation choices are as wide as its geography, with hordes of hotels, hostels, apartments and guest houses scattered all over. For outdoor lovers, holiday camps (known as turbazy) and rural spas (sanatory) are also common." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92855ae8-7ce0-4a70-bd79-c81c48ed77f5"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5457), "Armenia has wrongly been overlooked as a go-to destination for tourists, but if you visit, you will find a rich cultural heritage where ancient sights and delicious food abound.", "Straddling Europe and Asia, Armenia has an ancient and complex history showcased by its stunning ruins and monuments. Medieval monasteries are dotted all over the country, surrounded by breathtaking mountains and fast-flowing rivers. The country’s rugged landscape makes it perfect for sports like rocking climbing, skiing and hiking. Head to the coast and you can try your hand at windsurfing and soak up some rays on the beaches of the Lake Sevan region. To explore the best offerings of museums and other cultural spots, venture into the capital city of Yerevan. Timeworn teahouses brush up against trendy shops and wine bars in this age-old town, and its Republic Square plays host to the famous singing fountains, as well as the National Art Gallery and History Museum of Armenia. Outside of Yerevan, you can explore some of the religious buildings constructed almost 2,000 years ago, including the Etchmiadzin Monastery, a World Heritage Site. Armenia has a wide selection of friendly B&Bs which give a true sense of the local culture. A variety of hotels, hostels and cottages can be found around Yerevan, Lake Sevan and Tzaghkadzor – a popular winter retreat." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("945f09f5-bf12-4730-bba5-06a034466b36"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5476), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c08aa9f2-c2d5-43ab-8f5a-0c94af343b1c"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5354), "If tranquillity, old town and food are for you, don’t miss out on Spain!", "Wild landscapes and walled cities, rugged mountains and rolling olive groves, whitewashed villages and bright blue ocean fronts. Spain is a lot more than 'sun, sea, sand and sangria' – a stereotype that could not be further from the truth. This country is as multi-layered as its history, with a compelling, richly influenced culture. From the pre-Romanesque ruins of northern Asturias, to Segovia’s fully intact Roman aqueduct, southern Andalucia’s majestic Moorish palaces and countless monumental cathedrals built by the all-conquering Christians, every civilisation has left its mark. The cosmopolitan capital, Madrid, buzzes with energy, while the extraordinary architecture of Barcelona justifies a visit to the Iberian Peninsula all on its own. You'll be in awe as you gaze up at the intricately carved ceilings of Antoni Gaudí’s magnificent Sagrada Família. And to experience Spain’s infinite adventure playground, go hiking, skiing, climbing or kayaking in mountain ranges like The Pyrenees, Sierra Nevada and Picos de Europa. But Spain is not just a nirvana for naturalists and history buffs. Sights like Bilbao’s Guggenheim Museum, Valencia’s City of Arts and Sciences and Madrid’s Prado Museum prove it’s also a centre of innovation and cutting-edge art. Two of the world’s most renowned surrealist artists also hail from Spain – you can visit Salvador Dali’s self-designed museum in his hometown of Figueres in Catalonia, as well as Pablo Picasso’s birthplace in Málaga, Andalucia. But, lest we forget, Spain is also home to some of Europe’s finest white-sand beaches, which draw the bulk of visitors to its sun-kissed coastlines. Join the masses on the Costa del Sol, or strike out to the virtually undeveloped Costa de Almeria, where pristine, often empty stretches abound. Spain offers practically every kind of accommodation imaginable, from high-end hotels and luxury villas, to friendly B&Bs, cheap hostels and remote eco-lodges." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef42b0e7-7edf-4f08-ae50-cfeb1dba2e73"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(3532), "Enjoy relaxation, restaurants and shopping during your next trip to United States!", "Even if you've never visited the United States, the country's attractions need no introduction. From the Statue of Liberty to the Grand Canyon, there’s a familiarity borne from endless films and TV shows and her role as a world superpower. Her sheer size means there's a sublime cocktail of sights, sounds and cultures to explore. America may be a relatively young nation but it sure knows how to build cities that are unforgettable. On the East Coast, glance up at the iconic skyscrapers of New York and chow down on lobster in Boston. On the West Coast, stroll San Francisco's crazy, twisty streets and visit the real La La land of Los Angeles. While inland, roll the dice in glittering Las Vegas. You'll find a different America at each world-famous city. Then there's the breathtaking, epic vistas. Countless. There's a reason why road trips hold such appeal. Head north to draw breath at Alaska's wilderness and majestic peaks of the Rockies, hike the glories of its famed national parks Yosemite and Yellowstone, look up at the towering rainforests of the Pacific Northwest, take in the sublime countryside of New England on the East Coast... just a few of its natural wonders. And with so many hotels here, from popular chains to world-class accommodation, cheap motels to beach resorts, you'll always find the right accommodation for you." });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f44d1dbd-751f-4a70-adcf-113191f89e47"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(5418), "Hearty food, chaotic streets, and pretty sceneries are some of the reasons to visit Brazil.", "With an enormous land area comes great diversity, and Brazil provides stone-cold – or rather red-hot – proof. Spanning roughly 8.5 million km², its sun-drenched landscapes range from hectic cities to hip surfer towns, powdery white-sand beaches and wild rainforest. Rio de Janeiro is understandably the focus of most traveller itineraries. Wander the lively streets of Santa Teresa, watch the locals play football on Copacabana beach, ascend Sugarloaf Mountain to stand at the feet of Christ the Redeemer, and take in the stunning panoramic views. Later, head to the lively Lapa neighbourhood for a taste of the samba-fuelled nightlife, and dance the night away amidst the locals, affectionately known as ‘cariocas’. After the fast pace of Rio, you may want to recharge. Ilha Grande – a verdant island peppered with unspoiled beaches – is just a couple of hours away, while surfing havens like southerly Florianópolis and Itacaré to the north require a day’s worth of travel. With so many different environments in this huge country, there are all kinds of accommodation available, from luxury villas and beachside hotels, to funky hostels and jungle-immersed cabin lodges. Where you stay depends on the adventure you’re looking for." });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(3013), null, "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(1136), null, "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "Subtitle", "Text" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 40, 19, 407, DateTimeKind.Utc).AddTicks(2958), null, "Содержание заполняется администратором" });
        }
    }
}
