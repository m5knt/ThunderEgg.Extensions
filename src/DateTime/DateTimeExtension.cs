﻿/**
 * @file
 * @brief DateTimeの拡張メソッド
 * @author Yukio KANEDA
 */

using System;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>うるう年であるか返す</summary>
        public static bool IsLeapYear(this DateTime @this) {
            return DateTime.IsLeapYear(@this.Year);
        }

        /// <summary>月の初日</summary>
        public static DateTime FirstDayOfMonth(this DateTime @this) {
            var t = 1 - @this.Day;
            return t == 0 ? @this : @this.AddTicks(t * TimeSpan.TicksPerDay);
        }

        /// <summary>月の最終日</summary>
        public static DateTime LastDayOfMonth(this DateTime @this) {
            var t = DateTime.DaysInMonth(@this.Year, @this.Month) - @this.Day;
            return t == 0 ? @this : @this.AddTicks(t * TimeSpan.TicksPerDay);
        }

        /// <summary>週の初日</summary>
        public static DateTime FirstDayOfWeek(this DateTime @this) {
            var t = 0 - (int)@this.DayOfWeek;
            return t == 0 ? @this : @this.AddTicks(t * TimeSpan.TicksPerDay);
        }

        /// <summary>週の最終日</summary>
        public static DateTime LastDayOfWeek(this DateTime @this) {
            var t = 6 - (int)@this.DayOfWeek;
            return t == 0 ? @this : @this.AddTicks(t * TimeSpan.TicksPerDay);
        }
    }
}

