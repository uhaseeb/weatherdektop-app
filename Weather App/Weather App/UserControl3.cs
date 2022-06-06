using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Weather_App
{
    public partial class UserControl3 : System.Windows.Forms.UserControl
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-P81T70C\SQLEXPRESS;Initial Catalog=weather_test;Integrated Security=True");
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            if(MainControlClass.var != "")
            {
               
                textBox1.Text= MainControlClass.var;
                string sql = "select * from dailyweather_table where City_name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label3.Text = dr["City_name"].ToString();
                        label2.Text = dr["Temperature_C"].ToString();
                        label5.Text = dr["Temperature_F"].ToString();
                        label7.Text = dr["Humidity"].ToString();
                        label9.Text = dr["Pressure"].ToString();
                        label11.Text = dr["Wind_speed"].ToString();
                    }
                     
                }
                cn.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MainControlClass.city_pass(textBox1.Text, label2.Text, label5.Text);
            UserControl4 us4 = new UserControl4();
            MainControlClass.showControl(us4, panelContainer);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string sql = "select * from dailyweather_table where City_name='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if(dr.Read())
                {
                    label3.Text = dr["City_name"].ToString();
                    label2.Text = dr["Temperature_C"].ToString();
                    label5.Text = dr["Temperature_F"].ToString();
                    label7.Text = dr["Humidity"].ToString();
                    label9.Text = dr["Pressure"].ToString();
                    label11.Text = dr["Wind_speed"].ToString();
                    label12.Text = dr["Weather_Con"].ToString();
                }
                else if (textBox1.Text == "Search by City Name")
                {
                    textBox1.Focus();
                    errorProvider1.SetError(textBox1, "Please enter City Name");
                }
                else
                {
                    textBox1.Focus();
                    errorProvider1.SetError(textBox1, "Please enter Corret City Name");
                }
            }
            cn.Close();
            if(label12.Text == "Mostly Cloudy")
            {
                pictureBox1.Image = Properties.Resources.Sunny_Cloudy1;
            }
            else if (label12.Text == "Sunny")
            {
                pictureBox1.Image = Properties.Resources.Sunny;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Rainy;
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search by City Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search by City Name";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
