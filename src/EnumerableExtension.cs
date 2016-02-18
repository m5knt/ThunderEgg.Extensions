/**
 * @brief StringBuffer回り
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値を列挙します</summary>
        public static IEnumerable<int> Range(int end) {
            for (var i = 0; i < end; ++i) yield return i;
        }

        /// <summary>値を列挙します</summary>
        public static IEnumerable<int> Range(int start, int end) {
            if (start < end) {
                for (var i = start; i < end; ++i) yield return i;
            }
            else {
                for (var i = start; i > end; --i) yield return i;
            }
        }

        /// <summary>値を列挙します</summary>
        public static IEnumerable<int> Range(int start, int end, int step) {
            if (start < end) {
                for (var i = start; i < end; i += step) yield return i;
            }
            else {
                for (var i = start; i > end; i += step) yield return i;
            }
        }
    }

    /// <summary>IEnumerable回り</summary>
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

#if false
        /// <summary>値を指定回数繰り返します</summary>
        public static IEnumerable<T> Times<T>(this int self, Func<int, T> func) {
            for (var i = 0; i < self; ++i) yield return func(i);
        }
#endif

    }
}

