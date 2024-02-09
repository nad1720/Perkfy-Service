using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perkfy.Repository.Migrations
{
    /// <inheritdoc />
    public partial class enums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "13c7d424-c758-4a5b-a704-4fd70f8d3859", null, "SuperAdmin", "SUPERaDMIN" },
                    { "3d1cca50-2d12-48c2-9c7e-0437fb2ba0a4", null, "ClientAdmin", "CLIENTADMIN" },
                    { "49b1edab-8ad6-406d-852e-08c2aca45028", null, "Owner", "OWNER" },
                    { "9be96d2c-0ab1-4d92-9413-85a35c97dab2", null, "Member", "MEMBER" },
                    { "9d75ce1a-83c3-459a-9276-2abdf6fc78cb", null, "Admin", "ADMIN" },
                    { "eebffb9e-0f09-449f-9db3-a25dd6bbb153", null, "Casheir", "CASHEIR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13c7d424-c758-4a5b-a704-4fd70f8d3859");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1cca50-2d12-48c2-9c7e-0437fb2ba0a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49b1edab-8ad6-406d-852e-08c2aca45028");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be96d2c-0ab1-4d92-9413-85a35c97dab2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d75ce1a-83c3-459a-9276-2abdf6fc78cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eebffb9e-0f09-449f-9db3-a25dd6bbb153");

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
    }
}
