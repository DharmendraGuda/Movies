using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesAPI.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "AverageRating", "NumberRated", "RunningTime", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 3.6680000000000001, 5, 120, "Promising Young Woman", 2021 },
                    { 10, 2.6600000000000001, 85, 120, "Dreams", 2021 },
                    { 8, 2.23, 65, 120, "Mad Money", 2020 },
                    { 7, 3.1600000000000001, 55, 120, "Tokyo Story", 1945 },
                    { 6, 4.6600000000000001, 54, 120, "Late Spring", 2021 },
                    { 9, 1.45, 75, 120, "Bad Dreams", 2021 },
                    { 4, 3.9900000000000002, 15, 120, "Another Round", 2021 },
                    { 3, 3.6600000000000001, 25, 120, "Tenet", 2021 },
                    { 2, 4.6600000000000001, 10, 120, "A Quiet Place Part II", 2000 },
                    { 5, 4.9800000000000004, 52, 120, "Toy Story", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name" },
                values: new object[,]
                {
                    { 7, "Karen" },
                    { 1, "Mathew" },
                    { 2, "Dan" },
                    { 3, "Mary " },
                    { 4, "Tony" },
                    { 5, "Lisa" },
                    { 6, "Nicole" },
                    { 8, "Mike" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "MovieGenreId", "GenreType", "MovieId" },
                values: new object[,]
                {
                    { 1, "Crime", 1 },
                    { 13, "Comedy", 10 },
                    { 12, "Crime", 10 },
                    { 11, "Horror", 9 },
                    { 10, "Crime", 8 },
                    { 15, "Horror", 7 },
                    { 9, "Crime", 6 },
                    { 14, "Drama", 10 },
                    { 7, "Sci-Fi", 4 },
                    { 6, "Crime", 4 },
                    { 5, "Drama", 3 },
                    { 4, "Drama", 2 },
                    { 3, "Comedy", 2 },
                    { 2, "Comedy", 1 },
                    { 8, "Thriller", 5 }
                });

            migrationBuilder.InsertData(
                table: "UserRatings",
                columns: new[] { "MovieId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 7, 5, 5.0 },
                    { 6, 4, 5.0 },
                    { 8, 3, 5.0 },
                    { 5, 3, 5.0 },
                    { 4, 2, 3.5 },
                    { 1, 2, 4.5 },
                    { 4, 1, 3.5 },
                    { 5, 1, 2.5 },
                    { 3, 1, 5.0 },
                    { 2, 1, 3.0 },
                    { 1, 1, 4.5 },
                    { 8, 6, 5.0 },
                    { 6, 1, 1.5 },
                    { 9, 7, 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumn: "MovieGenreId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "UserRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);
        }
    }
}
