using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class Fill
    {
        [TestMethod]
        public void Fill_Should_Fill()
        {
            //Arrange
            var source = new int[4];
            var expected = new int[] { 1, 1, 1, 1 };

            //Act
            ArrayHelpers.Fill(source, 1);

            //Assert
            Assert.AreEqual(expected.Count(number => number == 1), source.Count(number => number == 1));
        }
    }
}
