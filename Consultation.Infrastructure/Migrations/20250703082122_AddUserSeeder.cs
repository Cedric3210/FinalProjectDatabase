using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM0b0oYoOhUty8ri1Il2rau1MP3O861qwW1y1g0lBAZZWxzh6tTchqeTWUZ4C49Xew==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ4xmdRDdi+qgwMfGsHWIZ0Sbz1VsQlrrsGdlOC5EgnddZcSOBaQNG7GVZ7FHhQLRg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDl7B+I4CVQ3saT0xETwXIA2lQFklmo0Z1veZ3/3DS4oQnUR2/NIlorhLP5rDgrlIQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI76PdJ41v+Y6dbcvCaz1+EjFCpzLKUC0WxS0v25cDHJGOSLKNR4Gl5+pPWd3YfKRw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOVY7f1890/9SVUvXTY1wguwYKZBUbE1zGSoh7u2PiwrXVOGCPNeOwt/DpYRN+hdDg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPtu8MsiGnp8xvGp0MASvhxak+j6tWRKLs2es1DnJ2uCERyGKeNFmy1KiTw+QFWTKQ==");
        }
    }
}
