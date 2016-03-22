/**
 * @file
 * @brief Empty 操作
 */

using System;
using System.Linq;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>空であるかを返す</summary>
        public static bool IsEmpty<T>(this IEnumerable<T> @this) {
            return !@this.Any();
        }

        /// <summary>Nullか空であるかを返す</summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this) {
            return @this == null || !@this.Any();
        }

        /// <summary>nullなら空を返す</summary>
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> @this) {
            return @this ?? Enumerable.Empty<T>();
        }
    }
}

