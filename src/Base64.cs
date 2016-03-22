/**
 * @file
 * @brief BASE64の拡張メソッド
 */

using System;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>BASE64文字列からバイト配列へ変換します</summary>
        public static byte[] Base64ToBytes(this string @this) {
            return Convert.FromBase64String(@this);
        }

        /// <summary>バイト配列からBASE64文字列へ変換します</summary>
        public static string ToBase64(this byte[] @this) {
            return Convert.ToBase64String(@this);
        }

    }
}

