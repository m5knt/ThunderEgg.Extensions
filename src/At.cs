/**
* @file
* @brief At操作
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>指定位置の値を返します</summary>
        public static T At<T>(this IEnumerable<T> enumer, int index) {
            return enumer.ElementAt(index);
        }

        /// <summary>指定位置の値を返します</summary>
        public static T AtOrDefault<T>(this IEnumerable<T> enumer, int index) {
            return enumer.ElementAtOrDefault(index);
        }

        /// <summary>指定キーの値を返します</summary>
        public static T At<K, T>(this IDictionary<K, T> dict, K key) {
            return dict[key];
        }

        /// <summary>指定キーの値を返します</summary>
        public static T AtOrDefault<K, T>(this IDictionary<K, T> dict, K key) {
            try {
                return dict[key];
            }
            catch (KeyNotFoundException) {
            }
            return default(T);
        }

        /// <summary>辞書の値を更新します</summary>
        public static IDictionary<K, T> At<K, T>( //
            this IDictionary<K, T> dict, K key, T value)
        {
            try {
                dict.Add(key, value);
            }
            catch (ArgumentException) {
            }
            return dict;
        }

        //
        //
        //

    }
}
