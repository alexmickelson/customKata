using customKata;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { }, "0-99")]
        [TestCase(new int[] { 0 }, "1-99")]
        [TestCase(new int[] { 99 }, "0-98")]
        [TestCase(new int[] { 5 }, "0-4,6-99")]
        [TestCase(new int[] { 5, 20 }, "0-4,6-19,21-99")]
        [TestCase(new int[] { 5, 20, 50 }, "0-4,6-19,21-49,51-99")]
        [TestCase(new int[] { 5, 20, 50, 99 }, "0-4,6-19,21-49,51-98")]
        [TestCase(new int[] { 0, 5, 20, 50, 99 }, "1-4,6-19,21-49,51-98")]
        public void emptyArray(int[] incoming, string expected)
        {

            var actual = Kata.FindMissingNums(incoming);
            Assert.AreEqual(expected, actual);
        }
    }
}