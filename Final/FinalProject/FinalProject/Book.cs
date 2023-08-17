using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Book
    {
        public int BookId { get; set; }

        public string Isbn { get; set; }

        public string BookName { get; set; }

        public int PublishYear { get; set; }

        public string Img { get; set; }

        public Book() { }   
    }
}
