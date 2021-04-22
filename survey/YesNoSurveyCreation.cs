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
    public partial class YesNoSurveyCreation : Form
    {
        public YesNoSurveyCreation()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label13.BackColor = System.Drawing.Color.Transparent;
            // panel1.BackColor = System.Drawing.Color.Transparent;
            label14.BackColor = System.Drawing.Color.Transparent;


        }

        private void YesNoSurveyCreation_Load(object sender, EventArgs e)
        {

        }



        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int charac = 0;

            charac = textBox1.Text.Length;


            if (textBox1.Text != "" && charac <= 50)
            {
                Panel pan = new Panel();

                pan.Name = "panel" + (panel1.Controls.Count + 1);
                int count2 = panel1.Controls.OfType<Panel>().ToList().Count;
                pan.Location = new Point(0, (25 * count2) + 2);
                pan.Size = new Size(panel1.ClientSize.Width, 50);
                panel1.Controls.Add(pan);
                panel1.Controls.SetChildIndex(pan, 0);

                Label label = new Label();
                int count = pan.Controls.OfType<Label>().ToList().Count;
                label.Location = new Point(6, (25 * count) + 2);
                label.Size = new Size(280, 13);
                label.Name = "label_" + (count + 1);
                label.Text = textBox1.Text.ToString();
                label.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(label);

                RadioButton yes = new RadioButton();
                int count1 = pan.Controls.OfType<RadioButton>().ToList().Count;
                yes.Location = new Point(295, (25 * count) + 2);
                yes.Size = new Size(43, 17);
                yes.Name = "Dynamic1Radio_" + (count + 1);
                yes.Text = "Yes";
                yes.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(yes);

                RadioButton no = new RadioButton();
                int count3 = pan.Controls.OfType<RadioButton>().ToList().Count;
                no.Location = new Point(347, (25 * count) + 2);
                no.Size = new Size(43, 17);
                no.Name = "DynamicRadio2_" + (count + 1);
                no.Text = "No";
                no.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(no);
            }
            else
                MessageBox.Show("Maximum 50 characters are allowed.");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

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
