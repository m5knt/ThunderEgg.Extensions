
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace test {

    [TestClass]
    public class NullTest {

        [TestMethod]
        public void Test() {
            ((string)null).ThrowIfArgumentNull("null");
        }
    }
}