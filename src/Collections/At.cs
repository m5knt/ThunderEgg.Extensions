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
        public static T At<T>(this IEnumerable<T> @this, int index) {
            return @this.ElementAt(index);
        }

        /// <summary>指定位置の値を返します</summary>
        public static T AtOrDefault<T>(this IEnumerable<T> @this, int index) {
            return @this.ElementAtOrDefault(index);
        }

        /// <summary>指定キーの値を返します</summary>
        public static T At<K, T>(this IDictionary<K, T> @this, K key) {
            return @this[key];
        }

        /// <summary>指定キーの値を返します</summary>
        public static T AtOrDefault<K, T>(this IDictionary<K, T> @this, K key) {
            try {
                return @this[key];
            }
            catch (KeyNotFoundException) {
            }
            return default(T);
        }

        /// <summary>辞書の値を更新します</summary>
        public static IDictionary<K, T> At<K, T>( //
            this IDictionary<K, T> @this, K key, T value) {
            try {
                @this.Add(key, value);
            }
            catch (ArgumentException) {
            }
            return @this;
        }

        //
        //
        //

    }
}
