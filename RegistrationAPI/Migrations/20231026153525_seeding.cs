using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAPI.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Age", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("cd033916-a65b-4354-8bc8-1e2c35106d33"), 65, "Unites States", "Bill Gates" },
                    { new Guid("516d8b7e-f4be-4820-a7fa-7116bb47d427"), 48, "United Kingdom", "Matthew Walker" },
                    { new Guid("1afc6632-7d0b-4217-9d73-72f88e928e96"), 51, "Unites States", "Hope Jahren" },
                    { new Guid("7cd56e95-ab42-4684-9c98-1ecb5ab675b6"), 45, "United Kingdom", "Matt Haig" },
                    { new Guid("fcc53275-4d46-41c9-b19f-5d7574213beb"), 35, "United Kingdom", "Lucy Foley" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreId", "Genre" },
                values: new object[,]
                {
                    { new Guid("de9cd5f5-8f93-4504-aa25-f0641864be8d"), "Fiction" },
                    { new Guid("eaf4e809-7fad-436c-ba60-fdd0a1734806"), "Mystery & Thriller" },
                    { new Guid("a4e5a562-72a4-4b9e-bc5e-c8994a759970"), "Nonfiction" },
                    { new Guid("f34210d1-af73-42e8-8b35-287f154c9252"), "Science & Technology" },
                    { new Guid("eeb07f13-38f8-4de1-b943-65d77efac5e9"), "Historical Fiction" },
                    { new Guid("ad5e03fe-691a-4acc-a4da-476048ffa3fa"), "Science & Technology" },
                    { new Guid("6fda8bb9-7a34-40b4-a836-cb0291ac3e21"), "Fantasy" },
                    { new Guid("b7cf09f6-b658-4f1f-ba36-7ee0219cf9a1"), "Romance" },
                    { new Guid("c7480849-9cc8-4fbd-bea1-fc61e2238672"), "Horror" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1afc6632-7d0b-4217-9d73-72f88e928e96"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("516d8b7e-f4be-4820-a7fa-7116bb47d427"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("7cd56e95-ab42-4684-9c98-1ecb5ab675b6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("cd033916-a65b-4354-8bc8-1e2c35106d33"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("fcc53275-4d46-41c9-b19f-5d7574213beb"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("6fda8bb9-7a34-40b4-a836-cb0291ac3e21"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("a4e5a562-72a4-4b9e-bc5e-c8994a759970"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("ad5e03fe-691a-4acc-a4da-476048ffa3fa"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("b7cf09f6-b658-4f1f-ba36-7ee0219cf9a1"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("c7480849-9cc8-4fbd-bea1-fc61e2238672"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("de9cd5f5-8f93-4504-aa25-f0641864be8d"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("eaf4e809-7fad-436c-ba60-fdd0a1734806"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("eeb07f13-38f8-4de1-b943-65d77efac5e9"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("f34210d1-af73-42e8-8b35-287f154c9252"));
        }
    }
}
