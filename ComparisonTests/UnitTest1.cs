using Comparison;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ComparisonTests
{
    [TestClass]
    public class TestDifferences
    {
        

        [TestMethod]
        public void Differences_between_fool_fouulish_()
        {
            DiffClass diff = new DiffClass("", "");
            PrivateObject obj = new PrivateObject(diff);
            var retVal = obj.Invoke("PrivateMethod");
            Assert.AreEqual(retVal);
            // arrange
            string Testword1 = "fool";
            string Testword2 = "fouulish";
            string resultMustBe = "fo[uu](o)l[ish]";
            

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);

        }


    }
    
}
