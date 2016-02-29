
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

    public partial class Misc {

        [TestMethod]
        public void Add() {
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(new List<int> { 0 }.Add(1, 2)));
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(new List<int> { 0 }.Add(new[] { 1, 2 })));
        }
    }
}