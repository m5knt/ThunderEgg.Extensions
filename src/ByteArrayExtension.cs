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

        /// <summary>ArraySegmentへ変換します</summary>
        public static ArraySegment<byte> //
            ToArraySegment(this byte[] @this, int offset, int count) //
        { 
            return new ArraySegment<byte>(@this, offset, count);
        }
    }
}

