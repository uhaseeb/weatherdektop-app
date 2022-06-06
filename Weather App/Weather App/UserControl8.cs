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
    public partial class UserControl8 : UserControl
    {
        
        public UserControl8()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            UserControl7 us7 = new UserControl7();
            MainControlClass.showControl(us7, panelContainer);
        }

        private void UserControl8_Load(object sender, EventArgs e)
        {
            this.dailyweather_tableTableAdapter.FillBy(this.weather_testDataSet.dailyweather_table);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
