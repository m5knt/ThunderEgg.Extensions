/**
 * @file
 * @brief In操作
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T self, params T[] vals) {
            return vals.Contains(self);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T self, IEnumerable<T> vals) {
            return vals.Contains(self);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this IEnumerable<T> self, params T[] vals) {
            return self.All(_ => vals.Contains(_));
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>( //
            this IEnumerable<T> self, IEnumerable<T> vals) //
        {
            return self.All(_ => vals.Contains(_));
        }

    }
}

