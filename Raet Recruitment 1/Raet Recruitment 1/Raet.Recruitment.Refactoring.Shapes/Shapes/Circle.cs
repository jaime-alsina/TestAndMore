using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    public class Circle : BaseShape
    {
        public Circle(double width) : base(width)
        {
        }

        public override double GetArea()
        {
            return Math.PI * (Width / 2) * (Width / 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI * Width;
        }

        public override double GetWidth()
        {
            return Math.PI * (Width / 2) * (Width / 2);
        }
    }
}
