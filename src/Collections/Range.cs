/**
 * @file
 * @brief 任意の範囲の数値を列挙
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
            //Comparer<T>.Default
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

        /// <summary>任意の値を列挙します</summary>
        public static IEnumerable<T> //
            Range<T>(Func<T> start, Func<T, bool> is_cont,  Func<T, T> step) //
        {
            for (var t = start(); is_cont(t); t = step(t)) yield return t;
        }
    }

