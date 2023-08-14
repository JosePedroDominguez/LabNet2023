using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrecticaDosPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecticaDosPOO.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod()]
        public void DivisionIngresadaTest()
        {
            //Arrange
            Division div = new Division();
            int dividendo = 10;
            int divisor = 2;
            int resultadoEsperado = 5;

            //Act
            int resultado = div.DivisionIngresada(dividendo, divisor);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);

        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPorCeroTest()
        {
            //Arrange
            Division dm = new Division();
            int numero = 2;

            //Act
            dm.DivisionPorCero(numero);
            //Assert en ExpectedException
        }
    }
}
