using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Review
    {
        public int Id { get; set; }
        public int BookNumber { get; set; } 
        public string ReviewText { get; set; }
       
        public Review()
        {
           
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
