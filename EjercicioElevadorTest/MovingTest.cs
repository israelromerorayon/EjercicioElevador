using EjercicioElevador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace EjercicioElevadorTest
{
    [TestClass]
    public class MovingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var currentFloor = 1;
            var destinationFloor = 5;

            var expected = new StringBuilder();

            for (int i = currentFloor; i <= destinationFloor; i++)
            {
                expected.Append( ".. " + i + " ..\r\n");
            }

            Moving mov = new Moving(currentFloor, destinationFloor);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                mov.ShowMovement();

                var result = sw.ToString().Trim();

                Assert.AreEqual(expected.ToString().Trim(), result);
            }
        }
    }
}
