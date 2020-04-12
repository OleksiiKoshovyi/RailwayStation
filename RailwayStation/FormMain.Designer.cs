namespace RailwayStation
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblLastCity = new System.Windows.Forms.Label();
            this.lblFirstCity = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.bCreateTrain = new System.Windows.Forms.Button();
            this.cBoxLastCity = new System.Windows.Forms.ComboBox();
            this.cBoxFirstCity = new System.Windows.Forms.ComboBox();
            this.lblMinutesDepartureTime = new System.Windows.Forms.Label();
            this.lblHoursDepartureTime = new System.Windows.Forms.Label();
            this.numUpDMinutesDepartureTime = new System.Windows.Forms.NumericUpDown();
            this.numUpDHoursDepartureTime = new System.Windows.Forms.NumericUpDown();
            this.lblMinutesArrivalTime = new System.Windows.Forms.Label();
            this.lblHoursArrivalTime = new System.Windows.Forms.Label();
            this.numUpDMinutesArrivalTime = new System.Windows.Forms.NumericUpDown();
            this.numUpDHoursArrivalTime = new System.Windows.Forms.NumericUpDown();
            this.lblTrainNumber = new System.Windows.Forms.Label();
            this.numUpDTrainNumber = new System.Windows.Forms.NumericUpDown();
            this.lblCreaateTrain = new System.Windows.Forms.Label();
            this.bAllTrainsFrom = new System.Windows.Forms.Button();
            this.bAllTrains = new System.Windows.Forms.Button();
            this.bNearestTrainTo = new System.Windows.Forms.Button();
            this.bTrainsOnStation = new System.Windows.Forms.Button();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.numUpDMinutes = new System.Windows.Forms.NumericUpDown();
            this.numUpDHours = new System.Windows.Forms.NumericUpDown();
            this.cBoxCities = new System.Windows.Forms.ComboBox();
            this.lBoxTrains = new System.Windows.Forms.ListBox();
            this.pMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesDepartureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursDepartureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesArrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursArrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDTrainNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHours)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.bAllTrainsFrom);
            this.pMain.Controls.Add(this.bAllTrains);
            this.pMain.Controls.Add(this.bNearestTrainTo);
            this.pMain.Controls.Add(this.bTrainsOnStation);
            this.pMain.Controls.Add(this.lblMinutes);
            this.pMain.Controls.Add(this.lblHours);
            this.pMain.Controls.Add(this.numUpDMinutes);
            this.pMain.Controls.Add(this.numUpDHours);
            this.pMain.Controls.Add(this.cBoxCities);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMain.Location = new System.Drawing.Point(576, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(228, 561);
            this.pMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDepartureTime);
            this.panel1.Controls.Add(this.lblLastCity);
            this.panel1.Controls.Add(this.lblFirstCity);
            this.panel1.Controls.Add(this.lblArrivalTime);
            this.panel1.Controls.Add(this.bCreateTrain);
            this.panel1.Controls.Add(this.cBoxLastCity);
            this.panel1.Controls.Add(this.cBoxFirstCity);
            this.panel1.Controls.Add(this.lblMinutesDepartureTime);
            this.panel1.Controls.Add(this.lblHoursDepartureTime);
            this.panel1.Controls.Add(this.numUpDMinutesDepartureTime);
            this.panel1.Controls.Add(this.numUpDHoursDepartureTime);
            this.panel1.Controls.Add(this.lblMinutesArrivalTime);
            this.panel1.Controls.Add(this.lblHoursArrivalTime);
            this.panel1.Controls.Add(this.numUpDMinutesArrivalTime);
            this.panel1.Controls.Add(this.numUpDHoursArrivalTime);
            this.panel1.Controls.Add(this.lblTrainNumber);
            this.panel1.Controls.Add(this.numUpDTrainNumber);
            this.panel1.Controls.Add(this.lblCreaateTrain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 282);
            this.panel1.TabIndex = 9;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(12, 115);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(133, 13);
            this.lblDepartureTime.TabIndex = 18;
            this.lblDepartureTime.Text = "Отправление со станции";
            // 
            // lblLastCity
            // 
            this.lblLastCity.AutoSize = true;
            this.lblLastCity.Location = new System.Drawing.Point(11, 196);
            this.lblLastCity.Name = "lblLastCity";
            this.lblLastCity.Size = new System.Drawing.Size(14, 13);
            this.lblLastCity.TabIndex = 17;
            this.lblLastCity.Text = "В";
            // 
            // lblFirstCity
            // 
            this.lblFirstCity.AutoSize = true;
            this.lblFirstCity.Location = new System.Drawing.Point(11, 174);
            this.lblFirstCity.Name = "lblFirstCity";
            this.lblFirstCity.Size = new System.Drawing.Size(21, 13);
            this.lblFirstCity.TabIndex = 16;
            this.lblFirstCity.Text = "Из";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Location = new System.Drawing.Point(12, 58);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(117, 13);
            this.lblArrivalTime.TabIndex = 15;
            this.lblArrivalTime.Text = "прибытие на станцию";
            // 
            // bCreateTrain
            // 
            this.bCreateTrain.Location = new System.Drawing.Point(13, 229);
            this.bCreateTrain.Name = "bCreateTrain";
            this.bCreateTrain.Size = new System.Drawing.Size(204, 37);
            this.bCreateTrain.TabIndex = 10;
            this.bCreateTrain.Text = "Создать поезд";
            this.bCreateTrain.UseVisualStyleBackColor = true;
            this.bCreateTrain.Click += new System.EventHandler(this.BCreateTrain_Click);
            // 
            // cBoxLastCity
            // 
            this.cBoxLastCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLastCity.FormattingEnabled = true;
            this.cBoxLastCity.Location = new System.Drawing.Point(50, 193);
            this.cBoxLastCity.Name = "cBoxLastCity";
            this.cBoxLastCity.Size = new System.Drawing.Size(168, 21);
            this.cBoxLastCity.TabIndex = 14;
            // 
            // cBoxFirstCity
            // 
            this.cBoxFirstCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFirstCity.FormattingEnabled = true;
            this.cBoxFirstCity.Location = new System.Drawing.Point(50, 166);
            this.cBoxFirstCity.Name = "cBoxFirstCity";
            this.cBoxFirstCity.Size = new System.Drawing.Size(168, 21);
            this.cBoxFirstCity.TabIndex = 13;
            // 
            // lblMinutesDepartureTime
            // 
            this.lblMinutesDepartureTime.AutoSize = true;
            this.lblMinutesDepartureTime.Location = new System.Drawing.Point(120, 142);
            this.lblMinutesDepartureTime.Name = "lblMinutesDepartureTime";
            this.lblMinutesDepartureTime.Size = new System.Drawing.Size(41, 13);
            this.lblMinutesDepartureTime.TabIndex = 12;
            this.lblMinutesDepartureTime.Text = "Минут:";
            // 
            // lblHoursDepartureTime
            // 
            this.lblHoursDepartureTime.AutoSize = true;
            this.lblHoursDepartureTime.Location = new System.Drawing.Point(6, 142);
            this.lblHoursDepartureTime.Name = "lblHoursDepartureTime";
            this.lblHoursDepartureTime.Size = new System.Drawing.Size(42, 13);
            this.lblHoursDepartureTime.TabIndex = 10;
            this.lblHoursDepartureTime.Text = "Часов:";
            // 
            // numUpDMinutesDepartureTime
            // 
            this.numUpDMinutesDepartureTime.Location = new System.Drawing.Point(167, 140);
            this.numUpDMinutesDepartureTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDMinutesDepartureTime.Name = "numUpDMinutesDepartureTime";
            this.numUpDMinutesDepartureTime.Size = new System.Drawing.Size(50, 20);
            this.numUpDMinutesDepartureTime.TabIndex = 11;
            // 
            // numUpDHoursDepartureTime
            // 
            this.numUpDHoursDepartureTime.Location = new System.Drawing.Point(54, 140);
            this.numUpDHoursDepartureTime.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUpDHoursDepartureTime.Name = "numUpDHoursDepartureTime";
            this.numUpDHoursDepartureTime.Size = new System.Drawing.Size(50, 20);
            this.numUpDHoursDepartureTime.TabIndex = 9;
            // 
            // lblMinutesArrivalTime
            // 
            this.lblMinutesArrivalTime.AutoSize = true;
            this.lblMinutesArrivalTime.Location = new System.Drawing.Point(120, 85);
            this.lblMinutesArrivalTime.Name = "lblMinutesArrivalTime";
            this.lblMinutesArrivalTime.Size = new System.Drawing.Size(41, 13);
            this.lblMinutesArrivalTime.TabIndex = 8;
            this.lblMinutesArrivalTime.Text = "Минут:";
            // 
            // lblHoursArrivalTime
            // 
            this.lblHoursArrivalTime.AutoSize = true;
            this.lblHoursArrivalTime.Location = new System.Drawing.Point(6, 85);
            this.lblHoursArrivalTime.Name = "lblHoursArrivalTime";
            this.lblHoursArrivalTime.Size = new System.Drawing.Size(42, 13);
            this.lblHoursArrivalTime.TabIndex = 6;
            this.lblHoursArrivalTime.Text = "Часов:";
            // 
            // numUpDMinutesArrivalTime
            // 
            this.numUpDMinutesArrivalTime.Location = new System.Drawing.Point(167, 83);
            this.numUpDMinutesArrivalTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDMinutesArrivalTime.Name = "numUpDMinutesArrivalTime";
            this.numUpDMinutesArrivalTime.Size = new System.Drawing.Size(50, 20);
            this.numUpDMinutesArrivalTime.TabIndex = 7;
            // 
            // numUpDHoursArrivalTime
            // 
            this.numUpDHoursArrivalTime.Location = new System.Drawing.Point(54, 83);
            this.numUpDHoursArrivalTime.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUpDHoursArrivalTime.Name = "numUpDHoursArrivalTime";
            this.numUpDHoursArrivalTime.Size = new System.Drawing.Size(50, 20);
            this.numUpDHoursArrivalTime.TabIndex = 5;
            // 
            // lblTrainNumber
            // 
            this.lblTrainNumber.AutoSize = true;
            this.lblTrainNumber.Location = new System.Drawing.Point(11, 32);
            this.lblTrainNumber.Name = "lblTrainNumber";
            this.lblTrainNumber.Size = new System.Drawing.Size(18, 13);
            this.lblTrainNumber.TabIndex = 4;
            this.lblTrainNumber.Text = "№";
            // 
            // numUpDTrainNumber
            // 
            this.numUpDTrainNumber.Location = new System.Drawing.Point(50, 30);
            this.numUpDTrainNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDTrainNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDTrainNumber.Name = "numUpDTrainNumber";
            this.numUpDTrainNumber.Size = new System.Drawing.Size(141, 20);
            this.numUpDTrainNumber.TabIndex = 3;
            this.numUpDTrainNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCreaateTrain
            // 
            this.lblCreaateTrain.AutoSize = true;
            this.lblCreaateTrain.Location = new System.Drawing.Point(79, 8);
            this.lblCreaateTrain.Name = "lblCreaateTrain";
            this.lblCreaateTrain.Size = new System.Drawing.Size(82, 13);
            this.lblCreaateTrain.TabIndex = 0;
            this.lblCreaateTrain.Text = "Создать поезд";
            this.lblCreaateTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAllTrainsFrom
            // 
            this.bAllTrainsFrom.Location = new System.Drawing.Point(14, 226);
            this.bAllTrainsFrom.Name = "bAllTrainsFrom";
            this.bAllTrainsFrom.Size = new System.Drawing.Size(204, 37);
            this.bAllTrainsFrom.TabIndex = 8;
            this.bAllTrainsFrom.Text = "Все поезда из города: ";
            this.bAllTrainsFrom.UseVisualStyleBackColor = true;
            this.bAllTrainsFrom.Click += new System.EventHandler(this.BAllTrainsFrom_Click);
            // 
            // bAllTrains
            // 
            this.bAllTrains.Location = new System.Drawing.Point(14, 183);
            this.bAllTrains.Name = "bAllTrains";
            this.bAllTrains.Size = new System.Drawing.Size(204, 37);
            this.bAllTrains.TabIndex = 7;
            this.bAllTrains.Text = "Все поезда";
            this.bAllTrains.UseVisualStyleBackColor = true;
            this.bAllTrains.Click += new System.EventHandler(this.BAllTrains_Click);
            // 
            // bNearestTrainTo
            // 
            this.bNearestTrainTo.Location = new System.Drawing.Point(14, 140);
            this.bNearestTrainTo.Name = "bNearestTrainTo";
            this.bNearestTrainTo.Size = new System.Drawing.Size(204, 37);
            this.bNearestTrainTo.TabIndex = 6;
            this.bNearestTrainTo.Text = "Ближайший поезд к городу: ";
            this.bNearestTrainTo.UseVisualStyleBackColor = true;
            this.bNearestTrainTo.Click += new System.EventHandler(this.BNearestTrainTo_Click);
            // 
            // bTrainsOnStation
            // 
            this.bTrainsOnStation.Location = new System.Drawing.Point(14, 97);
            this.bTrainsOnStation.Name = "bTrainsOnStation";
            this.bTrainsOnStation.Size = new System.Drawing.Size(204, 37);
            this.bTrainsOnStation.TabIndex = 5;
            this.bTrainsOnStation.Text = "Поезда на станции";
            this.bTrainsOnStation.UseVisualStyleBackColor = true;
            this.bTrainsOnStation.Click += new System.EventHandler(this.BTrainsOnStation_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(120, 22);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(41, 13);
            this.lblMinutes.TabIndex = 4;
            this.lblMinutes.Text = "Минут:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(6, 22);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(42, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Часов:";
            // 
            // numUpDMinutes
            // 
            this.numUpDMinutes.Location = new System.Drawing.Point(167, 20);
            this.numUpDMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDMinutes.Name = "numUpDMinutes";
            this.numUpDMinutes.Size = new System.Drawing.Size(50, 20);
            this.numUpDMinutes.TabIndex = 3;
            this.numUpDMinutes.ValueChanged += new System.EventHandler(this.NumUpDMinutes_ValueChanged);
            // 
            // numUpDHours
            // 
            this.numUpDHours.Location = new System.Drawing.Point(54, 20);
            this.numUpDHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUpDHours.Name = "numUpDHours";
            this.numUpDHours.Size = new System.Drawing.Size(50, 20);
            this.numUpDHours.TabIndex = 1;
            this.numUpDHours.ValueChanged += new System.EventHandler(this.NumUpDHours_ValueChanged);
            // 
            // cBoxCities
            // 
            this.cBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCities.FormattingEnabled = true;
            this.cBoxCities.Location = new System.Drawing.Point(14, 59);
            this.cBoxCities.Name = "cBoxCities";
            this.cBoxCities.Size = new System.Drawing.Size(204, 21);
            this.cBoxCities.TabIndex = 0;
            this.cBoxCities.SelectedIndexChanged += new System.EventHandler(this.CBoxCities_SelectedIndexChanged);
            // 
            // lBoxTrains
            // 
            this.lBoxTrains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxTrains.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBoxTrains.FormattingEnabled = true;
            this.lBoxTrains.ItemHeight = 25;
            this.lBoxTrains.Location = new System.Drawing.Point(0, 0);
            this.lBoxTrains.Name = "lBoxTrains";
            this.lBoxTrains.Size = new System.Drawing.Size(576, 554);
            this.lBoxTrains.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.lBoxTrains);
            this.Controls.Add(this.pMain);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Железнодорожная станция";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesDepartureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursDepartureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutesArrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHoursArrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDTrainNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button bAllTrainsFrom;
        private System.Windows.Forms.Button bAllTrains;
        private System.Windows.Forms.Button bNearestTrainTo;
        private System.Windows.Forms.Button bTrainsOnStation;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown numUpDMinutes;
        private System.Windows.Forms.NumericUpDown numUpDHours;
        private System.Windows.Forms.ComboBox cBoxCities;
        private System.Windows.Forms.ListBox lBoxTrains;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblLastCity;
        private System.Windows.Forms.Label lblFirstCity;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Button bCreateTrain;
        private System.Windows.Forms.ComboBox cBoxLastCity;
        private System.Windows.Forms.ComboBox cBoxFirstCity;
        private System.Windows.Forms.Label lblMinutesDepartureTime;
        private System.Windows.Forms.Label lblHoursDepartureTime;
        private System.Windows.Forms.NumericUpDown numUpDMinutesDepartureTime;
        private System.Windows.Forms.NumericUpDown numUpDHoursDepartureTime;
        private System.Windows.Forms.Label lblMinutesArrivalTime;
        private System.Windows.Forms.Label lblHoursArrivalTime;
        private System.Windows.Forms.NumericUpDown numUpDMinutesArrivalTime;
        private System.Windows.Forms.NumericUpDown numUpDHoursArrivalTime;
        private System.Windows.Forms.Label lblTrainNumber;
        private System.Windows.Forms.NumericUpDown numUpDTrainNumber;
        private System.Windows.Forms.Label lblCreaateTrain;
    }
}

