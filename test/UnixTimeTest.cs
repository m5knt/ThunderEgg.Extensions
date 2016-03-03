
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace test {

    [TestClass]
    public class UnixTimeTest {
#if false
        [TestMethod]
        public void Test() {
            var epoch = UnixTime.Epoch.ToDateTime();
            Assert.AreEqual(0, epoch.Hour);
            Assert.AreEqual(1, epoch.Day);
            Assert.AreEqual(1, epoch.Month);
            Assert.AreEqual(1970, epoch.Year);
            Assert.AreEqual(epoch, epoch.ToUniversalTime().ToUniversalTime());
            Assert.AreEqual(epoch, epoch.ToLocalTime().ToUniversalTime());
            //            Assert.AreEqual(9, epoch.ToLocalTime().ToLocalTime().Hour);

            var now = DateTime.UtcNow;
            Assert.AreEqual(now, now.ToUniversalTime());
            Assert.AreEqual(9,(now.ToLocalTime() - now).Hours);


            Assert.AreEqual(9, DateTime.Now.Subtract(DateTime.UtcNow).Hours);
            var ln = DateTime.Now.ToBinary();
            var un = DateTime.UtcNow.ToBinary();
            ln = ln;
#if false
            var l = epoch.ToLocalTime();
            Assert.AreEqual(9, l.Hour);
            var ll = l.ToLocalTime();
            Assert.AreEqual(9, ll.Hour);
            var now = DateTime.Now;
            var utcnow = DateTime.UtcNow;
            Assert.AreEqual(9, (now - utcnow).Hours);
            var bin = epoch.ToBinary();
            var ticks = epoch.Ticks;
#endif
        }
#endif
    }
}