/**
 * @file
 * @brief Add操作
 */

using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値をコレクションに足します</summary>
        public static ICollection<T> Add<T>( //
            this ICollection<T> self, params T[] vals) //
        {
            for (var i = 0; i < vals.Length; ++i) self.Add(vals[i]);
            return self;
        }

        /// <summary>値をコレクションに足します</summary>
        public static ICollection<T> Add<T>( //
            this ICollection<T> self, IEnumerable<T> vals) //
        {
            foreach (var t in vals) self.Add(t);
            return self;
        }
    }
}
