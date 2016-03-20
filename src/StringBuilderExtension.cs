/**
 * @file
 * @brief StringBufferの拡張メソッド
 */

using System;
using System.Text;

namespace ThunderEgg.Extentions {

    /// <summary>StringBufferの拡張メソッド</summary>
    public static class StringBuilderExtension {

        /// <summary>バッファ内容をクリアする</summary>
        public static StringBuilder Clear(this StringBuilder @this) {
            @this.Length = 0;
            return @this;
        }
    }
}

