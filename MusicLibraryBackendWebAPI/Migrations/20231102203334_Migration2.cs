using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryBackendWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReleaseDate",
                table: "Songs",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "808s & Heartbreak", "Kanye West", "Hip-Hop", 2008, "Amazing" },
                    { 2, "808s & Heartbreak", "Kanye West", "Hip-Hop", 2008, "Heartless" },
                    { 3, "DAMN", "Kendrick Lamar", "Hip-Hop", 2017, "DNA" },
                    { 4, "DAMN", "Kendrick Lamar", "Hip-Hop", 2017, "PRIDE" },
                    { 5, "The Slow Rush", "Tame Impala", "Psychedelic Rock", 2020, "Borderline" },
                    { 6, "Currents", "Tame Impala", "Psychedelic Rock", 2015, "Let It Happen" },
                    { 7, "Frank", "Amy Winehouse", "Jazz", 2003, "Stronger Than Me" },
                    { 8, "Back to Black", "Amy Winehouse", "Jazz", 2006, "Love Is A Losing Game" },
                    { 9, "channel ORANGE", "Frank Ocean", "Neo Soul", 2012, "Pink Matter" },
                    { 10, "Blonde", "Frank Ocean", "Neo Soul", 2016, "Nights" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Songs",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
