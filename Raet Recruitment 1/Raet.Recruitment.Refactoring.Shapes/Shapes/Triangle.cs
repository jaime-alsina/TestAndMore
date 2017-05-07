using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    public class Triangle : BaseShape
    {
        public Triangle(double width) : base(width)
        {
        }

        public override double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Width * Width;
        }

        public override double GetPerimeter()
        {
            return 3 * Width;
        }
    }
}
