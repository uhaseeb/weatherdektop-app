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
    public partial class UserControl5 : System.Windows.Forms.UserControl
    {
        
        public UserControl5()
        {
            InitializeComponent();

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username" || textBox1.Text == "")
            {
                errorProvider2.Clear();
                textBox1.Focus();
                textBox1.Clear();
                errorProvider1.SetError(textBox1, "Please enter Username");
            }
            else if (textBox2.Text == "Enter Password" || textBox2.Text == "")
            {
                textBox2.Focus();
                textBox2.Clear();
                errorProvider2.SetError(textBox2, "Please enter Password");
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();

                if (textBox1.Text == "admin" && textBox2.Text == "12345")
                {
                    UserControl7 us7 = new UserControl7();
                    MainControlClass.showControl(us7, panelContainer);
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Password");
                }
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
             if (textBox1.Text == "Enter Username")
             {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

             }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Username";
                textBox1.ForeColor = Color.Gray;
                label3.Focus();
            }
        }

        

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Enter Password";
                textBox2.ForeColor = Color.Gray;
                label3.Focus();
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            UserControl1 us1 = new UserControl1();
            MainControlClass.showControl(us1, panelContainer);
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
           
        }
    }
}
