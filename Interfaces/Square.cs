using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Square : Rectangle
    {
        public double Side
        {
            get { return Width; }
            set { Width = Height = value; } // Ensures both Width and Height are set to the same value
        }


    }
}
