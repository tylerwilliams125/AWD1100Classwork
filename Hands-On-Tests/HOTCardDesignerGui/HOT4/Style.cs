using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT4
{
    public class Style
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Image Image { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
