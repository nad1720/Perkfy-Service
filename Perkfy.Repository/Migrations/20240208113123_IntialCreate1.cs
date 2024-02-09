using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perkfy.Repository.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ea86e7-c7ec-4dad-bde7-208113685ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1af87f9a-8844-4cec-89cc-53c16f7f2090");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4811b96f-3a9a-4097-bc64-4c7b57a6991e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b60c57-942c-4182-b5af-e28538cc9bcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1bc0d99-f720-46e7-a16d-2333afc1869f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eef01918-2a2f-461d-9df4-6c5d39cbd0d8");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "17ea86e7-c7ec-4dad-bde7-208113685ab9", null, "Member", "MEMBER" },
                    { "1af87f9a-8844-4cec-89cc-53c16f7f2090", null, "Owner", "ADMIN" },
                    { "4811b96f-3a9a-4097-bc64-4c7b57a6991e", null, "ClientAdmin", "CLIENTADMIN" },
                    { "96b60c57-942c-4182-b5af-e28538cc9bcb", null, "Admin", "ADMIN" },
                    { "c1bc0d99-f720-46e7-a16d-2333afc1869f", null, "SuperAdmin", "SUPERaDMIN" },
                    { "eef01918-2a2f-461d-9df4-6c5d39cbd0d8", null, "Casheir", "CASHEIR" }
                });
        }
    }
}
