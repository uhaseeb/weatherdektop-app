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
    public partial class UserControl4 : System.Windows.Forms.UserControl
    {
        public static string city_name;
        public static string day_name;

        public UserControl4()
        {
            InitializeComponent();
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            UserControl3 us3 = new UserControl3();
            MainControlClass.showControl(us3, panelContainer);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            city_name = MainControlClass.var;
            City_N.Text = city_name;
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-P81T70C\SQLEXPRESS;Initial Catalog=weather_test;Integrated Security=True");
            string sql = "select * from weeklyweather_table where W_City='" + City_N.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    SatC.Text = dr["Sat_tempC"].ToString();
                    SatF.Text = dr["Sat_tempF"].ToString();
                    SunC.Text = dr["Sun_tempC"].ToString();
                    SunF.Text = dr["Sun_tempF"].ToString();
                    MonC.Text = dr["Mon_tempC"].ToString();
                    MonF.Text = dr["Mon_tempF"].ToString();
                    TueC.Text = dr["Tue_tempC"].ToString();
                    TueF.Text = dr["Tue_tempF"].ToString();
                    WedC.Text = dr["Wed_tempC"].ToString();
                    WedF.Text = dr["Wed_tempF"].ToString();
                    ThurC.Text = dr["Thu_tempC"].ToString();
                    ThurF.Text = dr["Thu_tempF"].ToString();
                    FriC.Text = dr["Fri_tempC"].ToString();
                    FriF.Text = dr["Fri_tempF"].ToString();
                    
                }
            }

            cn.Close();
            if(dateTimePicker1.Value.ToString("ddd")=="Mon")
            {
                MonC.Text = MainControlClass.C;
                MonF.Text = MainControlClass.F;
            }
            if (dateTimePicker1.Value.ToString("ddd") == "Tue")
            {
                TueC.Text = MainControlClass.C;
                TueF.Text = MainControlClass.F;
            }
          
            else if (dateTimePicker1.Value.ToString("ddd") == "Wed")
            {
                WedC.Text = MainControlClass.C;
                WedF.Text = MainControlClass.F;
            }
            else if (dateTimePicker1.Value.ToString("ddd") == "Thu")
            {
                ThurC.Text = MainControlClass.C;
                ThurF.Text = MainControlClass.F;
            }
            else if (dateTimePicker1.Value.ToString("ddd") == "Fri")
            {
                FriC.Text = MainControlClass.C;
                FriF.Text = MainControlClass.F;
            }
            else if (dateTimePicker1.Value.ToString("ddd") == "Sat")
            {
                SatC.Text = MainControlClass.C;
                SatF.Text = MainControlClass.F;
            }
            else if (dateTimePicker1.Value.ToString("ddd") == "Sun")
            {
                SunC.Text = MainControlClass.C;
                SunF.Text = MainControlClass.F;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
