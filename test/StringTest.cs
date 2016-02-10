using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {
    [TestClass]
    public class StringTest {

        [TestMethod]
        public void Copy() {
            var s = "A";
            var a = "A".Copy();
            Assert.AreEqual(s, a);
            Assert.AreNotSame(s, a);
        }

        [TestMethod]
        public void Format() {
            var a = "";
            a = "{0}".format("0");
            Assert.AreEqual("0", a);
            a = "{0}{1}".format(0, 1);
            Assert.AreEqual("01", a);
            a = "{0}{1}{2}".format(0, 1, 2);
            Assert.AreEqual("012", a);
            a = "{0}{1}{2}{3}".format(0, 1, 2, 3);
            Assert.AreEqual("0123", a);
        }

        [TestMethod]
        public void To() {
            Assert.AreEqual(1, "1".To<int>());
            Assert.AreEqual(1, 1.1.To<int>());

            Assert.AreEqual(null, ((string)null).To<int?>());
            Assert.AreEqual(null, "".To<int?>());
            Assert.AreEqual(null, "a".To<int?>());

            Assert.AreEqual(1, "a".To<int>(1));
        }


        [TestMethod]
        public void Join() {
            var a = "a".join(new[] { "1", "2","3" }, 1, 2);
            Assert.AreEqual("2a3", a);
            a = "a".join("0", "1", "2");
            Assert.AreEqual("0a1a2", a);
        }

        [TestMethod]
        public void Etc() {
            Assert.IsFalse("a".IsNullOrEmpty());
            Assert.IsTrue("".IsNullOrEmpty());
            Assert.IsTrue(((string)null).IsNullOrEmpty());
        }

        [TestMethod]
        public void Intern() {
            Assert.AreSame(string.Intern("ABC"), "ABC".Intern());
            Assert.AreSame(string.Intern("ABC"), "ABC".IsInterned());
            string str1 = "a";
            Assert.AreEqual("a", str1.IsInterned());
            string str2 = str1 + "b";
            Assert.AreEqual("ab", str2.IsInterned());
            string str3 = str2 + "c";
            Assert.AreEqual(null, str3.IsInterned());
        }

        [TestMethod]
        public void Base64() {
            var src = new byte[] { 0xaa, 0x55 };
            var a = System.Convert.ToBase64String(src);
            var b = src.BytesToBase64();
            Assert.IsTrue(a.SequenceEqual(b));
            var x = System.Convert.FromBase64String(a);
            var y = b.Base64ToBytes();
            Assert.IsTrue(x.SequenceEqual(y));
        }

        [TestMethod]
        public void RealLength() {
            Assert.AreEqual(1, "薙".RealLength());
            Assert.AreEqual(2, "aあ".RealLength());
        }
    }
}
