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
            string Testword1 = "fool";
            string Testword2 = "fouulish";
            string resultMustBe = "fo[uu](o)l[ish]";
            DiffClass diff = new DiffClass();
            diff.SetOnlyStrings(Testword1, Testword2);

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_spring_sprugn()
        {
            // arrange
            string Testword1 = "spring";
            string Testword2 = "sprugn";
            string resultMustBe = "spr[ug](i)n(g)";
            DiffClass diff = new DiffClass();
            diff.SetOnlyStrings(Testword1, Testword2);

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_good_bike()
        {
            // arrange
            string Testword1 = "good";
            string Testword2 = "bike";
            string resultMustBe = "[bike](good)";
            DiffClass diff = new DiffClass();
            diff.SetOnlyStrings(Testword1, Testword2);

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_lil_bil()
        {
            // arrange
            string Testword1 = "lil";
            string Testword2 = "bil";
            string resultMustBe = "[b](l)il";
            DiffClass diff = new DiffClass();
            diff.SetOnlyStrings(Testword1, Testword2);

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_been_oheen()
        {
            // arrange
            string Testword1 = "been";
            string Testword2 = "oheen";
            string resultMustBe = "[oh](b)een";
            DiffClass diff = new DiffClass();
            diff.SetOnlyStrings(Testword1, Testword2);

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_LilPUmP_LIgpuMp()
        {
            // arrange
            string Testword1 = "LilPUmP";
            string Testword2 = "LIgpuMp";
            string resultMustBe = "L[IgpuMp](ilPUmP)";
            DiffClass diff = new DiffClass();
            diff.SetOnlyStrings(Testword1, Testword2);

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

    }
}
