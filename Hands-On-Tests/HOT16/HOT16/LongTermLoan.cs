using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT16
{
    public class LongTermLoan : ILoan
    {
        public string _name;
        public string _type;
        public double _balance;

        public LongTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;

        }

        public string Name
        { get { return _name; } }

        public double Balance
        { get { return _balance; } }

        public string Type => throw new NotImplementedException();

        public LongTermLoan ApplyInterest(string Name, string type, double balance)
        {
            double payment = 200.00;
            double loanDown = balance - payment;
            double interest = balance * 1.05;
            throw new NotImplementedException();
        }

        public LongTermLoan MakePayment(string name, string type, double balance)
        {

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
