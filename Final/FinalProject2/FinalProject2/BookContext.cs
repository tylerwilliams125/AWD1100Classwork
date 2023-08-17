using FinalProject2;
using Microsoft.EntityFrameworkCore;

namespace FinalProject2
{
    class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }

        //	For helping set up the Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BooksDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        //  Creating our database table data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //	Adding 54 reviews (2 per book) to Reviews Table. These are just random sentences.
           
            //	Adding 27 Books to Books Table 
            modelBuilder.Entity<Book>().HasData(
                 new Book { BookId = 1, Isbn = "978-8861230767", AuthorName = "Boichi", BookName = "Sun Ken Rock Vol.1", PublishYear = 2006, Img = "01-Ken.jpg" },
                 new Book { BookId = 2, Isbn = "978-1-9747-0261-9", AuthorName = "Boichi", BookName = "Dr. Stone Vol.1", PublishYear = 2017, Img = "02-DrStone.jpg" },
                 new Book { BookId = 3, Isbn = "978-1-64-729287-4", AuthorName = "Boichi", BookName = "Origin", PublishYear = 2016, Img = "03-Origin_(manga)_1.png" },
                 new Book { BookId = 4, Isbn = "978-4-08-881672-2", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen 0", PublishYear = 2017, Img = "04-Jujutsu_Kaisen_0_Cover.png" },
                 new Book { BookId = 5, Isbn = "978-4-08-882168-9", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.8", PublishYear = 2020, Img = "05-Volume_8.jpg" },
                 new Book { BookId = 6, Isbn = "978-4-08-881516-9", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.1", PublishYear = 2018, Img = "06-Volume_1.jpg" },
                 new Book { BookId = 7, Isbn = "978-4-08-881756-9", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.4 ", PublishYear = 2019, Img = "07-Volume_4.jpg" },
                 new Book { BookId = 8, Isbn = "978-4-08-881828-3", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.5", PublishYear = 2019, Img = "08-Volume_5.jpg" },
                 new Book { BookId = 9, Isbn = "978-4-08-882076-7", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.7", PublishYear = 2019, Img = "09-Volume_7.jpg" },
                 new Book { BookId = 10, Isbn = "978-4-08-882534-2", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.14", PublishYear = 2021, Img = "10-Volume_14.jpg" },
                 new Book { BookId = 11, Isbn = "978-4-08-882736-0", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol. 17", PublishYear = 2021, Img = "11-Volume_17.jpg" },
                 new Book { BookId = 12, Isbn = "978-4-08-883434-4", AuthorName = "Gege Akutami", BookName = "Jujutsu Kaisen Vol.22", PublishYear = 2023, Img = "12-Volume_22.jpg" },
                 new Book { BookId = 13, Isbn = "978-4-08-881070-6", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.85", PublishYear = 2017, Img = "13-Volume_85.jpg" },
                 new Book { BookId = 14, Isbn = "978-4-08-881198-7", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.86", PublishYear = 2017, Img = "14-Volume_86.jpg" },
                 new Book { BookId = 15, Isbn = "978-4-08-881225-0", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.87", PublishYear = 2017, Img = "15-Volume_87.jpg" },
                 new Book { BookId = 16, Isbn = "978-4-08-881362-2", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.88", PublishYear = 2018, Img = "16-Volume_88.jpg" },
                 new Book { BookId = 17, Isbn = "978-4-08-881496-4", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.89", PublishYear = 2018, Img = "17-Volume_89.jpg" },
                 new Book { BookId = 18, Isbn = "978-4-08-881562-6", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.90", PublishYear = 2018, Img = "18-Volume_90.jpg" },
                 new Book { BookId = 19, Isbn = "978-4-08-881644-9", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.91", PublishYear = 2018, Img = "19-Volume_91.jpg" },
                 new Book { BookId = 20, Isbn = "978-4-08-881758-3", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.92", PublishYear = 2019, Img = "20-Volume_92.jpg" },
                 new Book { BookId = 21, Isbn = "978-4-08-881877-1", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.93", PublishYear = 2019, Img = "21-Volume_93.jpg" },
                 new Book { BookId = 22, Isbn = "978-4-08-882054-5", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.94", PublishYear = 2019, Img = "22-Volume_94.jpg" },
                 new Book { BookId = 23, Isbn = "978-4-08-882169-6", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.95", PublishYear = 2019, Img = "23-Volume_95.jpg" },
                 new Book { BookId = 24, Isbn = "978-4-08-882252-5", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.96", PublishYear = 2020, Img = "24-Volume_96.jpg" },
                 new Book { BookId = 25, Isbn = "978-4-08-882347-8", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.97", PublishYear = 2020, Img = "25-Volume_97.jpg" },
                 new Book { BookId = 26, Isbn = "978-4-08-882423-9", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.98", PublishYear = 2021, Img = "26-Volume_98.jpg" },
                 new Book { BookId = 27, Isbn = "978-4-08-882691-2", AuthorName = "Eiichiro Oda", BookName = "One Piece Vol.99", PublishYear = 2021, Img = "27-Volume_99.jpg" }
                );
        }
    }
}
