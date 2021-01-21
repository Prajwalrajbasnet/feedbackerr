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
        private string criteriaFilePath;
        private List<Feedback> feedbackList = new List<Feedback>();
        private List<string[]> importedFeedbacks;
        private QuickSort quickSorter = new QuickSort();

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadCriterias();
            LoadFeedbacks(DataService.FetchFeedbackData());
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
                        sortByComboBox.Items.Add(line);
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

        private void addCriteriaBtn_Click(object sender, EventArgs e)
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

        private void refreshCriteriaBtn_Click(object sender, EventArgs e)
        {
            // Reload Criterias
            criteriaList.Items.Clear();
            LoadCriterias();
        }

        private void bulkImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK) { 
                this.importedFeedbacks =  File.ReadAllLines(openFileDialog.FileName).Select(str => str.Split(',')).ToList();
                Console.WriteLine("imported feedbacks " + this.importedFeedbacks.Count);
                LoadFeedbacks(this.importedFeedbacks, true);
            }
        }

        private void LoadFeedbacks(List<string[]> rows, Boolean bulkImport = false) {
            try
            {
                if (!bulkImport)
                {
                    //Add columns in the gridview
                    feedbacksGridView.ColumnCount = rows[0].Length;
                    int[] emptyArr = new int[3];
                    for (var i = 0; i < rows[0].Length; i++)
                    {
                        feedbacksGridView.Columns[i].Name = rows[0][i];
                    }
                }

                for (var i = 1; i < rows.Count; i++)
                {
                    Console.WriteLine("rows count" + rows.Count);
                    int[] rowRatings = new int[rows[0].Length - 6];
                    for (var j = 5; j < rows[0].Length - 1; j++)
                    {
                        rowRatings[j - 5] = int.Parse(rows[i][j]);
                    }
                    this.feedbackList.Add(new Feedback(rows[i][0], rows[i][1], rows[i][2], rows[i][3], rows[i][4], rowRatings, rows[i][rows[i].Length - 1]));
                }

                PopulateGridView();
            }
            catch (Exception) {
                MessageBox.Show("Something error occured while importing feedback data! Make sure it is in right format.");
            }
        }

        private void PopulateGridView(string sortOrder = "Ascending") {
            feedbacksGridView.Rows.Clear();
            if (sortOrder == "Ascending")
            {
                for (var i = 0; i < feedbackList.Count; i++)
                {
                    string[] feedbackItemArray = FeedbackObjToArray(feedbackList[i]);
                    feedbacksGridView.Rows.Add(feedbackItemArray);
                }
            }
            else {
                for (var i = feedbackList.Count - 1; i >= 0; i--) {
                    string[] feedbackItemArray = FeedbackObjToArray(feedbackList[i]);
                    feedbacksGridView.Rows.Add(feedbackItemArray);
                }
            }
        }

        private string[] FeedbackObjToArray(Feedback feedback) { 
            string[] feedbackItemArray = new string[6 + feedback.Ratings.Length];
            feedbackItemArray[0] = feedback.CustomerName;
            feedbackItemArray[1] = feedback.Contact;
            feedbackItemArray[2] = feedback.Email;
            feedbackItemArray[3] = feedback.Address;
            feedbackItemArray[4] = feedback.FeedbackText;

            for (var i = 0; i < feedback.Ratings.Length; i++) {
                feedbackItemArray[i + 5] = Util.mapRatingValueToText(feedback.Ratings[i]);
            }
            feedbackItemArray[feedbackItemArray.Length - 1] = feedback.Timestamp;

            return feedbackItemArray;
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<string> criterias = DataService.FetchCriterias();
            foreach (var feedback in importedFeedbacks) {
                if (importedFeedbacks.IndexOf(feedback) == 0) {
                    continue;
                }
                DataService.SaveRating(Util.convertListToCsv(feedback.ToList()), criterias);
            }
            this.importedFeedbacks = null;
            MessageBox.Show("Imported feedbacks saved successfully");
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.feedbackList = quickSorter.Sort(this.feedbackList, 0, this.feedbackList.Count - 1, sortByComboBox.SelectedIndex);
            if (sortOrderComboBox.SelectedIndex >= 0)
            {
                PopulateGridView(sortOrderComboBox.SelectedItem.ToString());
            }
            else {
                PopulateGridView();
            }
            
        }

        private void sortOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortOrderComboBox.SelectedIndex == -1) {
                return;
            }
            if (!(sortByComboBox.SelectedIndex >= 0))
            {
                MessageBox.Show("Please select criteria to sort for!");
                sortOrderComboBox.SelectedIndex = -1;
            }
            else { 
                PopulateGridView(sortOrderComboBox.SelectedItem.ToString());
            }
        }
    }
}
