using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

    [TestClass]
    public class ConvertibleTest {

        public class Base { }

        public class Derived : Base { } 

        public enum Foo {
            One = 1,
            Two,
            Three
        }

        [TestMethod]
        public void To() {
            // numerics
            Assert.AreEqual(1, "1".To<int>());
            Assert.AreEqual(1.1, "1.1".To<double>());
            Assert.AreEqual("1", 1.To<string>());
            Assert.AreEqual("1.1", 1.1.To<string>());
            // bool
            Assert.AreEqual("True", true.To<string>());
            Assert.AreEqual("False", false.To<string>());
            Assert.AreEqual(true, "true".To<bool>());
            Assert.AreEqual(false, "false".To<bool>());
            // datetime
            Assert.AreEqual(new DateTime(1234, 5, 6, 11, 22, 33, 444), "1234/5/6 11:22:33.444".To<DateTime>());
            Assert.AreEqual("1234/05/06 11:22:33", new DateTime(1234, 5, 6, 11, 22, 33).To<string>()); // ミリ秒は無視される
            // enum
            Assert.AreEqual("One", Foo.One.To<string>());
            Assert.AreEqual(Foo.One, "One".To<Foo>());
            Assert.AreEqual(Foo.One, "1".To<Foo>());
            // default (format exception)
            Assert.AreEqual(null, "".To<bool?>()); // format exception
            Assert.AreEqual(null, "256".To<byte?>()); // overflow exception
            Assert.AreEqual(null, ((string)null).To<int?>());
        }
    }
}
