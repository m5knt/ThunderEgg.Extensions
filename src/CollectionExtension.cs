﻿using System;
using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class CollectionExtension {

#if false
        public static IList<T> Add<T>(this IList<T> self, IEnumerable<T> collection) {
            foreach (var t in collection) {
                self.Add(t);
            }
            return self;
        }

        public static IList<T> Add<T>(this IList<T> self, T value) {
            self.Add(value);
            return self;
        }
#endif
        /// <summary>例外を投げない辞書登録</summary>
        public static void Update<D, K, V>(this D idictionary, K key, V value)
            where D : IDictionary<K, V> //
        {
            if (idictionary.ContainsKey(key)) {
                idictionary[key] = value;
            }
            else {
                idictionary.Add(key, value);
            }
        }

        //
        //
        //

    }
}
