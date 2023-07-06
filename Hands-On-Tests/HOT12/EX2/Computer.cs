using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Computer
    {
        private string _name;
        private string _ipAddress;
        private string _services;

        public Computer(string name, string ipAddress, string services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string Name
        {
            get { return _name; }
        }

        public string IPAddress
        {
            get { return _ipAddress; }
        }

        public string Services
        {
            get { return _services; }
        }
    }
}
