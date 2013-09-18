namespace Mantle_v2._0
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Input = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.CityCombo = new System.Windows.Forms.ComboBox();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weather_forecastDataSet = new Mantle_v2._0.weather_forecastDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTableAdapter = new Mantle_v2._0.weather_forecastDataSetTableAdapters.dataTableAdapter();
            this.TxtWeather = new System.Windows.Forms.TextBox();
            this.TxtTmpMorn = new System.Windows.Forms.TextBox();
            this.TxtTmpDay = new System.Windows.Forms.TextBox();
            this.TxtTmpEve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTmpNight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_forecastDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Controls.Add(this.button1);
            this.Input.Controls.Add(this.label2);
            this.Input.Controls.Add(this.Date);
            this.Input.Controls.Add(this.CityCombo);
            this.Input.Controls.Add(this.label1);
            this.Input.Location = new System.Drawing.Point(13, 13);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(611, 106);
            this.Input.TabIndex = 0;
            this.Input.TabStop = false;
            this.Input.Text = "Input";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Forecast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Date:";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(347, 27);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 2;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // CityCombo
            // 
            this.CityCombo.DataSource = this.dataBindingSource;
            this.CityCombo.DisplayMember = "city";
            this.CityCombo.FormattingEnabled = true;
            this.CityCombo.Location = new System.Drawing.Point(79, 27);
            this.CityCombo.Name = "CityCombo";
            this.CityCombo.Size = new System.Drawing.Size(152, 21);
            this.CityCombo.TabIndex = 1;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "data";
            this.dataBindingSource.DataSource = this.weather_forecastDataSet;
            // 
            // weather_forecastDataSet
            // 
            this.weather_forecastDataSet.DataSetName = "weather_forecastDataSet";
            this.weather_forecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose City:";
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // TxtWeather
            // 
            this.TxtWeather.Location = new System.Drawing.Point(232, 139);
            this.TxtWeather.Multiline = true;
            this.TxtWeather.Name = "TxtWeather";
            this.TxtWeather.Size = new System.Drawing.Size(178, 20);
            this.TxtWeather.TabIndex = 1;
            // 
            // TxtTmpMorn
            // 
            this.TxtTmpMorn.Location = new System.Drawing.Point(219, 19);
            this.TxtTmpMorn.Multiline = true;
            this.TxtTmpMorn.Name = "TxtTmpMorn";
            this.TxtTmpMorn.Size = new System.Drawing.Size(178, 20);
            this.TxtTmpMorn.TabIndex = 2;
            // 
            // TxtTmpDay
            // 
            this.TxtTmpDay.Location = new System.Drawing.Point(219, 49);
            this.TxtTmpDay.Multiline = true;
            this.TxtTmpDay.Name = "TxtTmpDay";
            this.TxtTmpDay.Size = new System.Drawing.Size(178, 20);
            this.TxtTmpDay.TabIndex = 3;
            // 
            // TxtTmpEve
            // 
            this.TxtTmpEve.Location = new System.Drawing.Point(219, 82);
            this.TxtTmpEve.Multiline = true;
            this.TxtTmpEve.Name = "TxtTmpEve";
            this.TxtTmpEve.Size = new System.Drawing.Size(178, 20);
            this.TxtTmpEve.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weather Condition:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Morning:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTmpNight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtTmpMorn);
            this.groupBox1.Controls.Add(this.TxtTmpEve);
            this.groupBox1.Controls.Add(this.TxtTmpDay);
            this.groupBox1.Location = new System.Drawing.Point(13, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Data:";
            // 
            // TxtTmpNight
            // 
            this.TxtTmpNight.Location = new System.Drawing.Point(219, 112);
            this.TxtTmpNight.Multiline = true;
            this.TxtTmpNight.Name = "TxtTmpNight";
            this.TxtTmpNight.Size = new System.Drawing.Size(178, 20);
            this.TxtTmpNight.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Night:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Evening:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Day:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtWeather);
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantle 2.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_forecastDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.ComboBox CityCombo;
        private System.Windows.Forms.Label label1;
        private weather_forecastDataSet weather_forecastDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private weather_forecastDataSetTableAdapters.dataTableAdapter dataTableAdapter;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtWeather;
        private System.Windows.Forms.TextBox TxtTmpMorn;
        private System.Windows.Forms.TextBox TxtTmpDay;
        private System.Windows.Forms.TextBox TxtTmpEve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTmpNight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

