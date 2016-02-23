/**
 * @file
 * @brief Add操作
 */

using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値をコレクションに足します</summary>
        public static ICollection<T> Add<T>( //
            this ICollection<T> colection, params T[] vals) //
        {
            for (var i = 0; i < vals.Length; ++i) colection.Add(vals[i]);
            return colection;
        }

        /// <summary>値をコレクションに足します</summary>
        public static ICollection<T> Add<T>( //
            this ICollection<T> collection, IEnumerable<T> vals) //
        {
            foreach (var t in vals) collection.Add(t);
            return collection;
        }
    }
}
