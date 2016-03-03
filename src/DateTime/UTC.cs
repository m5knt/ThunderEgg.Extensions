/**
 * @file
 * @brief UTC日時を管理する型
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

        /// <summary>UnixTime から等価な値へ変換します</summary>
        public static long Value(this UnixTime self) {
            return (long)self;
        }
    }

    /// <summary>UTC日時を管理する型</summary>
    public struct UTC : IComparable<UTC>, IEquatable<UTC> {

        DateTime data;

        /// <summary>年を返します</summary>
        public int Year { get { return data.Year; } }
        /// <summary>月を返します</summary>
        public int Month { get { return data.Month; } }
        /// <summary>日を返します</summary>
        public int Day { get { return data.Day; } }

        /// <summary>時を返します</summary>
        public int Hour { get { return data.Hour; } }
        /// <summary>分を返します</summary>
        public int Minute { get { return data.Minute; } }
        /// <summary>秒を返します</summary>
        public int Second { get { return data.Second; } }
        /// <summary>ミリ秒を返します</summary>
        public int Millisecond { get { return data.Millisecond; } }

        /// <summary>クロックティックを返す</summary>
        public long Ticks { get { return data.Ticks; } }

        //
        //
        //

        /// <summary>UnixTime でコンストラクトします</summary>
        public UTC(UnixTime ut) : this((long)ut * TimeSpan.TicksPerSecond) {
        }

        /// <summary>クロックティック でコンストラクトします</summary>
        public UTC(long ticks) {
            data = new DateTime(ticks);
        }

        /// <summary>年月日でコンストラクトする</summary>
        public UTC(int year, int month, int day) {
            data = new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Utc);
        }

        /// <summary>年月日時分秒でコンストラクトする</summary>
        public UTC(int year, int month, int day, int hour, int min, int sec) {
            data = new DateTime(year, month, day, hour, min, sec, DateTimeKind.Utc);
        }

        /// <summary>DateTime に変換する</summary>
        public DateTime ToUniversalTime() => data;

        /// <summary>Unixタイムに変換する</summary>
        public UnixTime ToUnixTime() {
            var secs = (data.Ticks - UnixEpoch.Ticks) / TimeSpan.TicksPerSecond;
            return (UnixTime)secs;
        }

        //
        //　演算系
        //

        /// <summary>時間差を返す</summary>
        public static TimeSpan operator -(UTC l, UTC r)=> l.data - r.data;

        /// <summary>時間を足す</summary>
        public static UTC operator +(UTC l, TimeSpan r) => new UTC(l.data.Ticks + r.Ticks);

        /// <summary>時間を引く</summary>
        public static UTC operator -(UTC l, TimeSpan r) => new UTC(l.data.Ticks - r.Ticks);

        //
        //
        //

        /// <summary>現在の日時を返します</summary>
        public static UTC Now { get { return new UTC(DateTime.UtcNow.Ticks); } }

        /// <summary>Unixエポックタイム</summary>
        static DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        //
        // 比較系
        //

        /// <summary>比較結果を返します</summary>
        public int CompareTo(UTC o) => Math.Sign(data.Ticks - o.data.Ticks);
        /// <summary>値が同じか返します</summary>
        public bool Equals(UTC o) => data.Ticks == o.data.Ticks;

        /// <summary>値が同じか返します</summary>
        public override bool Equals(object o) {
            if (!(o is UTC)) return false;
            return data.Ticks == ((UTC)o).data.Ticks;
        }

        /// <summary>ハッシュコードを返します</summary>
        public override int GetHashCode() => data.GetHashCode();

        public static bool operator ==(UTC l, UTC r) => l.data.Ticks == r.data.Ticks;
        public static bool operator !=(UTC l, UTC r) => l.data.Ticks != r.data.Ticks;
        public static bool operator <(UTC l, UTC r) => l.data.Ticks < r.data.Ticks;
        public static bool operator <=(UTC l, UTC r) => l.data.Ticks <= r.data.Ticks;
        public static bool operator >(UTC l, UTC r) => l.data.Ticks > r.data.Ticks;
        public static bool operator >=(UTC l, UTC r) => l.data.Ticks >= r.data.Ticks;
    }
}

