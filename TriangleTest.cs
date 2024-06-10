using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnitDemonstrationNew;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
