/**
 * @file
 * @brief Repeat操作
 */

using System;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値を指定回数繰り返します</summary>
        public static IEnumerable<T> Repeat<T>(this T @this, int repeat) {
            while (--repeat >= 0) yield return @this;
        }
    }
}

