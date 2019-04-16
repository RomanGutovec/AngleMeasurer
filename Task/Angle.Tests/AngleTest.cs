using NUnit.Framework;
using System;

namespace Angle.Tests
{
    [TestFixture]
    public class AngleTest
    {
        [TestCase(2, 20, ExpectedResult = 50)]
        [TestCase(10, 16, ExpectedResult = 148)]
        [TestCase(5, 24, ExpectedResult = 18)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(7, 0, ExpectedResult = 150)]
        [TestCase(6, 0, ExpectedResult = 180)]
        public int AngleTestMethod_InPutData_ReturnsAngleBetweenArrows(int hour, int minutes)
        {
            Measurer angle = new Measurer();

            return angle.MeasureAngle(hour, minutes);
        }

        [TestCase(-15, 20)]
        [TestCase(10, 61)]
        [TestCase(25, 59)]
        [TestCase(26, -1)]
        public void AngleTestMethod_InputInvalidData_ReturnsArgumentException(int hours, int minutes)
        => Assert.Throws<ArgumentException>(() => new Measurer().MeasureAngle(hours, minutes));
    }
}
