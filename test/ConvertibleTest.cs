using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {
    [TestClass]
    public class ConvertibleTest {

        public enum Foo {
            One = 1,
            Two,
            Three
        }

        [TestMethod]
        public void To() {

            // numerics <=> string
            Assert.AreEqual((byte)255, 255.To<byte>());
            Assert.AreEqual(0, 256.To<byte>());
            Assert.AreEqual(null, 256.To<byte?>());
            Assert.AreEqual("1", 1.To<string>());
            Assert.AreEqual(1, "1".To<int>());
            Assert.AreEqual(0, "".To<int>());
            Assert.AreEqual("1.1", 1.1.To<string>());
            Assert.AreEqual(1.1, "1.1".To<double>());
            Assert.AreEqual(0.0, "".To<double>());

            // nullable <=> string
            Assert.AreEqual(null, "null".To<int?>());
            Assert.AreEqual(1, "1".To<int?>());
            Assert.AreEqual(1, "1".To<int?>());
            Assert.AreEqual(null, "".To<int?>());
            Assert.AreEqual(1.1, 1.1.To<double?>());
            Assert.AreEqual(1.1, "1.1".To<double?>());
            Assert.AreEqual(null, "".To<double?>());

            // enum
            Assert.AreEqual("One", Foo.One.To<string>());
            Assert.AreEqual(Foo.One, "One".To<Foo>());
            Assert.AreEqual(Foo.One, "1".To<Foo>());
            Assert.AreEqual((Foo)0, "a".To<Foo>());
            Assert.AreEqual(null, "a".To<Foo?>());
        }
    }
}
