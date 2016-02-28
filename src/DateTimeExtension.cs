/**
 * @file
 * @brief DateTimeの拡張メソッド関係
 * @author Yukio KANEDA
 */

using System;
using System.Runtime.CompilerServices;

namespace ThunderEgg.Extentions {

    public static partial class A {

        /// <summary>Unixエポック</summary>
        static DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        /// <summary>月の初日</summary>
        public static DateTime FirstDayOfMonth(this DateTime self) {
            var t = 1 - self.Day;
            return t == 0 ? self : self.AddDays(t);
        }

        /// <summary>月の晦日</summary>
        public static DateTime LastDayOfMonth(this DateTime self) {
            var t = DateTime.DaysInMonth(self.Year, self.Month) - self.Day;
            return t == 0 ? self : self.AddDays(t);
        }

        public static DateTime 
    }
}

