using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    class MainControlClass
    {
        public static string var="";
        public static string C;
        public static string F;


        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control panelContainer)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();


            panelContainer.Controls.Add(control);
        }
        public static void city_pass(string city_name,string C_temp, string F_temp)
        {
            var = city_name;
            C = C_temp;
            F = F_temp;
        }
        public static string name_store()
        {
            return var;
        }
        public static string C_store()
        {
            return C;
        }
        public static string F_store()
        {
            return F;
        }
    }
}
