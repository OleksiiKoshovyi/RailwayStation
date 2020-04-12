using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RailwayStation
{
    public partial class FormMain : Form
    {
        private Time currentTime;       // заданное время
        private string currentCity;     // выбранный город
        private Train[] trains;         // Массив структуры Train
        private List<string> cities;    // Лист городов
        public FormMain()
        {
            InitializeComponent();

            UploadInfo();   //  получение информации из текстовых документов
            VisualInfo();   //  отображение полученной информации
        }

        //получение информации из текстовых документов
        private void UploadInfo()
        {
            trains = new Train[0];
            cities = new List<string>();
            UploadData("trains", ref trains);
            UploadData("cities", ref cities);
        }

        //отображение полученной информации
        private void VisualInfo()
        {
            //numericUpDown: Time
            currentTime = new Time();
            numUpDHours.Value = numUpDHoursArrivalTime.Value = currentTime.Hour;
            numUpDMinutes.Value = numUpDMinutesArrivalTime.Value = currentTime.Minute;
            numUpDHoursDepartureTime.Value = currentTime.Hour;
            numUpDMinutesDepartureTime.Value = currentTime.Minute;

            //ComboBox: City
            currentCity = (cities.Count == 0) ? "" : cities[0];
            cBoxCities.DataSource = cities.ToList();
            cBoxFirstCity.DataSource = cities.ToList();
            cBoxLastCity.DataSource = cities.ToList();

            //ListBox: Train
            lBoxTrains.DataSource = trains; 
        }

        //создание нового поезда
        private void CreateNewTrain()
        {
            int number = (int)numUpDTrainNumber.Value;
            if (trains.Where(t => t.Number == number).Take(1).ToList().Count == 0)//проверка на одинаковые номера поезда
            { 
                Time arrivalTime = new Time((int)numUpDHoursArrivalTime.Value, (int)numUpDMinutesArrivalTime.Value);
                Time deprtureTime = new Time((int)numUpDHoursDepartureTime.Value, (int)numUpDMinutesDepartureTime.Value);
                string firstCity = cities[cBoxFirstCity.SelectedIndex];
                string lastCity = cities[cBoxLastCity.SelectedIndex];

                Train train = new Train(number, arrivalTime, deprtureTime, firstCity, lastCity);

                AddTrainToArray(train);
                lBoxTrains.DataSource = null;   //обновление источника данных для отображения поездов
                lBoxTrains.DataSource = trains; //
                SaveData("trains", trains);     //Сохранение всех поездов
            }
            else
            {
                MessageBox.Show("Поезд с таким номером уже существует",
                    "Ошибка создания поезда",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //добавление в массив поездов нового поезда
        private void AddTrainToArray(Train train)
        {
            Train[] arr = new Train[trains.Length + 1];
            Array.Copy(trains,0,arr,0,trains.Length);
            arr[trains.Length] = train;
            trains = arr;
        }

        #region Задания лабораторной
        // а) По данному времени определить, какие поезда (номер и назначение) стоят в этот момент на станции.
        private List<Train> GetCurrentTrains() => trains.Where(t => t.IsCurrentTrain(currentTime)).ToList();

        // б) Выяснить, каким поездом можно раньше уехать до определенного населенного пункта (учитывая, сколько сейчас времени)
        private void GetNearestTrain()
        {
            string city = currentCity;
            //лист поездов, направляющихся в выбранный город
            List<Train> list = trains.Where(t => t.LastCity == city).ToList(); 
            //сортировка поездов повремени отправления со станции
            list.Sort((t1, t2) => t1.DepartureTime.CompareTo(t2.DepartureTime));
            //список ближайших поездов после заданного времени
            List<Train> after = list.Where(t => t.DepartureTime >= currentTime).ToList();
            //список ближайших поездов на следующий день
            List<Train> nextDay = list.Where(t => t.DepartureTime < currentTime).ToList();
            //объединение двух списков
            after.AddRange(nextDay);

            //если итоговый список пуст
            if (after.Count == 0)
            {
                lBoxTrains.DataSource = new List<string>(){ "Поездов в выбранный город нет и не будет." };
            }
            else
            {
                //задаём исотчник данных для ListBox в виде первого элемента из полученного списка
                lBoxTrains.DataSource = after.Take(1).ToList();
            }
        }

        // г) Вывести все поезда, прибывающие из определенного города в порядке возрастания времени прибытия.
        private List<Train> GetSortedTrainsFromCity()
        {
            string city = currentCity;
            //спиоск поездов, приехавших из выбранного города
            List<Train> list = trains.Where(t => t.FirstCity == city).ToList();
            //сортсровка списка по времени прибытия на станцию
            list.Sort((t1, t2) => t1.ArrivalTime.CompareTo(t2.ArrivalTime));
            return list;
        }
        #endregion

        #region Io
        //Получить объект, сериализированный из json в текстовом файле
        private void UploadData<T>(string filename, ref T array)
        {
            //если такого файла нет, выходим из функции
            if (!File.Exists($"{filename}.txt"))
                return;
            TextReader reader = new StreamReader($"{filename}.txt");
            try
            {
                //считываем весь текст из фала
                string json = reader.ReadToEnd();
                if (json == "")
                    return;
                //десериализируем json в объект T
                T result = JsonConvert.DeserializeObject<T>(json);
                //проверка на null
                if(!ReferenceEquals(result, null))
                    array =  result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка получения данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                //в любом случае выполнения закрываем соединение с файлом
                reader.Close();
            }         
        }

        ///Сериализовать объект в json и записать в текстовый файл
        private void SaveData<T>(string filename, T info)
        {
            //если файл не существует, создаём его
            if (!File.Exists($"{filename}.txt"))
                File.Create($"{filename}.txt");
            //сериализируем объект типа T в json
            string json = JsonConvert.SerializeObject(info);
            TextWriter writer = new StreamWriter($"{filename}.txt");
            MessageBox.Show("Данные успешно сохранены",
                    "Результат сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            try
            {  
                //записываем весь текст в файл
                writer.Write(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка сохранения данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                //при любом результате операции закрываем соединение с файлом
                writer.Close();
            }
        }
        #endregion

        #region Events
        private void BTrainsOnStation_Click(object sender, EventArgs e)
        {
            //делегат: получает поезд, возвращает строку с описанием
            Func<Train, string> format = t => $"№ {t.Number.ToString("D6")}: {t.LastCity}";
            //задание источника данных ListBox
            lBoxTrains.DataSource = GetCurrentTrains().Select(format).ToList();
        }

        private void BNearestTrainTo_Click(object sender, EventArgs e)
        {
            GetNearestTrain();          
        }

        private void BAllTrains_Click(object sender, EventArgs e)
        {
            lBoxTrains.DataSource = null;
            //делегат: получает поезд, возвращает строку с описанием
            Func<Train, string> format = t => $"№ {t.Number.ToString("D6")}: {t.LastCity+";"} Стоянка: {t.StopTime.ToString()}";
            //задание источника данных ListBox
            lBoxTrains.DataSource = trains.Select(format).ToList();
        }

        private void BAllTrainsFrom_Click(object sender, EventArgs e)
        {
            //задание источника данных ListBox
            lBoxTrains.DataSource = GetSortedTrainsFromCity();
        }


        private void NumUpDHours_ValueChanged(object sender, EventArgs e)
        {
            currentTime.Hour = (int)numUpDHours.Value;
        }

        private void NumUpDMinutes_ValueChanged(object sender, EventArgs e)
        {
            currentTime.Minute = (int)numUpDMinutes.Value;
        }

        private void CBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCity = cities[cBoxCities.SelectedIndex];
            bAllTrainsFrom.Text = $"Все поезда из города: {currentCity}";
            bNearestTrainTo.Text = $"Ближайший поезд к городу: {currentCity}";
        }

        private void BCreateTrain_Click(object sender, EventArgs e)
        {
            CreateNewTrain();
        }

        #endregion
    }
}
