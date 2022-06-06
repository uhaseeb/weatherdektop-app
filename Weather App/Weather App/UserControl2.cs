using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_App.Properties;

namespace Weather_App
{
    public partial class UserControl2 : System.Windows.Forms.UserControl
    {
        int count = 0;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count <= 2)
            {
                if (count == 0)
                {
                    pictureBox1.Image = Properties.Resources.Use_2;
                    count++;
                }
                else if (count == 1)
                {
                    pictureBox1.Image = Properties.Resources.Use_3;
                    count++;
                }
                else if (count == 2)
                {
                    pictureBox1.Image = Properties.Resources.Use_4;
                    count++;
                }
            }
            else
            {
                UserControl3 us3 = new UserControl3();
                MainControlClass.showControl(us3, panelContainer);
            }

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            UserControl3 us3 = new UserControl3();
            MainControlClass.showControl(us3, panelContainer);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}