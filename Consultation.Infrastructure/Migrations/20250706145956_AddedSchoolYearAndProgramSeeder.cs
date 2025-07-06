using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedSchoolYearAndProgramSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDsgqA5rEInMF3yvckWBzaahQa0M3DXdVIrD8C94KWw6gMZ0YL32j4/PkPwup2+2nA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELkAPMh2ViqRKrBodaBU/i+QoYWeaBKQK635quSjkHhbEUeTNn/qmGzZU/EMX0mNqA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEICzX1cczk3JwKoiExEQ9YiPZV3SttJ57uXlo2HyJn0VeECZJg5hhvI8GPUg4BjaNw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAjuy16X1RKmzkMze+8qSm5hNOJ7KvuyQKEI1yZKwg2BK2G5BE/MTPnYJZg51SUV4w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPJRj/O4qj0bT57hrP0/MmEOkt5EUAivaghL0cVtvu0Grif7uxgJMRsn5JwOiYvfRg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBLD0ZaqCbxW0ReyqRlmxznCu7+SvyzRR1VgbEj72BOMcPum6YQABfVUGHtfygilag==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBrdRYnz6LBmfIJZo1lj78Sfn2FFE2rICunz9W3NE/eftOKu2i1zrNkE0LIhdz8Bzw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPOX5yF1QbF5jUa5kfNEVw9GvoO1mJOn5L3xvPQ2oMI/hWezdYMyPoIFK0ZKL4arbQ==");

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "ProgramID", "DepartmentID", "Description", "ProgramName" },
                values: new object[,]
                {
                    { 1, 3, "Mechanical Engineering", "ME" },
                    { 2, 3, "Civil Engineering", "CE" },
                    { 3, 3, "Computer Engineering", "CPE" },
                    { 4, 3, "Electrical Engineering", "EE" },
                    { 5, 3, "Electronics Engineering", "ECE" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYear",
                columns: new[] { "SchoolYearID", "SchoolYearStatus", "Semester", "Year1", "Year2" },
                values: new object[,]
                {
                    { 1, 1, 1, "2024", "2025" },
                    { 2, 1, 2, "2024", "2025" },
                    { 3, 1, 3, "2024", "2025" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SchoolYear",
                keyColumn: "SchoolYearID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolYear",
                keyColumn: "SchoolYearID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolYear",
                keyColumn: "SchoolYearID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH4I/I4qeD+Y28XC0Izk7IhRUoJCdgydITVe0neN8PlSKhWxeDK8HXO9hvs6Ny5K9A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDJ8NNskGurN52olB502FZAJFdWzeAC5XL0He7298jaUmGtELCE61umHqzcZMt10bA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKadJU/M/fapx3hmZwubuGo2bBDgLQ76ComEUa8ZVEsP5dSrjXJNqQ8M32PtUS7MyA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFiY5yxNbQpQKyl1cgm4e8hET6YlzCl6XDKjqQrD/3r9Ums0uCThVmVc2ZbgqF3fbw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHjnm8GpXWPFGLBymeDjh6wYwmcFJBazFg8eDeXbgvQhZdPhcMVBSFID+I0IOw7mLQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENh9d+kK9Hidhwvmdq5ybRMkOCXMoqvNC0lJSdbB4GCwp2f12WsW6m7fStIg832EAA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMXdVVIfWJCf2DLL62VXgwib/Ljmgc7tF4wxTpZVT+XPlLy7fTly0erEUP+aFYRAiQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENowKWHzGcfU+a6/iOsn1wp/0OKExfqNWvQQlMMmIxm278M+c/p86m7hrVmU5MQCUA==");
        }
    }
}
