using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UdemyAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d235f81-2bc8-4012-ba38-c1df39d53410"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58ff8a86-d7fa-4256-9ca2-45ce7d8a45a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b4bd68a-9fa2-4205-9fc5-8a49bcca2868"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("117c6277-ac7c-4797-9f52-1084b2de620e"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("2b6a6663-905d-4560-af1b-9c2c791c4e18"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("56c25971-6a64-4786-b828-33a6227e839a"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("88536d07-6be5-44ea-9723-5b40acfbfe7e"), "Finans", new DateTime(2024, 9, 9, 10, 43, 30, 692, DateTimeKind.Utc).AddTicks(3942), false },
                    { new Guid("9ac6ee9f-cec6-46d0-b7bc-29b30d285ab2"), "Yazılım", new DateTime(2024, 9, 9, 10, 43, 30, 692, DateTimeKind.Utc).AddTicks(3918), false },
                    { new Guid("a0f89c38-7ce0-4835-8878-3e88bdff4c8e"), "Kişisel Gelişim", new DateTime(2024, 9, 9, 10, 43, 30, 692, DateTimeKind.Utc).AddTicks(3943), false }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "CreatedDate", "ImageUrl", "IsDeleted", "NameSurname" },
                values: new object[,]
                {
                    { new Guid("78ec94c9-705f-4a73-b251-d12b0f8db354"), "Test", new DateTime(2024, 9, 9, 10, 43, 30, 692, DateTimeKind.Utc).AddTicks(5928), "testurl", false, "Gencay Yildiz" },
                    { new Guid("8a2a6d67-061e-4bb5-9087-3a65e5643bc8"), "Test2", new DateTime(2024, 9, 9, 10, 43, 30, 692, DateTimeKind.Utc).AddTicks(5943), "testurl", false, "Murat Yucedag" },
                    { new Guid("fad3a3d6-3057-4e66-adc6-40d81a3d1ae1"), "Test3", new DateTime(2024, 9, 9, 10, 43, 30, 692, DateTimeKind.Utc).AddTicks(5944), "testurl", false, "Maximillian Shwarzmuller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88536d07-6be5-44ea-9723-5b40acfbfe7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ac6ee9f-cec6-46d0-b7bc-29b30d285ab2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0f89c38-7ce0-4835-8878-3e88bdff4c8e"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("78ec94c9-705f-4a73-b251-d12b0f8db354"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("8a2a6d67-061e-4bb5-9087-3a65e5643bc8"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("fad3a3d6-3057-4e66-adc6-40d81a3d1ae1"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0d235f81-2bc8-4012-ba38-c1df39d53410"), "Yazılım", new DateTime(2024, 9, 9, 10, 40, 35, 980, DateTimeKind.Utc).AddTicks(3222), false },
                    { new Guid("58ff8a86-d7fa-4256-9ca2-45ce7d8a45a5"), "Finans", new DateTime(2024, 9, 9, 10, 40, 35, 980, DateTimeKind.Utc).AddTicks(3254), false },
                    { new Guid("9b4bd68a-9fa2-4205-9fc5-8a49bcca2868"), "Kişisel Gelişim", new DateTime(2024, 9, 9, 10, 40, 35, 980, DateTimeKind.Utc).AddTicks(3256), false }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "CreatedDate", "ImageUrl", "IsDeleted", "NameSurname" },
                values: new object[,]
                {
                    { new Guid("117c6277-ac7c-4797-9f52-1084b2de620e"), "Test2", new DateTime(2024, 9, 9, 10, 40, 35, 980, DateTimeKind.Utc).AddTicks(4874), "testurl", false, "Murat Yucedag" },
                    { new Guid("2b6a6663-905d-4560-af1b-9c2c791c4e18"), "Test", new DateTime(2024, 9, 9, 10, 40, 35, 980, DateTimeKind.Utc).AddTicks(4867), "testurl", false, "Gencay Yildiz" },
                    { new Guid("56c25971-6a64-4786-b828-33a6227e839a"), "Test3", new DateTime(2024, 9, 9, 10, 40, 35, 980, DateTimeKind.Utc).AddTicks(4876), "testurl", false, "Maximillian Shwarzmuller" }
                });
        }
    }
}
