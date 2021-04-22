using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey
{
    public partial class Main : Form
           
    {
        int logincount = 0;
        Boolean check = false;
        public Main()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            linkLabel2.BackColor = System.Drawing.Color.Transparent;
            
        }

        public WelcomAdmin WelcomAdmin
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Welcome_Participant Welcome_Participant
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Registration Registration
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Admin"))
                check = true;
            if (check == true)
            {
                if ((textBox1.Text != "Admin" || textBox2.Text != "123456") && logincount <= 4)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Please enter valid Username or Password");

                }
                else if (textBox2.Text.Equals("123456") && textBox1.Text.Equals("Admin") && logincount <= 4)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    
                    WelcomAdmin f = new WelcomAdmin();
                    f.Show();
                    this.Hide();
                }

                else
                    MessageBox.Show("Enter Required Fields.");

            }
            else
            {
              if ((textBox1.Text != "John Karen" || textBox2.Text != "1234") && logincount <= 4)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Please enter valid Username or Password");

                }
              else if (textBox2.Text.Equals("1234") && textBox1.Text.Equals("John Karen") && logincount <= 4)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    Welcome_Participant WP = new Welcome_Participant();
                    WP.Show();
                    this.Hide();



                }
                else
                    MessageBox.Show("Enter Required Fields.");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            logincount++;
            if (logincount > 4)
                MessageBox.Show("Your Account is block because number of login attempts limit exceeded.");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }
    }
}
