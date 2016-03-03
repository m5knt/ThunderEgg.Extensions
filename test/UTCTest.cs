
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace test {

    [TestClass]
    public class UTCTest {

        [TestMethod]
        public void Equals() {
            var a = new UTC(2016, 2, 29);
            var b = new UTC(2016, 3, 1);
            var c = new UTC(2016, 3, 1);
            Assert.IsTrue(a < b);
            Assert.IsTrue(b > a);
            Assert.IsTrue(b <= c);
            Assert.IsTrue(b >= c);
            Assert.IsTrue(a != b);
            Assert.IsTrue(b == c);
            Assert.AreEqual(false, a.Equals(c));
            Assert.AreEqual(true, b.Equals(c));
            Assert.AreEqual(-1, a.CompareTo(b));
            Assert.AreEqual(1, b.CompareTo(a));
            Assert.AreEqual(0, b.CompareTo(c));
        }

        [TestMethod]
        public void Expresion() {
            var a = new UTC(2016, 2, 29);
            var b = new UTC(2016, 3, 1);
            Assert.AreEqual(b, a + 1.Days());
            Assert.AreEqual(a, b - 1.Days());
            Assert.AreEqual(1.Days(), b - a);
        }

    }
}