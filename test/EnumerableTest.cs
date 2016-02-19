
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
        public void Times() {
            //            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(3.Times(() => 0)));
            //            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(3.Times(i => i)));
        }

        [TestMethod]
        public void Do() {
            List<int> ret;
            ret = new List<int>();
            0.Repeat(3).Do(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(ret));
            ret = new List<int>();
            0.Repeat(3).Do((_, i) => ret.Add(i));
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(ret));
            ret = 0.Repeat(3).Do(_ => _).ToList();
            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(ret));
            ret = 0.Repeat(3).Do((_, i) => i).ToList();
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(ret));
        }

        [TestMethod]
        public void Range() {
            List<int> ret;
            ret = new List<int>();
            A.Range(3).Do(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(ret));
            ret = new List<int>();
            A.Range(0, 3).Do(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 1, 2 }.SequenceEqual(ret));
            ret = new List<int>();
            A.Range(0, 5, 2).Do(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, 2, 4 }.SequenceEqual(ret));
            ret = new List<int>();
            A.Range(0, -3, -1).Do(_ => ret.Add(_));
            Assert.IsTrue(new[] { 0, -1, -2 }.SequenceEqual(ret));
            A.Range(4).Select(_ => _);
        }

        [TestMethod]
        public void Repeat() {
            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(0.Repeat(3)));
        }
    }
}
