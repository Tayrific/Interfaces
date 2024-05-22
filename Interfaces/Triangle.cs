using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Triangle : iShape
    {
        public double height { get; set; }
        public double length {get; set; }

        public double Area()
        {
            return 0.5 * height * length;
        }

        public double perimeter()
        {
            return (3*length);
        }
    }
}
