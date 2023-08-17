using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject2.Migrations
{
    /// <inheritdoc />
    public partial class DBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true),
                    BookNumber = table.Column<int>(type: "int", nullable: true),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorName", "BookName", "Discriminator", "Img", "Isbn", "PublishYear" },
                values: new object[,]
                {
                    { 1, "Boichi", "Sun Ken Rock Vol.1", "Book", "01-Ken.jpg", "978-8861230767", 2006 },
                    { 2, "Boichi", "Dr. Stone Vol.1", "Book", "02-DrStone.jpg", "978-1-9747-0261-9", 2017 },
                    { 3, "Boichi", "Origin", "Book", "03-Origin_(manga)_1.png", "978-1-64-729287-4", 2016 },
                    { 4, "Gege Akutami", "Jujutsu Kaisen 0", "Book", "04-Jujutsu_Kaisen_0_Cover.png", "978-4-08-881672-2", 2017 },
                    { 5, "Gege Akutami", "Jujutsu Kaisen Vol.8", "Book", "05-Volume_8.jpg", "978-4-08-882168-9", 2020 },
                    { 6, "Gege Akutami", "Jujutsu Kaisen Vol.1", "Book", "06-Volume_1.jpg", "978-4-08-881516-9", 2018 },
                    { 7, "Gege Akutami", "Jujutsu Kaisen Vol.4 ", "Book", "07-Volume_4.jpg", "978-4-08-881756-9", 2019 },
                    { 8, "Gege Akutami", "Jujutsu Kaisen Vol.5", "Book", "08-Volume_5.jpg", "978-4-08-881828-3", 2019 },
                    { 9, "Gege Akutami", "Jujutsu Kaisen Vol.7", "Book", "09-Volume_7.jpg", "978-4-08-882076-7", 2019 },
                    { 10, "Gege Akutami", "Jujutsu Kaisen Vol.14", "Book", "10-Volume_14.jpg", "978-4-08-882534-2", 2021 },
                    { 11, "Gege Akutami", "Jujutsu Kaisen Vol. 17", "Book", "11-Volume_17.jpg", "978-4-08-882736-0", 2021 },
                    { 12, "Gege Akutami", "Jujutsu Kaisen Vol.22", "Book", "12-Volume_22.jpg", "978-4-08-883434-4", 2023 },
                    { 13, "Eiichiro Oda", "One Piece Vol.85", "Book", "13-Volume_85.jpg", "978-4-08-881070-6", 2017 },
                    { 14, "Eiichiro Oda", "One Piece Vol.86", "Book", "14-Volume_86.jpg", "978-4-08-881198-7", 2017 },
                    { 15, "Eiichiro Oda", "One Piece Vol.87", "Book", "15-Volume_87.jpg", "978-4-08-881225-0", 2017 },
                    { 16, "Eiichiro Oda", "One Piece Vol.88", "Book", "16-Volume_88.jpg", "978-4-08-881362-2", 2018 },
                    { 17, "Eiichiro Oda", "One Piece Vol.89", "Book", "17-Volume_89.jpg", "978-4-08-881496-4", 2018 },
                    { 18, "Eiichiro Oda", "One Piece Vol.90", "Book", "18-Volume_90.jpg", "978-4-08-881562-6", 2018 },
                    { 19, "Eiichiro Oda", "One Piece Vol.91", "Book", "19-Volume_91.jpg", "978-4-08-881644-9", 2018 },
                    { 20, "Eiichiro Oda", "One Piece Vol.92", "Book", "20-Volume_92.jpg", "978-4-08-881758-3", 2019 },
                    { 21, "Eiichiro Oda", "One Piece Vol.93", "Book", "21-Volume_93.jpg", "978-4-08-881877-1", 2019 },
                    { 22, "Eiichiro Oda", "One Piece Vol.94", "Book", "22-Volume_94.jpg", "978-4-08-882054-5", 2019 },
                    { 23, "Eiichiro Oda", "One Piece Vol.95", "Book", "23-Volume_95.jpg", "978-4-08-882169-6", 2019 },
                    { 24, "Eiichiro Oda", "One Piece Vol.96", "Book", "24-Volume_96.jpg", "978-4-08-882252-5", 2020 },
                    { 25, "Eiichiro Oda", "One Piece Vol.97", "Book", "25-Volume_97.jpg", "978-4-08-882347-8", 2020 },
                    { 26, "Eiichiro Oda", "One Piece Vol.98", "Book", "26-Volume_98.jpg", "978-4-08-882423-9", 2021 },
                    { 27, "Eiichiro Oda", "One Piece Vol.99", "Book", "27-Volume_99.jpg", "978-4-08-882691-2", 2021 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
