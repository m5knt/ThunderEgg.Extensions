﻿/**
 * @file
 * @brief byteのエクステンションメソッド
 * @auther Yukio KANEDA
 */

using System;
using System.Text;

// using System.Runtime.CompilerServices;
// [MethodImpl(MethodImplOptions.AggressiveInlining)]

namespace ThunderEgg.Extentions {

    /// <summary>byteの拡張メソッド関係</summary>
    public static class ByteArrayExtension {

        /// <summary>バイト配列からBASE64文字列へ変換します</summary>
        /// <seealso cref="Convert.ToBase64String(byte[])"/>
        public static string BytesToBase64(this byte[] self) {
            return Convert.ToBase64String(self);
        }

        /// <summary>UTF8バイト配列から文字列へ変換します</summary>
        public static string Utf8BytesToString(this byte[] self) {
            return Encoding.UTF8.GetString(self);
        }

        /// <summary>ArraySegmentへ変換します</summary>
        public static ArraySegment<byte> ToArraySegment(this byte[] self, int offset, int count) {
            return new ArraySegment<byte>(self, offset, count);
        }
    }
}

