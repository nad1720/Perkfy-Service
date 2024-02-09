using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perkfy.Repository.Migrations
{
    /// <inheritdoc />
    public partial class enums1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "178a038c-ef00-4f08-b5df-768384fdf667", null, "Admin", "ADMIN" },
                    { "3487b9dd-5388-4055-8f20-0668e7970d90", null, "Casheir", "CASHEIR" },
                    { "7c93a182-51a0-41d3-bc43-7934e8529498", null, "ClientAdmin", "CLIENTADMIN" },
                    { "8e897cf2-8e74-4e0c-91b5-79c6c83e5806", null, "SuperAdmin", "SUPERaDMIN" },
                    { "bd76beee-9e68-4118-8bc1-41dd5775bbe7", null, "Member", "MEMBER" },
                    { "d6ad3a49-8026-44ce-9692-74879b1f672b", null, "Owner", "OWNER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "178a038c-ef00-4f08-b5df-768384fdf667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3487b9dd-5388-4055-8f20-0668e7970d90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c93a182-51a0-41d3-bc43-7934e8529498");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e897cf2-8e74-4e0c-91b5-79c6c83e5806");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd76beee-9e68-4118-8bc1-41dd5775bbe7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6ad3a49-8026-44ce-9692-74879b1f672b");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Brands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
