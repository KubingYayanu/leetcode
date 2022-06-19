using LeetCode.Library.Easy;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Testing.Easy
{
    [TestFixture]
    public class Implement_strStrSolutionTest
    {
        [Test]
        [TestCaseSource(nameof(Cases))]
        public void StrStr_WhenCalled_ReturnIndexes(TestCase testCase)
        {
            var sut = new Implement_strStrSolution();

            var result = sut.StrStr(testCase.Haystack, testCase.Needle);

            Assert.That(result, Is.EqualTo(testCase.Result));
        }

        private static IEnumerable<TestCase> Cases()
        {
            yield return new TestCase
            {
                Haystack = "hello",
                Needle = "ll",
                Result = 2
            };
            yield return new TestCase
            {
                Haystack = "hello",
                Needle = "la",
                Result = -1
            };
            yield return new TestCase
            {
                Haystack = "aaaaa",
                Needle = "bba",
                Result = -1
            };
            yield return new TestCase
            {
                Haystack = "aaa",
                Needle = "aaaa",
                Result = -1
            };
        }

        public class TestCase
        {
            public string Haystack { get; set; }

            public string Needle { get; set; }

            public int Result { get; set; }
        }
    }
}