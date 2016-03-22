/**
 * @file
 * @brief 計算関係
 */

using System;

namespace ThunderEgg.Extentions {

    /// <summary>計算関係</summary>
    public static class MathExtension {

        /// <summary>無限大であるかを返す</summary>
        /// <seealso cref="float.IsInfinity(float)"/>
        public static bool IsInfinity(this float @this) {
            return float.IsInfinity(@this);
        }

        /// <summary>無限大であるかを返す</summary>
        /// <seealso cref="double.IsInfinity(double)"/>
        public static bool IsInfinity(this double @this) {
            return double.IsInfinity(@this);
        }

        //
        //
        //

        /// <summary>非数であるかを返す</summary>
        /// <seealso cref="float.IsNaN(float)"/>
        public static bool IsNaN(this float @this) {
            return float.IsNaN(@this);
        }

        /// <summary>非数であるかを返す</summary>
        /// <seealso cref="double.IsNaN(double)"/>
        public static bool IsNaN(this double @this) {
            return double.IsNaN(@this);
        }

        //
        //
        //

        /// <summary>負の無限大であるかを返す</summary>
        /// <seealso cref="float.IsNegativeInfinity(float)"/>
        public static bool IsNegativeInfinity(this float @this)
            => float.IsNegativeInfinity(@this);

        /// <summary>負の無限大であるかを返す</summary>
        /// <seealso cref="double.IsNegativeInfinity(double)"/>
        public static bool IsNegativeInfinity(this double @this)
            => double.IsNegativeInfinity(@this);

        //
        //
        //

        /// <summary>正の無限大であるかを返す</summary>
        /// <seealso cref="float.IsPositiveInfinity(float)"/>
        public static bool IsPositiveInfinity(this float @this)
            => float.IsPositiveInfinity(@this);

        /// <summary>正の無限大であるかを返す</summary>
        /// <seealso cref="double.IsPositiveInfinity(double)"/>
        public static bool IsPositiveInfinity(this double @this)
            => double.IsPositiveInfinity(@this);

        //
        //
        //

        /// <summary>小数点以下切り上げを返す</summary>
        /// <seealso cref="Math.Ceiling(double)"/>
        public static double Ceiling(this double @this) {
            return Math.Ceiling(@this);
        }

        /// <summary>小数点以下切り上げを返す</summary>
        /// <seealso cref="Math.Ceiling(decimal)"/>
        public static decimal Ceiling(this decimal @this) {
            return Math.Ceiling(@this);
        }

        /// <summary>小数点以下切り捨てを返す</summary>
        /// <seealso cref="Math.Floor(double)"/>
        public static double Floor(this double @this) {
            return Math.Floor(@this);
        }

        /// <summary>小数点以下切り捨てを返す</summary>
        /// <seealso cref="Math.Floor(decimal)"/>
        public static decimal Floor(this decimal @this) {
            return Math.Floor(@this);
        }

        /// <summary>整数部を返す</summary>
        /// <seealso cref="Math.Truncate(double)"/>
        public static double Truncate(this double @this) {
            return Math.Truncate(@this);
        }

        /// <summary>整数部を返す</summary>
        /// <seealso cref="Math.Truncate(decimal)"/>
        public static decimal Truncate(this decimal @this) {
            return Math.Truncate(@this);
        }

        /// <summary>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(double)"/>
        public static double Round(this double @this) {
            return Math.Round(@this);
        }

        /// <summary>>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(decimal)"/>
        public static decimal Round(this decimal @this) {
            return Math.Round(@this);
        }

        //
        //
        //

        /// <summary>>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(double, MidpointRounding)"/>
        public static double Round(this double @this, MidpointRounding mode) {
            return Math.Round(@this, mode);
        }

        /// <summary>>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(decimal, MidpointRounding)"/>
        public static decimal Round(this decimal @this, MidpointRounding mode) {
            return Math.Round(@this, mode);
        }

        /// <summary>>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(double, int)"/>
        public static double Round(this double @this, int digits) {
            return Math.Round(@this, digits);
        }

        /// <seealso cref="Math.Round(decimal, int)"/>
        public static decimal Round(this decimal @this, int digits) {
            return Math.Round(@this, digits);
        }

        /// <summary>>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(double, int, MidpointRounding)"/>
        public static double Round(this double @this, int digits, MidpointRounding mode) {
            return Math.Round(@this, digits, mode);
        }

        /// <summary>>整数に丸め値を返す</summary>
        /// <seealso cref="Math.Round(decimal, int, MidpointRounding)"/>
        public static decimal Round(this decimal @this, int digits, MidpointRounding mode) {
            return Math.Round(@this, digits, mode);
        }

        //
        //
        //

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(sbyte)"/>
        public static float Abs(this sbyte @this) {
            return Math.Abs(@this);
        }

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(short)"/>
        public static float Abs(this short @this) {
            return Math.Abs(@this);
        }

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(int)"/>
        public static float Abs(this int @this) {
            return Math.Abs(@this);
        }

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(long)"/>
        public static float Abs(this long @this) {
            return Math.Abs(@this);
        }

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(float)"/>
        public static float Abs(this float @this) {
            return Math.Abs(@this);
        }

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(double)"/>
        public static double Abs(this double @this) {
            return Math.Abs(@this);
        }

        /// <summary>絶対値を返す</summary>
        /// <seealso cref="Math.Abs(decimal)"/>
        public static decimal Abs(this decimal @this) {
            return Math.Abs(@this);
        }

        //
        //
        //

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(sbyte)"/>
        public static int Sign(this sbyte @this) {
            return Math.Sign(@this);
        }

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(short)"/>
        public static int Sign(this short @this) {
            return Math.Sign(@this);
        }

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(int)"/>
        public static int Sign(this int @this) {
            return Math.Sign(@this);
        }

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(long)"/>
        public static int Sign(this long @this) {
            return Math.Sign(@this);
        }

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(float)"/>
        public static int Sign(this float @this) {
            return Math.Sign(@this);
        }

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(double)"/>
        public static int Sign(this double @this) {
            return Math.Sign(@this);
        }

        /// <summary>符号(-1, 0, 1)を返す</summary>
        /// <seealso cref="Math.Sign(decimal)"/>
        public static int Sign(this decimal @this) {
            return Math.Sign(@this);
        }
    }
}
