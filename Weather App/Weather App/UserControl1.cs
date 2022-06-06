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
    public partial class UserControl1 : System.Windows.Forms.UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            UserControl2 us2 = new UserControl2();
            MainControlClass.showControl(us2, panelContainer);
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl5 us5 = new UserControl5();
            MainControlClass.showControl(us5, panelContainer);
        }
    }
}
