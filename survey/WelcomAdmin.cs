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
    public partial class WelcomAdmin : Form
    {
        public WelcomAdmin()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            //radioButton1.BackColor = System.Drawing.Color.Transparent;
            //radioButton2.BackColor = System.Drawing.Color.Transparent;
            //radioButton3.BackColor = System.Drawing.Color.Transparent;
        }

        public YesNoSurveyCreation YesNoSurveyCreation
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DropdownSurveyCreation DropdownSurveyCreation
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public _5PiontSurveyCreation _5PiontSurveyCreation
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void WelcomAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                YesNoSurveyCreation ynf = new YesNoSurveyCreation();
                ynf.Show();
            }
            else if (radioButton2.Checked)
            {
                DropdownSurveyCreation sc = new DropdownSurveyCreation();
                sc.Show();
            }
            else if (radioButton3.Checked)
            {
                _5PiontSurveyCreation point = new _5PiontSurveyCreation();
                point.Show();
            }
            else
            {
                MessageBox.Show("Please select the type of survey");
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {

                f.Close();
            }
            this.Close();
        }
    }
}
