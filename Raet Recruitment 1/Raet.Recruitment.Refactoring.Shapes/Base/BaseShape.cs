using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
   public abstract class BaseShape : IShape
    {
        public BaseShape(double width)
        {
            this.Width = width;
        }

        public virtual double Width { get; set; }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public virtual double GetWidth()
        {
            return  this.Width;
        }
    }
}
