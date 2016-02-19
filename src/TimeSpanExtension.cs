/**
 * @file
 * @brief TimeSpanの拡張メソッド関係
 * @author Yukio KANEDA
 */

using System;
using System.Runtime.CompilerServices;

namespace ThunderEgg.Extentions {

    /// <summary>TimeSpanの拡張メソッド関係</summary>
    public static partial class TimeSpanExtension {

        /// <summary>時間を返します</summary>
        public static TimeSpan Days(this int n) {
            return new TimeSpan(n, 0, 0, 0);
        }

        /// <summary>時間を返します</summary>
        public static TimeSpan Hours(this int n) {
            return new TimeSpan(n, 0, 0);
        }

        /// <summary>時間を返します</summary>
        public static TimeSpan Minutes(this int n) {
            return new TimeSpan(0, n, 0);
        }

        /// <summary>時間を返します</summary>
        public static TimeSpan Seconds(this int n) {
            return new TimeSpan(0, 0, n);
        }

        /// <summary>時間を返します</summary>
        public static TimeSpan MilliSeconds(this int n) {
            return new TimeSpan(0, 0, 0, 0, n);
        }
    }
}

