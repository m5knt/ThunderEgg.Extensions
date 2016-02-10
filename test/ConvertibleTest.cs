using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {
    [TestClass]
    public class ConvertibleTest {

        [TestMethod]
        public void To() {

            Assert.AreEqual(1, "1".To<int>());
            Assert.AreEqual(1, 1.1.To<int>());

            Assert.AreEqual(1, "1".To<int?>());
            Assert.AreEqual(null, ((string)null).To<int?>());
            Assert.AreEqual(null, "".To<int?>());
            Assert.AreEqual(null, "a".To<int?>());

            Assert.AreEqual(1, "a".To<int>(1));

            try { "".To<int>(); Assert.Fail(); } catch (Exception e) { }
            try { ((string)null).To<int>(); Assert.Fail(); } catch (Exception e) { }
        }
    }
}
