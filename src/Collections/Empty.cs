/**
 * @file
 * @brief Empty 操作
 */

using System;
using System.Linq;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>nullなら空を返す</summary>
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> @this) {
            return @this ?? Enumerable.Empty<T>();
        }
    }
}

