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
        public static T To<T>(this IConvertible self) {
            var t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;
            try {
                return (T)Convert.ChangeType(self, t);
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
        public static T To<T>(this string self) {
            var t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;
            try {
                if (t.IsEnum) {
                    return (T)Enum.Parse(t, self);
                }
                return (T)Convert.ChangeType(self, t);
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

