using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UdemyAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_lesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "LessonName",
                table: "Lessons",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0066fe1c-9330-4c83-bd51-9b8d4dd7f5d5"), "Finans", new DateTime(2024, 9, 10, 11, 57, 22, 217, DateTimeKind.Utc).AddTicks(5380), false },
                    { new Guid("0ce49619-a6b5-4e59-804f-8208efe5feb4"), "Yazılım", new DateTime(2024, 9, 10, 11, 57, 22, 217, DateTimeKind.Utc).AddTicks(5360), false },
                    { new Guid("5762830f-ab85-47b0-aaa7-29564b14948f"), "Kişisel Gelişim", new DateTime(2024, 9, 10, 11, 57, 22, 217, DateTimeKind.Utc).AddTicks(5382), false }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "CreatedDate", "ImageUrl", "IsDeleted", "NameSurname" },
                values: new object[,]
                {
                    { new Guid("d294c65c-db60-43b7-8527-24e79cb5391d"), "Test3", new DateTime(2024, 9, 10, 11, 57, 22, 217, DateTimeKind.Utc).AddTicks(6995), "testurl", false, "Maximillian Shwarzmuller" },
                    { new Guid("d8191d49-63fb-4d5a-b5cf-9d62cd7e8340"), "Test2", new DateTime(2024, 9, 10, 11, 57, 22, 217, DateTimeKind.Utc).AddTicks(6994), "testurl", false, "Murat Yucedag" },
                    { new Guid("f7fa13f3-bb17-4394-ad88-f8874088bf58"), "Test", new DateTime(2024, 9, 10, 11, 57, 22, 217, DateTimeKind.Utc).AddTicks(6982), "testurl", false, "Gencay Yildiz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0066fe1c-9330-4c83-bd51-9b8d4dd7f5d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ce49619-a6b5-4e59-804f-8208efe5feb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5762830f-ab85-47b0-aaa7-29564b14948f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d294c65c-db60-43b7-8527-24e79cb5391d"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d8191d49-63fb-4d5a-b5cf-9d62cd7e8340"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f7fa13f3-bb17-4394-ad88-f8874088bf58"));

            migrationBuilder.DropColumn(
                name: "LessonName",
                table: "Lessons");

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
    }
}
