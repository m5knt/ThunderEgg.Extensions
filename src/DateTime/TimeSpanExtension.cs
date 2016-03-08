/**
 * @file
 * @brief TimeSpanの拡張メソッド
 * @author Yukio KANEDA
 */

using System;

namespace ThunderEgg.Extentions {

    /// <summary>TimeSpanの拡張メソッド</summary>
    public static partial class TimeSpanExtension {

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Weeks(this int weeks) {
            var ticks = TimeSpan.TicksPerDay * 7 * weeks;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Days(this int days) {
            var ticks = TimeSpan.TicksPerDay * days;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Hours(this int hours) {
            var ticks = TimeSpan.TicksPerHour * hours;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Minutes(this int mins) {
            var ticks = TimeSpan.TicksPerMinute * mins;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Seconds(this int secs) {
            var ticks = TimeSpan.TicksPerSecond * secs;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan MilliSeconds(this int msecs) {
            var ticks = TimeSpan.TicksPerMillisecond * msecs;
            return TimeSpan.FromTicks(ticks);
        }

        //
        //
        //

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Weeks(this long weeks) {
            var ticks = TimeSpan.TicksPerDay * 7 * weeks;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Days(this long days) {
            var ticks = TimeSpan.TicksPerDay * days;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Hours(this long hours) {
            var ticks = TimeSpan.TicksPerHour * hours;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Minutes(this long mins) {
            var ticks = TimeSpan.TicksPerMinute * mins;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Seconds(this long secs) {
            var ticks = TimeSpan.TicksPerSecond * secs;
            return TimeSpan.FromTicks(ticks);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan MilliSeconds(this long msecs) {
            var ticks = TimeSpan.TicksPerMillisecond * msecs;
            return TimeSpan.FromTicks(ticks);
        }

        //
        //
        //

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Seconds(this float secs) {
            return TimeSpan.FromSeconds(secs);
        }

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Seconds(this double secs) {
            return TimeSpan.FromSeconds(secs);
        }

    }
}

