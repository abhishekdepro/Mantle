using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mantle_WindowsDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFetch_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=D://Programming/weather_forecast.db");
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            DataTable table = new DataTable();
            con.Open();
            LbTemp.Items.Clear();
            LbCondition.Items.Clear();
            cmd = new SQLiteCommand("SELECT * FROM data WHERE city=@city", con);
            cmd.Parameters.AddWithValue("@city", comboBox1.Text);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LbTemp.Items.Add(reader[1].ToString());
                LbCondition.Items.Add(reader[2].ToString());
            }
            Image();
            con.Close();
        }
        private void Image(){
            for (int i = 0; i < LbCondition.Items.Count; i++) {
                if (LbCondition.Items[i].ToString() == "Mostly Cloudy" || LbCondition.Items[i].ToString() == "Haze")
                    pictureBox1.ImageLocation = "D:/Programming/C#/Mantle_WindowsDesktop/Mantle_WindowsDesktop/Cloudy.jpg";
                else if(LbCondition.Items[i].ToString() == "Drizzle" || LbCondition.Items[i].ToString() == "Light Drizzle")
                    pictureBox1.ImageLocation = "D:/Programming/C#/Mantle_WindowsDesktop/Mantle_WindowsDesktop/Drizzle.jpg";
                else
                    pictureBox1.ImageLocation = "D:/Programming/C#/Mantle_WindowsDesktop/Mantle_WindowsDesktop/Sunny.jpg";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weather_forecastDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.weather_forecastDataSet.data);
            LbTemp.Items.Clear();
            LbCondition.Items.Clear();
        }

    }
}
