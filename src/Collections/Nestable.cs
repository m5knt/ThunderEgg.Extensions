/**
 * @file
 * @brief Repeat 操作
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>入れ子可能化にします</summary>
        public static IEnumerator Nestable(this IEnumerator @this) {
            while (@this.MoveNext()) {
                var ret = @this.Current;
                if (ret == null) {
                    yield return null;
                }
                else if (ret is IEnumerator) {
                    @this = Concat((IEnumerator)ret, @this);
                }
                else {
                    yield return ret;
                }
            }
        }
    }

