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
    public partial class UserControl6 : System.Windows.Forms.UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-P81T70C\SQLEXPRESS;Initial Catalog=weather_test;Integrated Security=True");
        public UserControl6()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            UserControl7 us7 = new UserControl7();
            MainControlClass.showControl(us7, panelContainer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter City Name");
            }
            else if (textBox2.Text == "°C")
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter Temp_C");
                errorProvider1.Clear();
            }
            else if (textBox3.Text == "°F")
            {
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Please Enter Temp_F");
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
            else if (textBox4.Text == "%")
            {
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Please enter Humidity");
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
            }
            else if (textBox5.Text == " Hg")
            {
                textBox5.Focus();
                errorProvider5.SetError(textBox5, "Please enter Pressure");
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
            }
            else if (textBox6.Text == " km/h")
            {
                textBox6.Focus();
                errorProvider6.SetError(textBox6, "Please enter Wind_speed");
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
            }

            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();

                string sql = "select * from dailyweather_table where City_name='" + textBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql, cn);
                cn.Open();
                using (SqlDataReader dr = cmd1.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cn.Close();
                        SqlCommand cmd = cn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update dailyweather_table set Temperature_C='" + textBox2.Text + "', Temperature_F='" + textBox3.Text + "', Humidity='" + textBox4.Text + "', Pressure='" + textBox5.Text + "', Wind_speed='" + textBox6.Text + "' where City_name='" + textBox1.Text + "'";
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record Updated Successfully");
                    }
                    else
                    {
                        textBox1.Focus();
                        errorProvider1.SetError(textBox1, "Please enter Correct City Name");
                        cn.Close();
                    }

                }

            }
        }
    }
}
