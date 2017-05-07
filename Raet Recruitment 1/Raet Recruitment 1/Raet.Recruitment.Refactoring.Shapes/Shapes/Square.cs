using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    public class Square : BaseShape
    {
        public Square(double width) : base(width)
        {
        }

        public override double GetArea()
        {
            return Width * Width;
        }

        public override double GetPerimeter()
        {
            return 4 * Width;
        }

    }
}
