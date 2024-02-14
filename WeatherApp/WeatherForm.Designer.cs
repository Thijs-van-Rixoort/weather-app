namespace weather_app
{
    partial class WeatherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetWeatherButton = new Button();
            LocationLabel = new Label();
            LocationTextBox = new TextBox();
            CurrentLocationLabel = new Label();
            CurrentTimeLabel = new Label();
            TimeLabel = new Label();
            CurrentConditionLabel = new Label();
            ConditionLabel = new Label();
            CurrentTemperatureLabel = new Label();
            TemperatureLabel = new Label();
            CurrentWindLabel = new Label();
            WindLabel = new Label();
            CurrentUvIndexLabel = new Label();
            UvIndexLabel = new Label();
            CurrentHumidityLabel = new Label();
            HumidityLabel = new Label();
            CurrentPrecipitationLabel = new Label();
            PrecipitationLabel = new Label();
            CurrentErrorLabel = new Label();
            SuspendLayout();
            // 
            // getWeatherButton
            // 
            GetWeatherButton.Location = new Point(275, 415);
            GetWeatherButton.Name = "getWeatherButton";
            GetWeatherButton.Size = new Size(250, 23);
            GetWeatherButton.TabIndex = 0;
            GetWeatherButton.Text = "get weather";
            GetWeatherButton.UseVisualStyleBackColor = true;
            GetWeatherButton.Click += GetWeatherButton_Click;
            // 
            // locationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(275, 85);
            LocationLabel.Name = "locationLabel";
            LocationLabel.Size = new Size(53, 15);
            LocationLabel.TabIndex = 1;
            LocationLabel.Text = "location:";
            // 
            // locationTextBox
            // 
            LocationTextBox.Location = new Point(275, 12);
            LocationTextBox.Name = "locationTextBox";
            LocationTextBox.PlaceholderText = "your location";
            LocationTextBox.Size = new Size(250, 23);
            LocationTextBox.TabIndex = 2;
            // 
            // currentLocationLabel
            // 
            CurrentLocationLabel.AutoSize = true;
            CurrentLocationLabel.Location = new Point(400, 85);
            CurrentLocationLabel.Name = "currentLocationLabel";
            CurrentLocationLabel.Size = new Size(85, 15);
            CurrentLocationLabel.TabIndex = 3;
            CurrentLocationLabel.Text = "no location set";
            // 
            // currentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Location = new Point(400, 100);
            CurrentTimeLabel.Name = "currentTimeLabel";
            CurrentTimeLabel.Size = new Size(85, 15);
            CurrentTimeLabel.TabIndex = 5;
            CurrentTimeLabel.Text = "no location set";
            // 
            // timeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(275, 100);
            TimeLabel.Name = "timeLabel";
            TimeLabel.Size = new Size(34, 15);
            TimeLabel.TabIndex = 4;
            TimeLabel.Text = "time:";
            // 
            // currentConditionLabel
            // 
            CurrentConditionLabel.AutoSize = true;
            CurrentConditionLabel.Location = new Point(400, 115);
            CurrentConditionLabel.Name = "currentConditionLabel";
            CurrentConditionLabel.Size = new Size(85, 15);
            CurrentConditionLabel.TabIndex = 9;
            CurrentConditionLabel.Text = "no location set";
            // 
            // conditionLabel
            // 
            ConditionLabel.AutoSize = true;
            ConditionLabel.Location = new Point(275, 115);
            ConditionLabel.Name = "conditionLabel";
            ConditionLabel.Size = new Size(61, 15);
            ConditionLabel.TabIndex = 8;
            ConditionLabel.Text = "condition:";
            // 
            // currentTemperatureLabel
            // 
            CurrentTemperatureLabel.AutoSize = true;
            CurrentTemperatureLabel.Location = new Point(400, 130);
            CurrentTemperatureLabel.Name = "currentTemperatureLabel";
            CurrentTemperatureLabel.Size = new Size(85, 15);
            CurrentTemperatureLabel.TabIndex = 7;
            CurrentTemperatureLabel.Text = "no location set";
            // 
            // temperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Location = new Point(275, 130);
            TemperatureLabel.Name = "temperatureLabel";
            TemperatureLabel.Size = new Size(75, 15);
            TemperatureLabel.TabIndex = 6;
            TemperatureLabel.Text = "temperature:";
            // 
            // currentWindLabel
            // 
            CurrentWindLabel.AutoSize = true;
            CurrentWindLabel.Location = new Point(400, 145);
            CurrentWindLabel.Name = "currentWindLabel";
            CurrentWindLabel.Size = new Size(85, 15);
            CurrentWindLabel.TabIndex = 11;
            CurrentWindLabel.Text = "no location set";
            // 
            // windLabel
            // 
            WindLabel.AutoSize = true;
            WindLabel.Location = new Point(275, 145);
            WindLabel.Name = "windLabel";
            WindLabel.Size = new Size(36, 15);
            WindLabel.TabIndex = 10;
            WindLabel.Text = "wind:";
            // 
            // currentUvIndexLabel
            // 
            CurrentUvIndexLabel.AutoSize = true;
            CurrentUvIndexLabel.Location = new Point(400, 190);
            CurrentUvIndexLabel.Name = "currentUvIndexLabel";
            CurrentUvIndexLabel.Size = new Size(85, 15);
            CurrentUvIndexLabel.TabIndex = 13;
            CurrentUvIndexLabel.Text = "no location set";
            // 
            // uvIndexLabel
            // 
            UvIndexLabel.AutoSize = true;
            UvIndexLabel.Location = new Point(275, 190);
            UvIndexLabel.Name = "uvIndexLabel";
            UvIndexLabel.Size = new Size(55, 15);
            UvIndexLabel.TabIndex = 12;
            UvIndexLabel.Text = "uv index:";
            // 
            // currentHumidityLabel
            // 
            CurrentHumidityLabel.AutoSize = true;
            CurrentHumidityLabel.Location = new Point(400, 175);
            CurrentHumidityLabel.Name = "currentHumidityLabel";
            CurrentHumidityLabel.Size = new Size(85, 15);
            CurrentHumidityLabel.TabIndex = 15;
            CurrentHumidityLabel.Text = "no location set";
            // 
            // humidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Location = new Point(275, 175);
            HumidityLabel.Name = "humidityLabel";
            HumidityLabel.Size = new Size(58, 15);
            HumidityLabel.TabIndex = 14;
            HumidityLabel.Text = "humidity:";
            // 
            // currentPrecipitationLabel
            // 
            CurrentPrecipitationLabel.AutoSize = true;
            CurrentPrecipitationLabel.Location = new Point(400, 160);
            CurrentPrecipitationLabel.Name = "currentPrecipitationLabel";
            CurrentPrecipitationLabel.Size = new Size(85, 15);
            CurrentPrecipitationLabel.TabIndex = 17;
            CurrentPrecipitationLabel.Text = "no location set";
            // 
            // precipitationLabel
            // 
            PrecipitationLabel.AutoSize = true;
            PrecipitationLabel.Location = new Point(275, 160);
            PrecipitationLabel.Name = "precipitationLabel";
            PrecipitationLabel.Size = new Size(77, 15);
            PrecipitationLabel.TabIndex = 16;
            PrecipitationLabel.Text = "precipitation:";
            // 
            // currentErrorLabel
            // 
            CurrentErrorLabel.AutoSize = true;
            CurrentErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentErrorLabel.ForeColor = Color.Red;
            CurrentErrorLabel.Location = new Point(275, 255);
            CurrentErrorLabel.MinimumSize = new Size(250, 15);
            CurrentErrorLabel.Name = "currentErrorLabel";
            CurrentErrorLabel.Size = new Size(250, 15);
            CurrentErrorLabel.TabIndex = 18;
            CurrentErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // WeatherForm
            // 
            AcceptButton = GetWeatherButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrentErrorLabel);
            Controls.Add(CurrentPrecipitationLabel);
            Controls.Add(PrecipitationLabel);
            Controls.Add(CurrentHumidityLabel);
            Controls.Add(HumidityLabel);
            Controls.Add(CurrentUvIndexLabel);
            Controls.Add(UvIndexLabel);
            Controls.Add(CurrentWindLabel);
            Controls.Add(WindLabel);
            Controls.Add(CurrentConditionLabel);
            Controls.Add(ConditionLabel);
            Controls.Add(CurrentTemperatureLabel);
            Controls.Add(TemperatureLabel);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(TimeLabel);
            Controls.Add(CurrentLocationLabel);
            Controls.Add(LocationTextBox);
            Controls.Add(LocationLabel);
            Controls.Add(GetWeatherButton);
            Name = "WeatherForm";
            Text = "Weather App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LocationTextBox;
        private Button GetWeatherButton;
        private Label CurrentLocationLabel;
        private Label LocationLabel;
        private Label CurrentTimeLabel;
        private Label TimeLabel;
        private Label CurrentConditionLabel;
        private Label ConditionLabel;
        private Label CurrentTemperatureLabel;
        private Label TemperatureLabel;
        private Label CurrentWindLabel;
        private Label WindLabel;
        private Label CurrentUvIndexLabel;
        private Label UvIndexLabel;
        private Label CurrentHumidityLabel;
        private Label HumidityLabel;
        private Label CurrentPrecipitationLabel;
        private Label PrecipitationLabel;
        private Label CurrentErrorLabel;
    }
}
