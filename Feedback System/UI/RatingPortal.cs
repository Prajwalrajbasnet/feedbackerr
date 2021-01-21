using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_System
{
    public partial class RatingPortal : Form
    {
        private TableLayoutPanel ratingsTableLayout = new TableLayoutPanel();
        private List<String> criterias;
        public RatingPortal()
        {
            InitializeComponent();
        }

        private void RatingPortal_Load(object sender, EventArgs e)
        {
            RenderRatingControls();
            //ResetFields();
        }

        private void RenderRatingControls() {
            // Adds groupbox with radio buttons for each criteria
            this.criterias = DataService.FetchCriterias();
            string[] ratingLevels = Constants.ratings;
            this.ratingsTableLayout.Location = new Point(20, 0);
            this.ratingsTableLayout.ColumnCount = 2;
            this.ratingsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            this.ratingsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            this.ratingsTableLayout.RowCount = this.criterias.Count;
            this.ratingsTableLayout.Size = new System.Drawing.Size(450, 40 * this.criterias.Count);

            for (int i = 1; i <= this.criterias.Count; i++) {
                this.ratingsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                Label label = new Label();
                label.Anchor = AnchorStyles.Left;
                label.AutoSize = true;
                label.Name = this.criterias[i - 1] + "Label";
                label.Size = new System.Drawing.Size(46, 17);
                label.Text = this.criterias[i - 1];
                label.Font = new Font(label.Font.FontFamily, 9, FontStyle.Bold);

                FlowLayoutPanel ratingFlowLayout = new FlowLayoutPanel();
                ratingFlowLayout.Anchor = AnchorStyles.None;
                ratingFlowLayout.AutoSize = true;
                ratingFlowLayout.Name = "ratingFlowLayout" + i;
                ratingFlowLayout.Size = new System.Drawing.Size(356, 27);

                for (int j = 1; j <= ratingLevels.Length; j++) {
                    RadioButton radioBtn = new RadioButton();
                    radioBtn.AutoSize = true;
                    radioBtn.Name = this.criterias[i - 1] + ratingLevels[j - 1];
                    radioBtn.Size = new System.Drawing.Size(64, 21);
                    radioBtn.TabIndex = 1;
                    radioBtn.TabStop = true;
                    radioBtn.Text = ratingLevels[j - 1];
                    radioBtn.UseVisualStyleBackColor = true;
                    ratingFlowLayout.Controls.Add(radioBtn);
                }
                this.ratingsTableLayout.Controls.Add(label, 0, i - 1);
                this.ratingsTableLayout.Controls.Add(ratingFlowLayout, 1, i-1);
            }
            this.ratingsPanel.Controls.Add(this.ratingsTableLayout);

        }

        private void submitBtn_Click(object sender, EventArgs e){   
            List<string> ratings = new List<string>();
            try{
                var ratingGroups = this.ratingsTableLayout.Controls.OfType<FlowLayoutPanel>().ToArray();
                foreach (var ratingGroup in ratingGroups){
                    var rating = ratingGroup.Controls.OfType<RadioButton>().Where(r => r.Checked).Select(s => s.Text).First();
                    ratings.Add(Util.mapRatingTextToValue(rating));
                }
                var ratingCsvString = Util.ConvertRatingToCsv(nameField.Text, contactField.Text, emailField.Text, addressField.Text, feedbackField.Text, ratings);
                DataService.SaveRating(ratingCsvString, this.criterias);
                ResetFields();
                MessageBox.Show("Ratings saved successfully");
            }
            catch (InvalidOperationException ex){
                MessageBox.Show("Please select ratings for all criterias");
            }
            catch (Exception genEx) {
                MessageBox.Show("Something went wrong while saving your ratings");
            }
        }

        private void ResetFields() {
            nameField.Text = "";
            contactField.Text = "";
            emailField.Text = "";
            addressField.Text = "";
            feedbackField.Text = "";

            var ratingGroups = this.ratingsTableLayout.Controls.OfType<FlowLayoutPanel>().ToArray();
            foreach (var ratingGroup in ratingGroups){
                var excellentRadioBtn = ratingGroup.Controls.OfType<RadioButton>().Where(r => r.Text == "Excellent").FirstOrDefault();
                excellentRadioBtn.Checked = true;
            }
        }
    }
    /**
     * uses of helper or util: 
     * Get absolute path of file
     * generate comma separated values
     * 
    */
}
