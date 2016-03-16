/**
 * @file
 * @brief In 操作
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T @this, params T[] vals) {
            return vals.Contains(@this);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T @this, IEnumerable<T> vals) {
            return vals.Contains(@this);
        }
    }
}

