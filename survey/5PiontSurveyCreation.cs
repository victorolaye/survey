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
    public partial class _5PiontSurveyCreation : Form
    {
        public _5PiontSurveyCreation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int charac = 0;

            charac = textBox1.Text.Length;


            if (textBox1.Text != "" && charac <= 50)
            {
                Panel pan = new Panel();

                pan.Name = "panel" + (panel7.Controls.Count + 1);
                int count2 = panel7.Controls.OfType<Panel>().ToList().Count;
                pan.Location = new Point(0, (25 * count2) + 2);
                pan.Size = new Size(panel7.ClientSize.Width, 50);
                panel7.Controls.Add(pan);
                panel7.Controls.SetChildIndex(pan, 0);
                pan.BackColor = System.Drawing.Color.LightGray;

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
                yes.Location = new Point(253,12);
                yes.Size = new Size(14, 13);
                yes.Name = "Dynamic1Radio_" + (count + 1);
                yes.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(yes);

                RadioButton no = new RadioButton();
                int count3 = pan.Controls.OfType<RadioButton>().ToList().Count;
                no.Location = new Point(361,12);
                no.Size = new Size(14, 13);
                no.Name = "DynamicRadio2_" + (count + 1);
                no.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(no);

                RadioButton no1 = new RadioButton();
                int count4 = pan.Controls.OfType<RadioButton>().ToList().Count;
                no1.Location = new Point(471, 12);
                no1.Size = new Size(14, 13);
                no1.Name = "DynamicRadio2_" + (count + 1);
                no1.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(no1);

                RadioButton no2 = new RadioButton();
                int count5 = pan.Controls.OfType<RadioButton>().ToList().Count;
                no2.Location = new Point(588, 12);
                no2.Size = new Size(14, 13);
                no2.Name = "DynamicRadio2_" + (count + 1);
                no2.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(no2);

                RadioButton no3 = new RadioButton();
                int count6 = pan.Controls.OfType<RadioButton>().ToList().Count;
                no3.Location = new Point(685, 12);
                no3.Size = new Size(14, 13);
                no3.Name = "DynamicRadio2_" + (count + 1);
                no3.BackColor = System.Drawing.Color.LightGray;
                pan.Controls.Add(no3);
            }
            else
                MessageBox.Show("Maximum 50 characters are allowed.");
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
