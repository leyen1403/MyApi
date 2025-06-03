using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApi.Infranstructure.Migrations
{
    public partial class SeedEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { new Guid("a1111111-1111-1111-1111-111111111111"), "a@example.com", "Nguyễn Văn A", "0123456789" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { new Guid("b2222222-2222-2222-2222-222222222222"), "b@example.com", "Trần Thị B", "0987654321" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"));
        }
    }
}
