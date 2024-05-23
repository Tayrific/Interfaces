using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Rectangle : IShape
    {
        public double Height {  get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double perimeter()
        {
            return (2 * Height) + (2 * Width);
        }
    }
}
