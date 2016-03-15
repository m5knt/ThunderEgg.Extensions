/**
 * @file
 * @brief Cast 操作
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>IEnumeratorをIEnumerable<T>へ変換する</summary>
        public static IEnumerable<T> Cast<T>(this IEnumerator @this) {
            while (@this.MoveNext()) {
                yield return (T)@this.Current;
            }
        }

        /// <summary>IEnumeratorをIEnumerable<T>へ変換する</summary>
        public static IEnumerable<T> Cast<T>(this IEnumerator<T> @this) {
            while (@this.MoveNext()) {
                yield return @this.Current;
            }
        }
    }
}

