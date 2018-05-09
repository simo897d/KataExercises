using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataExercises;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void SimpleTests() {
            Assert.AreEqual(24, KatBreakChocolate.BreakChocolate(5, 5));
            Assert.AreEqual(0, KatBreakChocolate.BreakChocolate(1, 1));
        }
    }
}
