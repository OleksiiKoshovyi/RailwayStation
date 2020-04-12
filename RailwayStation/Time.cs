using System;

namespace RailwayStation
{
    class Time : IComparable<Time>
    {      
        public Time(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        public Time(Time other)
        {
            this.Hour = other.Hour;
            this.Minute = other.Minute;
        }

        public Time()
        {
            DateTime time = new DateTime();
            hour = time.Hour;
            minute = time.Minute;
        }

        public int Hour
        {
            get => hour;
            set
            {
                hour = value%24;               
            }
        }
        private int hour;   // Количество часов

        public int Minute
        {
            get { return minute; }
            set
            {
                minute = value % 60;
            }
        }
        private int minute; // Количество минут

        //минут от начала суток
        public int GetTimeInMinutes() => Hour* 60 + Minute;

        #region переопределение базовых методов
        public int CompareTo(Time other)
        {
            return GetTimeInMinutes() - (other.GetTimeInMinutes());
        }

        public override bool Equals(object time)
        {
            if (time == null || !(time is Time))
                return false;
            Time other = (Time)time;
            //одинковые экземпляры класса Time имеют одинковые свойства Hour и Minute
            return Hour == other.Hour && Minute == other.Minute;
        }

        public override int GetHashCode()
        {
            return GetTimeInMinutes();
        }

        public override string ToString()
        {
            //hh:mm
            string h = Hour.ToString("D2");
            string m = Minute.ToString("D2");
            return $"{h}:{m}";
        }
        #endregion

        #region перегрузка операторов
        public static bool operator <(Time t1, Time t2)
        {
            if (t1 != null && t2 != null)
                return t1.CompareTo(t2) < 0;
            else
                throw new ArgumentNullException();
        }

        public static bool operator >(Time t1, Time t2)
        {
            if (t1 != null && t2 != null)
                return t1.CompareTo(t2) > 0;
            else
                throw new ArgumentNullException();
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if (ReferenceEquals(t1, t2))
            {
                return true;
            }
            if (ReferenceEquals(t1, null) || ReferenceEquals(t2, null))
            {
                return false;
            }
            return t1.GetTimeInMinutes() == t2.GetTimeInMinutes();
        }
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <=(Time t1, Time t2)
        {
            if (t1 != null && t2 != null)
                return t1 < t2 || t1 == t2;
            else
                throw new ArgumentNullException();
        }

        public static bool operator >=(Time t1, Time t2)
        {
            if (t1 != null && t2 != null)
                return t1 > t2 || t1 == t2;
            else
                throw new ArgumentNullException();
        }
        #endregion
    }
}
