using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT16
{
    public interface ILoan
    {
        public void MakePayment(string name, string type, double balance);

        public void ApplyInterest(string name, string type, double balance);



        public string Name { get; }
        public string Type { get; }
        public double Balance { get; }
    }
}
