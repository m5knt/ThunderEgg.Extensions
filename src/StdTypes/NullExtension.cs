/**
 * @file
 * @brief null 関連の拡張メソッド
 */

using System;

namespace ThunderEgg.Extentions {

    /// <summary>null 関連の拡張メソッド</summary>
    public static class NullExtension {

        /// <summary>null であるかを返す</summary>
        public static bool IsNull<T>(this T @this) where T : class {
            return @this == null;
        }

        /// <summary>null であるかを返す</summary>
        public static bool IsNull<T>(this T? @this) where T : struct {
            return @this == null;
        }

        /// <summary>null なら例外を投げる</summary>
        public static void ThrowIfArgumentNull<T>(this T @this, string message) //
            where T : class //
        {
            if (@this != null) return;
            throw new ArgumentNullException(message);
        }

        /// <summary>null なら例外を投げる</summary>
        public static void ThrowIfArgumentNull<T>(this T? @this, string message) //
            where T : struct //
        {
            if (@this != null) return;
            throw new ArgumentNullException(message);
        }
    }
}

