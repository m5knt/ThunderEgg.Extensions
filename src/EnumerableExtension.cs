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
                for (var i = start; i < end; ++i) yield return i;
            }
            else {
                for (var i = start; i > end; --i) yield return i;
            }
        }

        /// <summary>数値を列挙します</summary>
        public static IEnumerable<int> Range(int start, int end, int step) {
            if (start < end) {
                for (var i = start; i < end; i += step) yield return i;
            }
            else {
                for (var i = start; i > end; i += step) yield return i;
            }
        }
    }

    /// <summary>Enumerable関係のエクステンションメソッド</summary>
    public static class EnumerableExtension {

        /// <summary>値を指定回数繰り返します</summary>
        public static IEnumerable<T> Repeat<T>(this T self, int limit) {
            for (var i = 0; i < limit; ++i) yield return self;
        }

        /// <summary>値毎に処理をします</summary>
        public static void Do<T>(this IEnumerable<T> e, Action<T> func) {
            foreach (var t in e) func(t);
        }

        /// <summary>値毎に処理をします</summary>
        public static void Do<T>(this IEnumerable<T> e, Action<T, int> func) {
            var i = 0;
            foreach (var t in e) func(t, i++);
        }

        /// <summary>値毎に処理をします</summary>
        public static IEnumerable<E> Do<T, E>(this IEnumerable<T> e, Func<T, E> func) {
            foreach (var t in e) yield return func(t);
        }

        /// <summary>値毎に処理をします</summary>
        public static IEnumerable<E> Do<T, E>(this IEnumerable<T> e, Func<T, int, E> func) {
            var i = 0;
            foreach (var t in e) yield return func(t, i++);
        }

    }
}

