/**
 * @file
 * @brief DateTimeの拡張メソッド関係
 * @author Yukio KANEDA
 */

using System;
using System.Runtime.CompilerServices;

namespace ThunderEgg.Extentions {

    /// <summary>Unixタイム</summary>
    public enum UnixTime : long {
        Epoch
    }

    public static partial class A {

        /// <summary>Unixエポックタイム</summary>
        static DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        /// <summary>UnixTimeから等価な値へ変換します</summary>
        public static long Value(this UnixTime self) {
            return (long)self;
        }

        /// <summary>UnixTimeから日付へ変換します</summary>
        public static DateTime ToDateTime(this UnixTime self) {
            return UnixEpoch + TimeSpan.FromTicks(TimeSpan.TicksPerSecond * (long)self);
        }

        /// <summary>日付からUnixTimeへ変換します</summary>
        public static UnixTime ToUnixTime(this DateTime self) {
            return (UnixTime)((self - UnixEpoch).Ticks / TimeSpan.TicksPerSecond);
        }

    }
}

