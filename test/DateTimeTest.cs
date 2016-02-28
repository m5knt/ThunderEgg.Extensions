
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

    [TestClass]
    public class DateTimeTest {

        [TestMethod]
        public void DateTime() {
            Assert.AreEqual(new DateTime(2016, 2, 1), new DateTime(2016, 2, 29).FirstDayOfMonth());
            Assert.AreEqual(new DateTime(2016, 2, 29), new DateTime(2016, 2, 1).LastDayOfMonth());
        }
    }
}