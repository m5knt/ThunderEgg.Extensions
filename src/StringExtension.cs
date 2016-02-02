/**
 * @file
 * @brief 文字列回りのシュガー
 * @auther Yukio KANEDA
 */

using System;
using System.Text;

// using System.Runtime.CompilerServices;
// [MethodImpl(MethodImplOptions.AggressiveInlining)]

namespace ThunderEgg.Extentions {

    /// <summary>stringの拡張メソッド関係</summary>
    public static class StringExtension {

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
        /// <seealso cref="string.Join(string, string[])"/>
        public static string Join(this string separator, string[] value) {
            return string.Join(separator, value);
        }

        /// <summary>文字列を連結します</summary>
        /// <seealso cref="string.Join(string, string[], int, int)"/>
        public static string Join(this string separator, string[] value, int startIndex, int count) {
            return string.Join(separator, value, startIndex, count);
        }

        //
        //
        //

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToByte(string)"/>
        public static byte ToUInt8(this string self) {
            return Convert.ToByte(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToUInt16(string)"/>
        public static UInt16 ToUInt16(this string self) {
            return Convert.ToUInt16(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToUInt32(string)"/>
        public static UInt32 ToUInt32(this string self) {
            return Convert.ToUInt32(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToUInt64(string)"/>
        public static UInt64 ToUInt64(this string self) {
            return Convert.ToUInt64(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToSByte(string)"/>
        public static sbyte ToInt8(this string self) {
            return Convert.ToSByte(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToInt16(string)"/>
        public static Int16 ToInt16(this string self) {
            return Convert.ToInt16(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToInt32(string)"/>
        public static Int32 ToInt32(this string self) {
            return Convert.ToInt32(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToInt64(string)"/>
        public static Int64 ToInt64(this string self) {
            return Convert.ToInt64(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToByte(string, int)"/>
        public static byte ToUInt8(this string self, int fbase) {
            return Convert.ToByte(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToUInt16(string, int)"/>
        public static UInt16 ToUInt16(this string self, int fbase) {
            return Convert.ToUInt16(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToUInt32(string, int)"/>
        public static UInt32 ToUInt32(this string self, int fbase) {
            return Convert.ToUInt32(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToUInt64(string, int)"/>
        public static UInt64 ToUInt64(this string self, int fbase) {
            return Convert.ToUInt64(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToSByte(string, int)"/>
        public static sbyte ToInt8(this string self, int fbase) {
            return Convert.ToSByte(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToInt16(string, int)"/>
        public static Int16 ToInt16(this string self, int fbase) {
            return Convert.ToInt16(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToInt32(string, int)"/>
        public static Int32 ToInt32(this string self, int fbase) {
            return Convert.ToInt32(self, fbase);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToInt64(string, int)"/>
        public static Int64 ToInt64(this string self, int fbase) {
            return Convert.ToInt64(self, fbase);
        }

        /// <summary>論理値へ変換します</summary>
        /// <seealso cref="Convert.ToBoolean(string)"/>
        public static bool ToBoolean(this string self) {
            return Convert.ToBoolean(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToSingle(string)"/>
        public static float ToSingle(this string self) {
            return Convert.ToSingle(self);
        }

        /// <summary>数値へ変換します</summary>
        /// <seealso cref="Convert.ToDouble(string)"/>
        public static double ToDouble(this string self) {
            return Convert.ToDouble(self);
        }

        /// <summary>BASE64文字列からバイト配列へ変換します</summary>
        /// <seealso cref="Convert.FromBase64String(string)"/>
        public static byte[] Base64Bytes(this string self) {
            return Convert.FromBase64String(self);
        }

        /// <summary>UTF8バイト配列へ変換します</summary>
        public static byte[] Utf8Bytes(this string self) {
            return Encoding.UTF8.GetBytes(self);
        }
    }
}

