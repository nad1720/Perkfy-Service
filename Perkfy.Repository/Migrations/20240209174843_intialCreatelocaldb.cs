using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perkfy.Repository.Migrations
{
    /// <inheritdoc />
    public partial class intialCreatelocaldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "144299b5-8671-480c-bf0a-45cae8f7ea3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "168b3b8f-dc4e-4e50-afbf-40b171fb8f79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c31cf46-40c7-4d90-8a22-11c7dbd180cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da6e5e19-af95-454d-963a-6fe24eb272dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4affa76-a4df-4677-8e82-ef3758ffc8dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea77f861-f8d1-44bf-8dfc-2cf0b4df900d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "529f9773-e0a6-41cd-90e2-95552216d061", null, "Admin", "ADMIN" },
                    { "54a8eac4-468c-465b-bb5c-1587c0f16c87", null, "Casheir", "CASHEIR" },
                    { "60722ffe-94e5-4caf-ba30-056e002abfd3", null, "SuperAdmin", "SUPERaDMIN" },
                    { "9f3117ee-f2c2-4584-a7db-29122055bd90", null, "Owner", "OWNER" },
                    { "d71a676e-ad0c-42d6-be51-b717972268bd", null, "Member", "MEMBER" },
                    { "df3a5530-1955-4381-8862-fd2668a9ade9", null, "ClientAdmin", "CLIENTADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529f9773-e0a6-41cd-90e2-95552216d061");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54a8eac4-468c-465b-bb5c-1587c0f16c87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60722ffe-94e5-4caf-ba30-056e002abfd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f3117ee-f2c2-4584-a7db-29122055bd90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d71a676e-ad0c-42d6-be51-b717972268bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df3a5530-1955-4381-8862-fd2668a9ade9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "144299b5-8671-480c-bf0a-45cae8f7ea3d", null, "Member", "MEMBER" },
                    { "168b3b8f-dc4e-4e50-afbf-40b171fb8f79", null, "Admin", "ADMIN" },
                    { "2c31cf46-40c7-4d90-8a22-11c7dbd180cd", null, "Casheir", "CASHEIR" },
                    { "da6e5e19-af95-454d-963a-6fe24eb272dc", null, "ClientAdmin", "CLIENTADMIN" },
                    { "e4affa76-a4df-4677-8e82-ef3758ffc8dd", null, "Owner", "OWNER" },
                    { "ea77f861-f8d1-44bf-8dfc-2cf0b4df900d", null, "SuperAdmin", "SUPERaDMIN" }
                });
        }
    }
}
