using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mantle_v2._0
{
    public partial class MainForm : Form
    {
        SQLiteConnection con = new SQLiteConnection("data source=D://Programming/weather_forecast.db");
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        int Flag=0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weather_forecastDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.weather_forecastDataSet.data);
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DateTime date = Convert.ToDateTime(Date.Text);

                String p = date.Year.ToString() + "-0" + date.Month.ToString() + '-' + date.Day.ToString();

                cmd = new SQLiteCommand("SELECT * FROM data WHERE city=@city AND tomorrow=@tomorrow", con);
                cmd.Parameters.AddWithValue("@city", CityCombo.Text);
                cmd.Parameters.AddWithValue("@tomorrow", p);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TxtWeather.Text = reader[2].ToString();
                    TxtTmpMorn.Text = reader[3].ToString();
                    TxtTmpDay.Text = reader[4].ToString();
                    TxtTmpEve.Text = reader[5].ToString();
                    TxtTmpNight.Text = reader[6].ToString();
                    Flag = 1;
                }
                if (reader.Read() == false && Flag==0)
                {
                    MessageBox.Show("Choose a different Date!", "Data Unavailable");
                }
                con.Close();
            }
            catch (SQLiteException except) {
                MessageBox.Show(except.Message.ToString());
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            TxtWeather.Text = "";
            TxtTmpDay.Text = "";
            TxtTmpEve.Text = "";
            TxtTmpMorn.Text = "";
            TxtTmpNight.Text = "";
            Flag = 0;
        }

        

        

        
    }
}
