/**
 * @file
 * @brief stringの拡張メソッド
 */

using System;
using System.Text;

// using System.Runtime.CompilerServices;
// [MethodImpl(MethodImplOptions.AggressiveInlining)]

namespace ThunderEgg.Extentions {

    /// <summary>stringの拡張メソッド</summary>
    public static class StringExtension {

        #region static methods

        /// <summary>コピーを返す</summary>
        /// <seealso cref="string.Copy(string)"/>
        public static string Copy(this string @this) {
            return string.Copy(@this);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object[])"/>
        public static string format(this string @this, params object[] args) {
            return string.Format(@this, args);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object)"/>
        public static string format(this string @this, object arg0) {
            return string.Format(@this, arg0);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object, object)"/>
        public static string format(this string @this, object arg0, object arg1) {
            return string.Format(@this, arg0, arg1);
        }

        /// <summary>書式から文字列を生成する</summary>
        /// <seealso cref="string.Format(string, object, object, object)"/>
        public static string format(this string @this, object arg0, object arg1, object arg2) {
            return string.Format(@this, arg0, arg1, arg2);
        }

        /// <summary>インターンプールしその文字列を返します</summary>
        /// <seealso cref="string.Intern(string)"/>
        public static string Intern(this string @this) {
            return string.Intern(@this);
        }

        /// <summary>インターンプールされているか返します</summary>
        /// <returns>プールされているなら文字列,プールされてなければnull</returns>
        /// <seealso cref="string.IsInterned(string)"/>
        public static string IsInterned(this string @this) {
            return string.IsInterned(@this);
        }

        /// <summary>ヌルもしくは空文字列であるか返します</summary>
        /// <seealso cref="string.IsNullOrEmpty(string)"/>
        public static bool IsNullOrEmpty(this string @this) {
            return string.IsNullOrEmpty(@this);
        }

        /// <summary>文字列を連結します</summary>
        public static string join(this string @this, params string[] values) {
            return string.Join(@this, values);
        }

        /// <summary>文字列を連結します</summary>
        public static string join(this string @this, string[] values, int start, int count) {
            return string.Join(@this, values, start, count);
        }

        #endregion

        //
        //
        //

        #region option

        /// <summary>BASE64文字列からバイト配列へ変換します</summary>
        /// <seealso cref="Convert.FromBase64String(string)"/>
        public static byte[] Base64ToBytes(this string @this) {
            return Convert.FromBase64String(@this);
        }

        /// <summary>文字数を返します</summary>
        public static int RealLength(this string @this) {
            var count = 0;
            var hi = '\0';
            for (var i = 0; i < @this.Length; ++i) {
                var lo = @this[i];
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

