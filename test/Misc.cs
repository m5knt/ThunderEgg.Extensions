
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

    [TestClass]
    public partial class Misc {

        [TestMethod]
        public void Repeat() {
            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(0.Repeat(3)));
        }

        [TestMethod]
        public void Range() {
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(A.Range(3).ToList()));
            Assert.IsTrue(new[] { 0, 2, 4 }.SequenceEqual(A.Range(0, 5, 2).ToList()));
            Assert.IsTrue(new[] { 0, -1, -2 }.SequenceEqual(A.Range(0, -3, -1).ToList()));
        }

        [TestMethod]
        public void Each() {
            List<int> ret;
            ret = new List<int>();
            A.Range(3).ForEach(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(ret));
            ret = new List<int>();
            A.Range(0, 3).ForEach(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(ret));
            ret = new List<int>();
            A.Range(0, 5, 2).ForEach(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 2, 4 }.SequenceEqual(ret));
            ret = new List<int>();
            A.Range(0, -3, -1).ForEach(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, -1, -2 }.SequenceEqual(ret));
            A.Range(4).Select(_ => _);
        }

    }
}
