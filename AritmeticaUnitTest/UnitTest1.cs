using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitarias;

namespace AritmeticaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumaTestMethod()
        {
            double result = Aritmetica.sumar(2.5, 2.5);

            Assert.AreEqual(5.0, result);

        }

        [TestMethod]
        public void MultiplicarTestMethod()
        {
            double result = Aritmetica.multiplicar(5.0, 3.0);

            Assert.AreEqual(15.0, result);

        }

    }
}
