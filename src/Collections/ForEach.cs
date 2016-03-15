/**
 * @file
 * @brief ForEach 操作
 */

using System;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値毎に処理をします</summary>
        public static void ForEach<T>( //
            this IEnumerable<T> @this, Action<T> func) //
        {
            foreach (var t in @this) func(t);
        }

        /// <summary>値毎に処理をします</summary>
        public static void ForEach<T>( //
            this IEnumerable<T> @this, Action<T, int> func) //
        {
            var i = 0;
            foreach (var t in @this) func(t, i++);
        }

    }
}

