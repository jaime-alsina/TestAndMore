using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Raet.Recruitment.Refactoring.Shapes
{
    [TestClass()]
    public class ShapeTest
    {
        private List<IShape> _shapes;

        [TestInitialize]
        public void Initialize()
        {
            _shapes = new List<IShape>();
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void givenNull_whenPrint_thenReturnEmptyMessage()
        {
            Assert.AreEqual("Empty list of shapes!", ShapeLoader.Print(_shapes)[0]);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void givenEmptyList_whenPrint_thenReturnEmptyMessage()
        {
            Assert.AreEqual("Empty list of shapes!", ShapeLoader.Print(_shapes)[0]);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void givenOneSquare_whenPrint_thenReturnShapePrint()
        {
            _shapes.Add(new Square(2));
            Assert.AreEqual("Square(s): 1, Area: 4, Perimeter: 8", ShapeLoader.Print(_shapes)[0]);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void givenOneShapePerType_whenPrint_thenReturnOrderedShapesPrint()
        {
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Square(1));
            _shapes.Add(new Circle(2));
            var processShapes = ShapeLoader.Print(_shapes);

            Assert.AreEqual("Triangle(s): 1, Area: 3.9, Perimeter: 9", processShapes[0]);
            Assert.AreEqual("Square(s): 1, Area: 1, Perimeter: 4", processShapes[1]);
            Assert.AreEqual("Circle(s): 1, Area: 3.14, Perimeter: 6.28", processShapes[2]);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void givenMultipleShapes_whenPrint_thenReturnOrderedSumShapesPrint()
        {
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));

            var processShapes = ShapeLoader.Print(_shapes);

            Assert.AreEqual("Square(s): 2, Area: 10, Perimeter: 16", processShapes[0]);
            Assert.AreEqual("Triangle(s): 3, Area: 32.04, Perimeter: 36", processShapes[1]);
            Assert.AreEqual("Circle(s): 4, Area: 25.92, Perimeter: 34.56", processShapes[2]);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void givenLotsOfShapes_whenPrint_thenReturnOrderedSumShapesPrint()
        {
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));

            var processShapes = ShapeLoader.Print(_shapes);

            Assert.AreEqual("Square(s): 16, Area: 80, Perimeter: 128", processShapes[0]);
            Assert.AreEqual("Triangle(s): 24, Area: 256.34, Perimeter: 288", processShapes[1]);
            Assert.AreEqual("Circle(s): 32, Area: 207.35, Perimeter: 276.46", processShapes[2]);
        }
    }
}
