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
    public class LogicTests
    {
        [TestMethod()]
        public void ThrowExceptionTest()
        {
            //Arrange
            Logic exception = new Logic();
            //Act
            exception.ThrowException();
            //Assert en ExpectedException
        }


    }
}
