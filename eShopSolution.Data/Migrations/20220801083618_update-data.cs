using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3aa5dd70-2154-4b61-952a-95df67e57384");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eea8b172-656a-4dd6-8442-b00dcbcd5a10", "AQAAAAEAACcQAAAAEPDm8lk/q2aR/pMQu+9aKVy8UuHTQG1Fwj6UIdzmUJlzkvmMr/riR/1EMUVJbAruCw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 1, 15, 36, 18, 209, DateTimeKind.Local).AddTicks(2959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "01f71330-0a3d-45f4-8696-b755242d86a6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08444582-1820-41d9-b83d-b8cc4690dcdf", "AQAAAAEAACcQAAAAEGPCuMQNEx8mT5HCx4X2G9P50r8m0eLYKuAZornAcyCch91sM1Kr8+wMHwqAnKJKfA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 28, 10, 27, 35, 380, DateTimeKind.Local).AddTicks(3016));
        }
    }
}
