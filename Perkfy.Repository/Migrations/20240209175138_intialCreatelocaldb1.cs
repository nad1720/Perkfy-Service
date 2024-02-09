using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perkfy.Repository.Migrations
{
    /// <inheritdoc />
    public partial class intialCreatelocaldb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "18308bb7-1c0e-4453-a027-202ceabac20e", null, "Admin", "ADMIN" },
                    { "257aee9b-e512-4e75-8b69-4e86f316f842", null, "Member", "MEMBER" },
                    { "c8a716c2-b3d7-4740-9077-36f0fb42067a", null, "Owner", "OWNER" },
                    { "ccc6a718-dec1-4719-9b92-a8bb76ac00da", null, "Casheir", "CASHEIR" },
                    { "ceda2211-2051-458d-8e08-49eb0c52841f", null, "ClientAdmin", "CLIENTADMIN" },
                    { "d06eadfa-586b-4075-adcc-7694327ae493", null, "SuperAdmin", "SUPERaDMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18308bb7-1c0e-4453-a027-202ceabac20e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "257aee9b-e512-4e75-8b69-4e86f316f842");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a716c2-b3d7-4740-9077-36f0fb42067a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccc6a718-dec1-4719-9b92-a8bb76ac00da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceda2211-2051-458d-8e08-49eb0c52841f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d06eadfa-586b-4075-adcc-7694327ae493");

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
    }
}
