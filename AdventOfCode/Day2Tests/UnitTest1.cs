using System.Diagnostics.Tracing;
using App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CharacterCounter _counter = new CharacterCounter();

        [TestMethod]
        public void CharacterCounterReturnsNoneForABCDEF()
        {
            var testString = "abcdef";
            var counts = _counter.CountCharacters(testString);

            Assert.IsFalse(_counter.HasDouble(counts));
            Assert.IsFalse(_counter.HasTriplet(counts));
        }

        [TestMethod]
        public void CharacterCounterReturns1Double1Triple()
        {
            var testString = "bababc";
            var counts = _counter.CountCharacters(testString);

            Assert.IsTrue(_counter.HasDouble(counts));
            Assert.IsTrue(_counter.HasTriplet(counts));
        }
        [TestMethod]
        public void CharacterCounterReturns1Double()
        {
            var testString = "abbcde";
            var counts = _counter.CountCharacters(testString);

            Assert.IsTrue(_counter.HasDouble(counts));
            Assert.IsFalse(_counter.HasTriplet(counts));
        }
        [TestMethod]
        public void SingleTriple()
        {
            var testString = "abcccd";
            var counts = _counter.CountCharacters(testString);
            
            Assert.IsFalse(_counter.HasDouble(counts));
            Assert.IsTrue(_counter.HasTriplet(counts));
        }

        [TestMethod]
        public void TwoDoublesCountsOnce()
        {
            var testString = "aabcdd";
            var counts = _counter.CountCharacters(testString);


            Assert.IsTrue(_counter.HasDouble(counts));
            Assert.IsFalse(_counter.HasTriplet(counts));
        }
        [TestMethod]
        public void SingleDouble()
        {
            var testString = "abcdee";
            var counts = _counter.CountCharacters(testString);

            Assert.IsTrue(_counter.HasDouble(counts));
            Assert.IsFalse(_counter.HasTriplet(counts));
        }
        [TestMethod]
        public void DoubleTriplets()
        {
            var testString = "ababab";
            var counts = _counter.CountCharacters(testString);

            Assert.IsFalse(_counter.HasDouble(counts));
            Assert.IsTrue(_counter.HasTriplet(counts));
        }
    }
}
