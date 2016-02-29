
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

    [TestClass]
    public class UnixTimeTest {

        [TestMethod]
        public void Test() {
            var epoch = UnixTime.Epoch.ToDateTime();
            Assert.AreEqual(1, epoch.Day);
            Assert.AreEqual(1, epoch.Month);
            Assert.AreEqual(1970, epoch.Year);
            Assert.AreEqual(UnixTime.Epoch, new DateTime(1970, 1, 1).ToUnixTime());
        }
    }
}