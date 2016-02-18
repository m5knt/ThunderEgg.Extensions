/**
 * @file
 * @brief 文字列回りの拡張メソッド
 * @auther Yukio KANEDA
 */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// using System.Runtime.CompilerServices;
// [MethodImpl(MethodImplOptions.AggressiveInlining)]

namespace ThunderEgg.Extentions {

    /// <summary>stringの拡張メソッド関係</summary>
    public static class StringExtension {

        #region static methods

        /// <summary>コピーを返す</summary>
        /// <seealso cref="string.Copy(string)"/>
        public static string Copy(this string self) {
            return string.Copy(self);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object[])"/>
        public static string format(this string format, params object[] args) {
            return string.Format(format, args);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object)"/>
        public static string format(this string format, object arg0) {
            return string.Format(format, arg0);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object, object)"/>
        public static string format(this string format, object arg0, object arg1) {
            return string.Format(format, arg0, arg1);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object, object, object)"/>
        public static string format(this string format, object arg0, object arg1, object arg2) {
            return string.Format(format, arg0, arg1, arg2);
        }

        /// <summary>インターンプールしその文字列を返します</summary>
        /// <seealso cref="string.Intern(string)"/>
        public static string Intern(this string self) {
            return string.Intern(self);
        }

        /// <summary>インターンプールされているか返します</summary>
        /// <returns>プールされているなら文字列,プールされてなければnull</returns>
        /// <seealso cref="string.IsInterned(string)"/>
        public static string IsInterned(this string self) {
            return string.IsInterned(self);
        }

        /// <summary>ヌルもしくは空文字列であるか返します</summary>
        /// <seealso cref="string.IsNullOrEmpty(string)"/>
        public static bool IsNullOrEmpty(this string self) {
            return string.IsNullOrEmpty(self);
        }

        /// <summary>文字列を連結します</summary>
        public static string join(this string separator, params string[] values) {
            return string.Join(separator, values);
        }

        /// <summary>文字列を連結します</summary>
        public static string join(this string separator, string[] values, int start, int count) {
            return string.Join(separator, values, start, count);
        }

        #endregion

        //
        //
        //

        #region option

        /// <summary>BASE64文字列からバイト配列へ変換します</summary>
        /// <seealso cref="Convert.FromBase64String(string)"/>
        public static byte[] Base64ToBytes(this string self) {
            return Convert.FromBase64String(self);
        }

        /// <summary>UTF8バイト配列へ変換します</summary>
        public static byte[] ToUtf8Bytes(this string self) {
            return Encoding.UTF8.GetBytes(self);
        }

        /// <summary>文字数を返します</summary>
        public static int RealLength(this string self) {
            var count = 0;
            var hi = '\0';
            for(var i = 0; i < self.Length; ++i) {
                var lo = self[i];
                if (!char.IsSurrogatePair(hi, lo)) {
                    hi = lo;
                    ++count;
                }
            }
            return count;
        }

        #endregion

    }
}

