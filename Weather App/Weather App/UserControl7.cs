using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class UserControl7 : System.Windows.Forms.UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            UserControl6 us6 = new UserControl6();
            MainControlClass.showControl(us6, panelContainer);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            UserControl5 us5 = new UserControl5();
            MainControlClass.showControl(us5, panelContainer);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserControl8 us8 = new UserControl8();
            MainControlClass.showControl(us8, panelContainer);
        }
    }
}
