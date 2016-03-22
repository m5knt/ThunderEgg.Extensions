/**
 * @file
 * @brief object の拡張メソッド関係
 */

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ThunderEgg.Extentions {

    /// <summary>object の拡張メソッド関係</summary>
    public static class ObjectExtension {

        /// <summary>null であるかを返す</summary>
        public static bool IsNull<T>(this T @this) where T : class {
            return @this == null;
        }

        /// <summary>null であるかを返す</summary>
        public static bool IsNull<T>(this T? @this) where T : struct {
            return !@this.HasValue;
        }
    }
}

