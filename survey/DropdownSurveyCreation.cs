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
    public partial class DropdownSurveyCreation : Form
    {
        public DropdownSurveyCreation()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label13.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int charac = 0;
            charac = textBox1.Text.Length;
            if (textBox1.Text != "" && charac <= 50)
            {
                Label label = new Label();
                int count = panel1.Controls.OfType<Label>().ToList().Count;
                label.Location = new Point(12, (25 * count) + 2);
                label.Size = new Size(280, 13);
                label.Name = "label_" + (count + 1);
                label.Text = textBox1.Text.ToString();
                label.BackColor = System.Drawing.Color.LightGray;
                panel1.Controls.Add(label);

                ComboBox yes = new ComboBox();
                int count1 = panel1.Controls.OfType<ComboBox>().ToList().Count;
                yes.Location = new Point(337, (25 * count) + 2);
                yes.Size = new Size(121, 21);
                yes.Name = "comboxoption_" + (count + 1);
                yes.Items.Add(textBox2.Text.ToString());
                yes.Items.Add(textBox3.Text.ToString());
                yes.Items.Add(textBox4.Text.ToString());
                yes.Items.Add(textBox5.Text.ToString());
                yes.Items.Add(textBox6.Text.ToString());
                yes.BackColor = System.Drawing.Color.LightGray;
                panel1.Controls.Add(yes);

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
