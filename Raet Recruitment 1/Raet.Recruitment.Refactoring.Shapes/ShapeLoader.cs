using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    public class ShapeLoader
    {
        public static List<string> Print(List<IShape> shapes)
        {
            var processData = new List<string>();
            if (shapes == null || shapes.Count() == 0)
            {
                processData.Add("Empty list of shapes!");
            }
            else
            {
                // Group results by shape
                processData = (from s in shapes
                              group s by new { Type = s.GetType().Name } into g
                              select g.Key.Type + "(s): " + g.Count() + ", Area: " 
                              + g.Sum(s => s.GetArea()).ToString("#.##") + ", Perimeter: " 
                              + g.Sum(s => s.GetPerimeter()).ToString("#.##")).ToList();
            }
            return processData;
        }


    }
}
