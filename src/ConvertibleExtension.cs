/**
 * @brief StringBuffer回り
 */

using System;
using System.Globalization;
using System.Text;

namespace ThunderEgg.Extentions {

    /// <summary>IConvertible回り</summary>
    public static class ConvertibleExtension {

        /// <summary>型変換します</summary>
        /// <returns>型変換した値 / 失敗時は default(T) を返します</returns>
        public static T To<T>(this IConvertible @this) {
            var t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;
            try {
                return (T)Convert.ChangeType(@this, t);
            }
            catch (InvalidCastException) {
                return default(T);
            }
            catch (FormatException) {
                return default(T);
            }
            catch (OverflowException) {
                return default(T);
            }
        }

        /// <summary>型変換します</summary>
        /// <returns>型変換した値 / 失敗時は default(T) を返します</returns>
        public static T To<T>(this string @this) {
            var t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;
            try {
                if (t.IsEnum) {
                    return (T)Enum.Parse(t, @this);
                }
                return (T)Convert.ChangeType(@this, t);
            }
            catch (InvalidCastException) {
                return default(T);
            }
            catch (FormatException) {
                return default(T);
            }
            catch (OverflowException) {
                return default(T);
            }
        }
    }
}

