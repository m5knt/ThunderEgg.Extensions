
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThunderEgg.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace test {

    [TestClass]
    public class ConcatTest {

        IEnumerator Foo(List<int> a, int start, int end) {
            for (var i = start; i < end; ++i) {
                a.Add(i);
                yield return null;
            }
        }

        IEnumerator<int> Bar(int start, int end) {
            for (var i = start; i < end; ++i) yield return i;
        }

        [TestMethod]
        public void Test() {
            var e = new List<int>();
            for (var t = Foo(e, 0, 3).Concat(Foo(e, 1, 3)); t.MoveNext();) ;
            Assert.IsTrue(new[] { 0, 1, 2, 1, 2}.SequenceEqual(e));
            e.Clear();
            for (var t = Bar(0, 3).Concat(Bar(1, 3)); t.MoveNext();) {
                e.Add(t.Current);
            }
            Assert.IsTrue(new[] { 0, 1, 2, 1, 2 }.SequenceEqual(e));

            //foreach (var t in Bar(0, 1)) ;
            //foreach(var t in Foo(e, 0, 3).ToEnumerable());
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
    }
}