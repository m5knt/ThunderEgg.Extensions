using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

    [TestClass]
    public class EnumerableTest {

        [TestMethod]
        public void In() {
            Assert.IsTrue("A".In("A", "B"));
            Assert.IsTrue("A".In(new List<string>() { "A", "B" }));
            Assert.IsTrue(new[] { "A", "B" }.In("A", "B", "C"));
            Assert.IsFalse(new[] { "X", "A" }.In("A", "B", "C"));
        }

        //        [TestMethod]
        //        public void Add() {
        //            Assert.IsTrue(new[] { "A", "A", "B"}.SequenceEqual(new[] { "A" }.Add("A", "B")));
        //        }

    }
}
