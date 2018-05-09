namespace Solution {
    using KataExercises;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class KataTests {
        [TestMethod]
        public void TowerBuilderTest() {
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", KataTowerBuilder.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", KataTowerBuilder.TowerBuilder(3)));
        }
    }

    [TestClass]
    public class TortoiseTests {

        [TestMethod]
        public void TortoiseTest() {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(new int[] { 0, 32, 18 }, Tortoise.Race(720, 850, 70));
            Assert.AreEqual(new int[] { 3, 21, 49 }, Tortoise.Race(80, 91, 37));
            Assert.AreEqual(new int[] { 2, 0, 0 }, Tortoise.Race(80, 100, 40));
        }
    }
    [TestClass]

    public class DubstepTests {
        [TestMethod]
        public void DubstepTest1() {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [TestMethod]
        public void DubstepTest2() {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
    [TestClass]
    public class KataTest {
        [TestMethod]
        public void SimplePigLatinTest() {
            Assert.AreEqual("igPay atinlay siay oolcay", KataPigLatin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", KataPigLatin.PigIt("This is my string"));
        }
    }
    [TestClass]
    public class AnagramTest {
        [TestMethod]
        public void AnagramsTest() {
            Assert.AreEqual(new List<string> { "a" }, Anagrams.AnagramsMethod("a", new List<string> { "a", "b", "c", "d" }));
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Anagrams.AnagramsMethod("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
    }
    [TestClass]
    public class SolutionTest {
        [TestMethod]
        public void ZeroFuelTest() {
            Assert.AreEqual(true, FuelExcersise.ZeroFuel(500, 25, 2));
            Assert.AreEqual(false, FuelExcersise.ZeroFuel(400, 500, 1));
        }
    }
}
