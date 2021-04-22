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
    public partial class Welcome_Participant : Form
    {
        public Welcome_Participant()
        {
            InitializeComponent();
        }

        public participantSurveyForm participantSurveyForm
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            participantSurveyForm pf = new participantSurveyForm();
            pf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
