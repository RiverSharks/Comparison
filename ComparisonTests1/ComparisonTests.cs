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
            diff.Text1 = Testword1;
            diff.Text2 = Testword2;
            //diff.SetOnlyStrings(Testword1, Testword2);

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
            diff.Text1 = Testword1;
            diff.Text2 = Testword2;

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

        [TestMethod]
        public void Differences_between_selete_delete()
        {
            // arrange
            string Testword1 = "selete";
            string Testword2 = "delete";
            string resultMustBe = "[d](s)elete";
            DiffClass diff = new DiffClass();
            diff.Text1 = Testword1;
            diff.Text2 = Testword2;

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
            diff.Text1 = Testword1;
            diff.Text2 = Testword2;

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
            diff.Text1 = Testword1;
            diff.Text2 = Testword2;

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
            diff.Text1 = Testword1;
            diff.Text2 = Testword2;

            // act
            string res = diff.GetStringOfDiff();

            // assert
            Assert.AreEqual(resultMustBe, res);
        }

    }
}
