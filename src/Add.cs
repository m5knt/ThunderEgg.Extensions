/**
 * @file
 * @brief Add操作
 */

using System.Collections.Generic;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>値をコレクションに足します</summary>
        public static ICollection<T> Add<T>( //
            this ICollection<T> @this, params T[] vals) //
        {
            for (var i = 0; i < vals.Length; ++i) @this.Add(vals[i]);
            return @this;
        }

        /// <summary>値をコレクションに足します</summary>
        public static ICollection<T> Add<T>( //
            this ICollection<T> @this, IEnumerable<T> vals) //
        {
            foreach (var t in vals) @this.Add(t);
            return @this;
        }
    }
}
