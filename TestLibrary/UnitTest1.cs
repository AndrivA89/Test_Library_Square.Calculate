using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Square;

namespace TestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaCircleRad_10()
        {
            Square.Calculate.Figure circle = new Square.Calculate.Circle(10);
            var testArea = 3.14 * 100;
            Assert.AreEqual((int)testArea, (int)circle.Area());
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestAreaTriangle_A3_B4_C5()
        {
            Square.Calculate.Figure triangle = new Square.Calculate.Triangle(3, 4, 5);
            var testArea = 6;
            Assert.AreEqual((int)testArea, triangle.Area());
            Assert.AreEqual(true, triangle.RightAngled());
        }
    }
}