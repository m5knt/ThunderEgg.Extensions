/**
 * @brief StringBuffer回り
 */

using System;
using System.Text;

namespace ThunderEgg.Extentions {

    /// <summary>IConvertible回り</summary>
    public static class ConvertibleExtension {

        /// <summary>値の型を変換します</summary>
        /// <returns>型を変換した値</returns>
        public static T To<T>(this IConvertible self) {
            var t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;
            try {
                return (T)Convert.ChangeType(self, t);
            }
            catch {
                return default(T);
            }
        }

        /// <summary>値の型を変換します</summary>
        /// <param name="default">失敗時の値</param>
        /// <returns>型を変換した値</returns>
        public static T To<T>(this IConvertible self, T @default) {
            var t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;
            try {
                return (T)Convert.ChangeType(self, t);
            }
            catch {
                return @default;
            }
        }
    }
}

