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
        public static T At<T>(this IEnumerable<T> self, int index) {
            return self.ElementAt(index);
        }

        /// <summary>指定位置の値を返します</summary>
        public static T AtOrDefault<T>(this IEnumerable<T> self, int index) {
            return self.ElementAtOrDefault(index);
        }

        /// <summary>指定キーの値を返します</summary>
        public static T At<K, T>(this IDictionary<K, T> self, K key) {
            return self[key];
        }

        /// <summary>指定キーの値を返します</summary>
        public static T AtOrDefault<K, T>(this IDictionary<K, T> self, K key) {
            try {
                return self[key];
            }
            catch (KeyNotFoundException) {
            }
            return default(T);
        }

        /// <summary>辞書の値を更新します</summary>
        public static IDictionary<K, T> At<K, T>( //
            this IDictionary<K, T> self, K key, T value)
        {
            try {
                self.Add(key, value);
            }
            catch (ArgumentException) {
            }
            return self;
        }

        //
        //
        //

    }
}
