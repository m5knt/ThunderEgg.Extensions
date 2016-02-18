using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;

namespace ThunderEgg.Extentions {

    public static partial class CollectionExtension {

//        public static string Join(this IEnumerable<string> values, string sepa) {
//            return string.Join(sepa, values.ToArray());
//        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T x, params T[] lists) {
            return lists.Contains(x);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this T x, IEnumerable<T> lists) {
            return lists.Contains(x);
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this IEnumerable<T> x, params T[] lists) {
            return x.All(_ => lists.Contains(_));
        }

        /// <summary>値が含まれているか返します</summary>
        public static bool In<T>(this IEnumerable<T> x, IEnumerable<T> lists) {
            return x.All(_ => lists.Contains(_));
        }


        /// <summary>値をコレクションに足します</summary>
        public static C Add<C, V>(this C c, params V[] values)
            where C : ICollection<V>
        {
            for (var i = 0; i < values.Length; ++i) c.Add(values[i]);
            return c;
        }

        /// <summary>値をコレクションに足します</summary>
        public static C Add<C, V>(this C c, IEnumerable<V> values)
            where C : ICollection<V>
        {
            foreach (var t in values) c.Add(t);
            return c;
        }

        //
        //
        //

        /// <summary>辞書の値を更新します</summary>
        public static void Update<D, K, V>(this D x, K key, V value)
            where D : IDictionary<K, V> //
        {
            if (x.ContainsKey(key)) {
                x[key] = value;
            }
            else {
                x.Add(key, value);
            }
        }

        //
        //
        //

    }
}
