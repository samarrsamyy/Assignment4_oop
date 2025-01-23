using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_oop.Assignment
{
    internal class Duration
    {
        public Duration() { }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            totalSeconds = (hours*3600) +(minutes*60) + seconds;
        }

        public Duration(int input)
        {
            Hours = input / 3600;
            Minutes = (input % 3600) / 60;
            Seconds = input % 60;
            totalSeconds = input;
        }

        public int Hours { get; set; }
        public int Minutes {  get; set; }
        public int Seconds { get; set; }

        public int totalSeconds { get; set; }

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}\nTotalSeconds = {totalSeconds}";
            return $" Minutes: {Minutes}, Seconds: {Seconds}\nTotalSeconds = {totalSeconds}";
        }

        public override bool Equals(object? obj)
        {
            if(obj != null && obj is Duration)
            {
                Duration d = (Duration)obj ;
                if(d.totalSeconds == this.totalSeconds)
                    return true ;
            }
            return false ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours,Minutes,Seconds);
        }

        #region 4-Implement All required Operators overloading to enable this Code:

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration ((d1?.totalSeconds ?? 0) + (d2?.totalSeconds ?? 0));
        }

        public static Duration operator +(Duration d1 , int seconds)
        {
            return new Duration((d1?.totalSeconds ?? 0) + seconds);
        }
        public static Duration operator +( int seconds , Duration d1)
        {
            return d1 + seconds;
        }

        public static Duration operator ++( Duration d1)
        {
            return new Duration((d1?.totalSeconds ?? 0) + 60);
        }

        public static Duration operator --(Duration d1)
        {
            return new Duration((d1?.totalSeconds ?? 0) - 60);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration((d1?.totalSeconds ?? 0) - (d2?.totalSeconds ?? 0));
        }


        public static bool operator >(Duration left , Duration right)
        {
            if (left.totalSeconds > right.totalSeconds )
                return true;

            return false;
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.totalSeconds < right.totalSeconds)
                return true;
            return false;
        }

        public static bool operator <=(Duration left, Duration right)
        {
            if (left.totalSeconds <= right.totalSeconds)
                return true;
            return false;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left.totalSeconds >= right.totalSeconds)
                return true;
            return false;
        }

        public static bool operator true(Duration d)
        {
            return d.totalSeconds > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.totalSeconds <= 0;
        }


        // casting
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(d.totalSeconds);
        }

        #endregion

    }
}
