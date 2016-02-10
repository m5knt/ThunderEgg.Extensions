/**
 * @brief StringBuffer回り
 */

using System;
using System.Text;

namespace ThunderEgg.Extentions {

    /// <summary>IConvertible回り</summary>
    public static class ConvertibleExtension {

        /// <summary>型変換します</summary>
        public static T To<T>(this IConvertible value) {
            var ty = typeof(T);
            var u = Nullable.GetUnderlyingType(ty);
            if (u != null) {
                try {
                    return (T)Convert.ChangeType(value, u);
                }
                catch {
                    return default(T);
                }
            }
            else {
                return (T)Convert.ChangeType(value, ty);
            }
        }

        /// <summary>型変換します</summary>
        public static T To<T>(this IConvertible value, T or_default) {
            var ty = typeof(T);
            var u = Nullable.GetUnderlyingType(ty);
            if (u != null) {
                try {
                    return (T)Convert.ChangeType(value, ty);
                }
                catch {
                    return default(T);
                }
            }
            else {
                try {
                    return (T)Convert.ChangeType(value, ty);
                }
                catch {
                    return or_default;
                }
            }
        }
    }
}

