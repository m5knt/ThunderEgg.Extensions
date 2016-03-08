/**
 * @file
 * @brief 文字回りのシュガー
 * @auther Yukio KANEDA
 */

using System;
using System.Globalization;

namespace ThunderEgg.Extentions {

    /// <summary>char型用のエクステンション</summary>
    public static class CharExtension {

        /// <summary>文字を倍精度値で返す</summary>
        /// <seealso cref="char.GetNumericValue(char)"/>
        public static double GetNumericValue(this char @this) {
            return char.GetNumericValue(@this);
        }

        /// <summary>文字のユニコードカテゴリを返す</summary>
        /// <seealso cref="char.GetUnicodeCategory(char)"/>
        public static UnicodeCategory GetUnicodeCategory(this char @this) {
            return char.GetUnicodeCategory(@this);
        }

        /// <summary>制御文字であるかを返す</summary>
        /// <seealso cref="char.IsControl(char)"/>
        public static bool IsControl(this char @this) {
            return char.IsControl(@this);
        }

        /// <summary>数字であるかを返す</summary>
        /// <seealso cref="char.IsDigit(char)"/>
        public static bool IsDigit(this char @this) {
            return char.IsDigit(@this);
        }

        /// <summary>上位サロゲートであるかを返す</summary>
        /// <seealso cref="char.IsHighSurrogate(char)"/>
        public static bool IsHighSurrogate(this char @this) {
            return char.IsHighSurrogate(@this);
        }

        /// <summary>文字であるかを返す</summary>
        /// <seealso cref="char.IsLetter(char)"/>
        public static bool IsLetter(this char @this) {
            return char.IsLetter(@this);
        }

        /// <summary>文字または数字であるかを返す</summary>
        /// <seealso cref="char.IsLetterOrDigit(char)"/>
        public static bool IsLetterOrDigit(this char @this) {
            return char.IsLetterOrDigit(@this);
        }

        /// <summary>小文字であるかを返す</summary>
        /// <seealso cref="char.IsLower(char)"/>
        public static bool IsLower(this char @this) {
            return char.IsLower(@this);
        }

        /// <summary>下位サロゲートであるか返す</summary>
        /// <seealso cref="char.IsLowSurrogate(char)"/>
        public static bool IsLowSurrogate(this char @this) {
            return char.IsLowSurrogate(@this);
        }

        /// <summary>数字であるかを返す</summary>
        /// <seealso cref="char.IsNumber(char)"/>
        public static bool IsNumber(this char @this) {
            return char.IsNumber(@this);
        }

        /// <summary>区切り文字であるかを返す</summary>
        /// <seealso cref="char.IsPunctuation(char)"/>
        public static bool IsPunctuation(this char @this) {
            return char.IsPunctuation(@this);
        }

        /// <summary>区切り文字であるかを返す</summary>
        /// <seealso cref="char.IsSeparator(char)"/>
        public static bool IsSeparator(this char @this) {
            return char.IsSeparator(@this);
        }

        /// <summary>サロゲートコード単位を持つか</summary>
        /// <seealso cref="char.IsSurrogate(char)"/>
        public static bool IsSurrogate(this char @this) {
            return char.IsSurrogate(@this);
        }

        /// <summary>記号であるかを返す</summary>
        /// <seealso cref="char.IsSymbol(char)"/>
        public static bool IsSymbol(this char @this) {
            return char.IsSymbol(@this);
        }

        /// <summary>大文字であるかを返す</summary>
        /// <seealso cref="char.IsUpper(char)"/>
        public static bool IsUpper(this char @this) {
            return char.IsUpper(@this);
        }

        /// <summary>空白であるかを返す</summary>
        /// <seealso cref="char.IsWhiteSpace(char)"/>
        public static bool IsWhiteSpace(this char @this) {
            return char.IsWhiteSpace(@this);
        }

        /// <summary>カレントカルチャ規則で小文字化して返す</summary>
        /// <seealso cref="char.ToLower(char)"/>
        public static char ToLower(this char @this) {
            return char.ToLower(@this);
        }
#if false
        /// <summary>指定カルチャ規則で小文字化して返す</summary>
        /// <seealso cref="char.ToLower(char, CultureInfo)"/>
        public static char ToLower(this char c, CultureInfo culture) {
            return char.ToLower(c, culture);
        }
#endif
        /// <summary>インバリアントカルチャ規則で小文字化して返す</summary>
        /// <seealso cref="char.ToLowerInvariant(char)"/>
        public static char ToLowerInvariant(this char @this) {
            return char.ToLowerInvariant(@this);
        }

        /// <summary>文字列にして返す</summary>
        /// <seealso cref="char.ToString(char)"/>
        public static string ToString(this char @this) {
            return char.ToString(@this);
        }

        /// <summary>カレントカルチャ規則で大文字化して返す</summary>
        /// <seealso cref="char.ToUpper(char)"/>
        public static char ToUpper(this char @this) {
            return char.ToUpper(@this);
        }

#if false
        /// <summary>指定カルチャ規則で大文字化して返す</summary>
        /// <seealso cref="char.ToUpper(char, CultureInfo)"/>
        public static char ToUpper(this char c, CultureInfo culture) {
            return char.ToUpper(c, culture);
        }
#endif
        /// <summary>インバリアントカルチャ規則で大文字化して返す</summary>
        /// <seealso cref="char.ToUpperInvariant(char)"/>
        public static char ToUpperInvariant(this char @this) {
            return char.ToUpperInvariant(@this);
        }
    }
}
