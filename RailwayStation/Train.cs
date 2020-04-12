using System;

namespace RailwayStation
{
    struct Train
    {
        public Train(int number,  Time arrivalTime, Time departureTime, string firstCity, string lastCity)
        {
            this.number         = number;
            this.arrivalTime    = arrivalTime;
            this.departureTime  = departureTime;
            FirstCity           = firstCity;
            LastCity            = lastCity;

            int time = departureTime.GetTimeInMinutes() - arrivalTime.GetTimeInMinutes();
            if (time < 0)           
                time += 60 * 24;            
            int hour = time / 60;
            int minute = time - hour * 60;
            StopTime = new Time(hour, minute); //Новое время остановки

        }

        public Train(Train other)
        {
            this.number          = other.Number;
            this.arrivalTime     = other.ArrivalTime;
            this.departureTime   = other.DepartureTime;
            LastCity             = other.LastCity;
            FirstCity            = other.FirstCity;
            StopTime             = other.StopTime;
        }

        public int Number {
            get { return number; }
            set
            {
                if (value > 0)
                    number = value;
            }
        }
        private int number;         // Номер поезда

        public Time ArrivalTime
        {
            get => arrivalTime;
            set
            {
                #region Считаем время остановки
                if (departureTime != null)
                {
                    int first = value.GetTimeInMinutes();
                    int last = departureTime.GetTimeInMinutes();
                    int time = last - first;

                    if (time < 0)
                    {
                        time += 60 * 24;
                    }
                    int hour = time / 60;
                    int minute = time - hour * 60;

                    StopTime = new Time(hour, minute); //Новое время остановки
                }
                #endregion
                arrivalTime = value;
            }
        }
        private Time arrivalTime;   // Время прибытия на остановку

        public Time DepartureTime
        {
            get => departureTime;
            set
            {

                #region Считаем время остановки
                if (arrivalTime != null)
                {
                    int first   = arrivalTime.GetTimeInMinutes();
                    int last    = value.GetTimeInMinutes();
                    int time = last - first;

                    if (time < 0)
                    {
                        time += 60 * 24;
                    }
                    int hour = time / 60;
                    int minute = time - hour * 60;
                    StopTime = new Time(hour, minute); //Новое время остановки
                }
                #endregion

                departureTime = value;
            }
        }
        private Time departureTime; // Время отправления с остановки
        public Time StopTime
        { get;private set; }     // Время остановки. Считается автоматически при изменении departureTime и arrivalTime

        public string LastCity;     // Город отправления
        public string FirstCity;    // Город прибытия

        public bool IsCurrentTrain(Time currentTime)
        {
            if(arrivalTime <= departureTime)            
                return currentTime >= arrivalTime && currentTime <= departureTime;           
            else            
                return (currentTime >= arrivalTime || currentTime <= departureTime);            
        }

        #region переопределение базовых методов
        public override bool Equals(object train)
        {
            if (train == null || !train.GetType().Equals(this.GetType()))
                return false;
            Train other = (Train)train;
            bool equalsTime = ArrivalTime == other.ArrivalTime && DepartureTime == other.DepartureTime;
            bool equalsCity = LastCity == other.LastCity && FirstCity == other.FirstCity;
            return Number == other.Number && equalsTime && equalsCity;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            //№000000: [Город1]-[Город2]; Остановка: [Прибытие]-[Отправление]: Длительность: [Остановка]
            string num = number.ToString("D6");
            string cities = string.Format("{0} - {1};", FirstCity, LastCity);
            string stop = string.Format("Остановка: {0}-{1}: Длительность: {2}", ArrivalTime, DepartureTime, StopTime);
            string result = string.Format("№{0}: {1} {2}",num, cities, stop);
            return result;
        }
        #endregion
    }
}
