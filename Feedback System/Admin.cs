using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_System
{
    public partial class Admin : Form
    {
        public Login parentForm = new Login();
        public string criteriaFilePath;
  
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadCriterias();
        }

        private void LoadCriterias() {
            criteriaList.Items.Clear();
            try
            {
                criteriaFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Data//settings.txt");
                using (var sr = new StreamReader(criteriaFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        criteriaList.Items.Add(line);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Settings file is missing");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            parentForm.exitApp();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reload Criterias
            criteriaList.Items.Clear();
            LoadCriterias();
        }

        private void criteriaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add new criteria
            try
            {
                if (textBox1.Text != null && textBox1.Text.Trim() != "")
                {
                    var writeStream = File.AppendText(criteriaFilePath);
                    writeStream.WriteLine(textBox1.Text.Trim());
                    textBox1.Text = "";
                    writeStream.Close();
                }
                else
                {
                    MessageBox.Show("Criteria shouldn't be empty");
                }
            }
            catch (FileNotFoundException fileEx) {
                MessageBox.Show("Settings file not found!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occured while writing the file");
            }
        }
    }
}
