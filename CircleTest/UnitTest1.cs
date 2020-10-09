using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;

namespace CircleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //исходные данные
            double radius = 2.5;
            double result = 15.7;

            //полученное значение
            double length = Circle.Circle.GetLengthOfCircle(radius);

            Assert.AreEqual(result, length, 0.02);

        }
    }
}
