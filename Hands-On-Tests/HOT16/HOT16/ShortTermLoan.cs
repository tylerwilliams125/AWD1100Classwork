using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT16
{
    public class ShortTermLoan : ILoan
    {
        public string _name;
        public string _type;
        public double _balance;

        public ShortTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;

        }

        public string Name
        { get { return _name; } }

        public double Balance
        { get { return _balance; } }

        public string Type
        { get { return _type; } }

        public ShortTermLoan ApplyInterest(string Name, string type, double balance)
        {

            double interest = balance * 1.10;
            throw new NotImplementedException();
        }

        public ShortTermLoan MakePayment(string name, string type, double balance)
        {
            double payment = 450.00;
            double loanDown = balance - payment;
            throw new NotImplementedException();
        }

        void ILoan.ApplyInterest(string name, string type, double balance)
        {
            throw new NotImplementedException();
        }

        void ILoan.MakePayment(string name, string type, double balance)
        {
            throw new NotImplementedException();
        }
    }
}
