using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWebAPI.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Alias", "FullName", "Gender", "PictureUrl" },
                values: new object[,]
                {
                    { 1, "Human", "Iron Man", "Male", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/e/e9/Iron_Man_AIW_Profile.jpg/revision/latest?cb=20180518212029" },
                    { 2, "Human", "Captain America", "Male", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/6/66/Captain_America_AIW_Profile.jpg/revision/latest?cb=20180518211704" },
                    { 3, "Human", "Hulk", "Male", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/c/c3/Hulk_AIW_Profile.jpg/revision/latest?cb=20180518211829" },
                    { 4, "Asgardian", "Thor", "Male", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/4/45/Thor_AIW_Profile.jpg/revision/latest?cb=20180518212120" },
                    { 5, "Human", "Black Widow", "Female", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/5/50/Black_Widow_AIW_Profile.jpg/revision/latest?cb=20180518212205" },
                    { 6, "Human", "Hawkeye", "Maale", "https://vignette.wikia.nocookie.net/marvelcinematicuniverse/images/6/6f/CW_Textless_Shield_Poster_02.jpg/revision/latest?cb=20180417151836" }
                });

            migrationBuilder.InsertData(
                table: "Franchise",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Marvel Cinematic Universe" },
                    { 2, null, "Lord of the Rings" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Director", "FranchiseId", "Genre", "PictureUrl", "ReleaseYear", "Title", "Trailer" },
                values: new object[,]
                {
                    { 1, "", 1, "Action", "", 2015, "Iron Man", "" },
                    { 22, "Peter Jackson", 2, "Fantasy", "", 2003, "The Two Towers", "" },
                    { 21, "Peter Jackson", 2, "Fantasy", "", 2001, "The Fellowship of the Ring", "" },
                    { 20, "", 1, "Science Fiction", "", 2018, "Ant-Man and the Wasp", "" },
                    { 19, "", 1, "Science Fiction", "", 2018, "Avengers: Infinity War", "" },
                    { 18, "", 1, "Science Fiction", "", 2018, "Black Panther", "" },
                    { 17, "", 1, "Science Fiction", "", 2017, "Thor: Ragnarok", "" },
                    { 16, "", 1, "Science Fiction", "", 2017, "Spider-Man: Homecoming", "" },
                    { 15, "", 1, "Science Fiction", "", 2017, "Guardians of the Galaxy Vol. 2", "" },
                    { 14, "", 1, "Science Fiction", "", 2016, "Doctor Strange", "" },
                    { 13, "", 1, "Science Fiction", "", 2016, "Captain America: Civil War", "" },
                    { 12, "", 1, "Science Fiction", "", 2015, "Ant-Man", "" },
                    { 11, "", 1, "Science Fiction", "", 2015, "Avengers: Age of Ultron", "" },
                    { 10, "", 1, "Science Fiction", "", 2014, "Guardians of the Galaxy", "" },
                    { 9, "", 1, "Science Fiction", "", 2014, "Captain America: The Winter Soldier", "" },
                    { 8, "", 1, "Science Fiction", "", 2013, "Thor: The Dark World", "" },
                    { 7, "", 1, "Action", "", 2015, "Iron Man 3", "" },
                    { 6, "", 1, "Science Fiction", "", 2012, "Avengers, The", "" },
                    { 5, "", 1, "Science Fiction", "", 2011, "Captain America", "" },
                    { 4, "", 1, "Action", "", 2011, "Thor", "" },
                    { 3, "", 1, "Action", "", 2015, "Iron Man 2", "" },
                    { 2, "", 1, "Action", "", 2008, "The Incredible Hulk", "" },
                    { 23, "Peter Jackson", 2, "Fantasy", "", 2005, "The Return of the King", "" },
                    { 24, "Peter Jackson", 2, "Fantasy", "", 2010, "Hobbit", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Franchise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Franchise",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
