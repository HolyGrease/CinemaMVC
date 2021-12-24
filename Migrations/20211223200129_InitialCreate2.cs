using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cinema.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Jumanji" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Birds of Prey" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "Frozen 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title" },
                values: new object[] { 4, "Mulan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title" },
                values: new object[] { 5, "1917" });

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Name", "Seats" },
                values: new object[] { 1, "Salon 1", 50 });

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Name", "Seats" },
                values: new object[] { 2, "Salon 2", 100 });

            migrationBuilder.InsertData(
                table: "Displays",
                columns: new[] { "Id", "MovieId", "SalonId", "TicketsSold", "Time", "TotalTicketsSold" },
                values: new object[] { 1, 1, 2, 0, new DateTime(2021, 12, 23, 21, 30, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Displays",
                columns: new[] { "Id", "MovieId", "SalonId", "TicketsSold", "Time", "TotalTicketsSold" },
                values: new object[] { 2, 2, 1, 0, new DateTime(2021, 12, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Displays",
                columns: new[] { "Id", "MovieId", "SalonId", "TicketsSold", "Time", "TotalTicketsSold" },
                values: new object[] { 3, 3, 1, 0, new DateTime(2021, 12, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Displays",
                columns: new[] { "Id", "MovieId", "SalonId", "TicketsSold", "Time", "TotalTicketsSold" },
                values: new object[] { 4, 4, 2, 0, new DateTime(2021, 12, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Displays",
                columns: new[] { "Id", "MovieId", "SalonId", "TicketsSold", "Time", "TotalTicketsSold" },
                values: new object[] { 5, 3, 2, 0, new DateTime(2021, 12, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Displays",
                columns: new[] { "Id", "MovieId", "SalonId", "TicketsSold", "Time", "TotalTicketsSold" },
                values: new object[] { 6, 5, 1, 0, new DateTime(2021, 12, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Displays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Displays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Displays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Displays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Displays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Displays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
