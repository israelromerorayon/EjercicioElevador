using EjercicioElevador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace EjercicioElevadorTest
{
    [TestClass]
    public class OutButtonBoxTest
    {
        [TestMethod]
        public void ShowOutPanelTest5()
        {
            OutButtonBox outPanel = new OutButtonBox(5);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                outPanel.ShowOutPanel();

                var result = sw.ToString().Trim();

                Assert.AreEqual("---- Select destination floor ----\r\n---- Options ----\r\n------ 1 ------\r\n------ 2 ------\r\n------ 3 ------\r\n------ 4 ------\r\n------ 5 ------", result);
            }
        }

        public void ShowOutPanelTest1()
        {
            OutButtonBox outPanel = new OutButtonBox(5);
        }

        public void ShowOutPanelTestElse()
        {
            OutButtonBox obj = new OutButtonBox(3);

        }
    }
}
