/**
 * @file
 * @brief Concat 操作
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>IEnumerator を連結します</summary>
        public static IEnumerator //
            Concat(this IEnumerator @this, IEnumerator follow) //
        {
            while (@this.MoveNext()) yield return @this.Current;
            while (follow.MoveNext()) yield return follow.Current;
        }

        /// <summary>IEnumerator<T> を連結します</summary>
        public static IEnumerator<T> //
            Concat<T>(this IEnumerator<T> @this, IEnumerator<T> follow) //
        {
            while (@this.MoveNext()) yield return @this.Current;
            while (follow.MoveNext()) yield return follow.Current;
        }
    }
}

