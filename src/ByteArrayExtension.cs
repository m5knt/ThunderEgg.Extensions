/**
 * @file
 * @brief byteのエクステンションメソッド
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
        public static string BytesToBase64(this byte[] @this) { 
            return Convert.ToBase64String(@this);
        }

        /// <summary>UTF8バイト配列から文字列へ変換します</summary>
        public static string Utf8BytesToString(this byte[] @this) { 
            return Encoding.UTF8.GetString(@this);
        }

        /// <summary>ArraySegmentへ変換します</summary>
        public static ArraySegment<byte> //
            ToArraySegment(this byte[] @this, int offset, int count) //
        { 
            return new ArraySegment<byte>(@this, offset, count);
        }
    }
}

