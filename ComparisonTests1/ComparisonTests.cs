using Comparison;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComparisonTests1
{
    [TestClass]
    public class TestDifferences
    {
        [TestMethod]
        public void Differences_between_fool_fouulish ()
        {
            // arrange
            string firstTestWord = "fool";
            string secondTestWord = "fouulish";
            string resultMustBe = "fo[uu](o)l[ish]";
            //diff.SetOnlyStrings(firstTestWord, secondTestWord);

            // act
            string res = DiffClass.GetStringOfDiff(firstTestWord, secondTestWord);

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_spring_sprugn()
        {
            // arrange
            string firstTestWord = "spring";
            string secondTestWord = "sprugn";
            string resultMustBe = "spr[ug](i)n(g)";

            // act
            string res = DiffClass.GetStringOfDiff(firstTestWord, secondTestWord);

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_selete_delete()
        {
            // arrange
            string firstTestWord = "selete";
            string secondTestWord = "delete";
            string resultMustBe = "[d](s)elete";

            // act
            string res = DiffClass.GetStringOfDiff(firstTestWord, secondTestWord);

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_lil_bil()
        {
            // arrange
            string firstTestWord = "lil";
            string secondTestWord = "bil";
            string resultMustBe = "[b](l)il";

            // act
            string res = DiffClass.GetStringOfDiff(firstTestWord, secondTestWord);

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_been_oheen()
        {
            // arrange
            string firstTestWord = "been";
            string secondTestWord = "oheen";
            string resultMustBe = "[oh](b)een";

            // act
            string res = DiffClass.GetStringOfDiff(firstTestWord, secondTestWord);

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_LilPUmP_LIgpuMp()
        {
            // arrange
            string firstTestWord = "LilPUmP";
            string secondTestWord = "LIgpuMp";
            string resultMustBe = "L[IgpuMp](ilPUmP)";
          

            // act
            string res = DiffClass.GetStringOfDiff(firstTestWord, secondTestWord);

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

    }
}
