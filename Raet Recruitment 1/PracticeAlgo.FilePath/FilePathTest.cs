using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeAlgo.FilePath
{
    [TestClass()]
    public class FilePathTest
    {
        [TestMethod]
        public void givenParentChild_whenNavigateUpDown_thenReturnsTheParentChild()
        {
            // arrenge
            Path path = new Path("/a/b/c/d");
            //act
            var actual = path.Cd("../x");
            //Assert
            Assert.AreEqual("/a/b/c/x", actual);
        }
    }
}
