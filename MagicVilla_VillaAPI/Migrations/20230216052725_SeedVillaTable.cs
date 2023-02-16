using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDate", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", "Royal Villa", 5, 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 550 },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", "Premium Pool Villa", 4, 300.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 550 },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", "Luxury Pool Villa", 4, 400.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 750 },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", "Diamond Villa", 4, 550.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900 },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 4, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
