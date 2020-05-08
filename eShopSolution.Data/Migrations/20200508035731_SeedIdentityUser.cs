using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("56d3cf0c-0d11-4e42-b250-ad807dd2ab64"), "cb6a7ecc-9a98-4748-9ab4-75678333c412", "Adminstrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("ad65d59d-27ab-4f24-8805-9559c964527d"), new Guid("56d3cf0c-0d11-4e42-b250-ad807dd2ab64") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ad65d59d-27ab-4f24-8805-9559c964527d"), 0, "0186be5d-b085-4927-a927-ccbb2830ed1b", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "trannguyenanhhien@gmail.com", true, "Hien", "Tran Nguyen Anh", false, null, "trannguyenanhhien@gmail.com", "admin", "AQAAAAEAACcQAAAAEPWq8Man/a6YA25wIgKo8VhAqHY9aTT5kt8EiPx927WV2287hCLbUNU/IKT5I5y6Xw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 5, 8, 10, 57, 30, 812, DateTimeKind.Local).AddTicks(3149));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("56d3cf0c-0d11-4e42-b250-ad807dd2ab64"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ad65d59d-27ab-4f24-8805-9559c964527d"), new Guid("56d3cf0c-0d11-4e42-b250-ad807dd2ab64") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad65d59d-27ab-4f24-8805-9559c964527d"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 5, 8, 10, 37, 10, 908, DateTimeKind.Local).AddTicks(1553));
        }
    }
}
