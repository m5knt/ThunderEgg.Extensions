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
        public static bool In<T>(this T value, params T[] lists) {
            return lists.Contains(value);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T value, IEnumerable<T> lists) {
            return lists.Contains(value);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this IEnumerable<T> vals, params T[] lists) {
            return vals.All(_ => lists.Contains(_));
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this IEnumerable<T> vals, IEnumerable<T> lists) {
            return vals.All(_ => lists.Contains(_));
        }

    }
}

