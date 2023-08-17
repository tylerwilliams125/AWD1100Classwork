using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2
{
    public class Review : Book
    {
        public int Id { get; set; }
        public int BookNumber { get; set; }
        public string ReviewText { get; set; }

        public Review()
        {

        }

        public override string ToString()
        {
            return "";
        }



    }
}
