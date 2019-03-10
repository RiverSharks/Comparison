using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                // arrange
                var calc = new DiffClass();

                // act
                var res = calc.Sum(2, 5);

                // assert
                Assert.AreEqual(7, res);
            
        }
    }
    }
}
