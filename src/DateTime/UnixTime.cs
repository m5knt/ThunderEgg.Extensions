/**
 * @file
 * @brief Unix時間を管理する型
 * @author Yukio KANEDA
 */

using System;

namespace ThunderEgg.Extentions {

    /// <summary>Unix時間</summary>
    public enum UnixTime : long {
        Epoch
    }

    public static partial class A {

        /// <summary>Unixエポック時間</summary>
        static DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>UnixTimeへ変換します</summary>
        public static UnixTime ToUnixTime(this int @this) {
            return (UnixTime)@this;
        }

        /// <summary>UnixTimeへ変換します</summary>
        public static UnixTime ToUnixTime(this long @this) {
            return (UnixTime)@this;
        }

        public static UnixTime ToUnixTime(this DateTime @this) {
            var secs = (@this.Ticks - UnixEpoch.Ticks) / TimeSpan.TicksPerSecond;
            return (UnixTime)secs;
        }

        /// <summary>UnixTime から等価な値へ変換します</summary>
        public static long Value(this UnixTime @this) {
            return (long)@this;
        }

        /// <summary>ローカル時間に変換する</summary>
        public static DateTime ToLocalTime(this UnixTime @this) {
            var ticks = UnixEpoch.Ticks + (long)@this * TimeSpan.TicksPerSecond;
            return new DateTime(ticks, DateTimeKind.Local);
        }

        /// <summary>UTC時間に変換する</summary>
        public static DateTime ToUniversalTime(this UnixTime @this) {
            var ticks = UnixEpoch.Ticks + (long)@this * TimeSpan.TicksPerSecond;
            return new DateTime(ticks, DateTimeKind.Utc);
        }
    }
}

