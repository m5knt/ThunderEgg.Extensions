/**
 * @file
 * @brief Enumerable関係のエクステンションメソッド
 */

using System;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>数値を列挙します</summary>
        public static IEnumerable<int> Range(int end) {
            for (var i = 0; i < end; ++i) yield return i;
        }

        /// <summary>数値を列挙します</summary>
        public static IEnumerable<int> Range(int start, int end) {
            if (start < end) {
                for (; start < end; ++start) yield return start;
            }
            else {
                for (; start > end; --start) yield return start;
            }
        }

        /// <summary>数値を列挙します</summary>
        public static IEnumerable<int> Range(int start, int end, int step) {
            if (start < end && step > 0) {
                for (; start < end; start += step) yield return start;
            }
            else if (start > end && step < 0) {
                for (; start > end; start += step) yield return start;
            }
            else {
                throw new ArgumentException();
            }
        }
    }

    /// <summary>Enumerable関係のエクステンションメソッド</summary>
    public static class EnumerableExtension {

        /// <summary>値を指定回数繰り返します</summary>
        public static IEnumerable<T> Repeat<T>(this T t, int limit) {
            for (var i = 0; i < limit; ++i) yield return t;
        }

        /// <summary>値毎に処理をします</summary>
        public static void Do<T>(this IEnumerable<T> e, Action<T> f) {
            foreach (var t in e) f(t);
        }

        /// <summary>値毎に処理をします</summary>
        public static void Do<T>(this IEnumerable<T> e, Action<T, int> f) {
            var i = 0;
            foreach (var t in e) f(t, i++);
        }

    }
}

