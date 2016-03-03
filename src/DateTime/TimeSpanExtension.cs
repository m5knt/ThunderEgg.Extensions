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

        /// <summary>時間(TimeSpan)を返します</summary>
        public static TimeSpan Ticks(this long ticks) {
            return TimeSpan.FromTicks(ticks);
        }
    }
}

