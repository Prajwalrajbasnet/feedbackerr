namespace Feedback_System
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addCriteriaPage = new System.Windows.Forms.TabPage();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.criteriaList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshCriteriaBtn = new System.Windows.Forms.Button();
            this.addCriteriaBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbacksPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.bulkImportBtn = new System.Windows.Forms.Button();
            this.feedbacksGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.chartComboBox = new System.Windows.Forms.ComboBox();
            this.ratingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.addCriteriaPage.SuspendLayout();
            this.feedbacksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addCriteriaPage);
            this.tabControl.Controls.Add(this.feedbacksPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1265, 562);
            this.tabControl.TabIndex = 0;
            // 
            // addCriteriaPage
            // 
            this.addCriteriaPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addCriteriaPage.Controls.Add(this.logoutBtn);
            this.addCriteriaPage.Controls.Add(this.criteriaList);
            this.addCriteriaPage.Controls.Add(this.label2);
            this.addCriteriaPage.Controls.Add(this.refreshCriteriaBtn);
            this.addCriteriaPage.Controls.Add(this.addCriteriaBtn);
            this.addCriteriaPage.Controls.Add(this.label4);
            this.addCriteriaPage.Controls.Add(this.label3);
            this.addCriteriaPage.Controls.Add(this.textBox1);
            this.addCriteriaPage.Controls.Add(this.label1);
            this.addCriteriaPage.Location = new System.Drawing.Point(4, 27);
            this.addCriteriaPage.Name = "addCriteriaPage";
            this.addCriteriaPage.Size = new System.Drawing.Size(1257, 531);
            this.addCriteriaPage.TabIndex = 0;
            this.addCriteriaPage.Text = "Add Criteria";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutBtn.Location = new System.Drawing.Point(1113, 17);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 39);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // criteriaList
            // 
            this.criteriaList.FormattingEnabled = true;
            this.criteriaList.ItemHeight = 18;
            this.criteriaList.Items.AddRange(new object[] {
            ""});
            this.criteriaList.Location = new System.Drawing.Point(297, 172);
            this.criteriaList.Name = "criteriaList";
            this.criteriaList.Size = new System.Drawing.Size(335, 202);
            this.criteriaList.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rating Criterias";
            // 
            // refreshCriteriaBtn
            // 
            this.refreshCriteriaBtn.BackgroundImage = global::Feedback_System.Properties.Resources.icons8_refresh_48;
            this.refreshCriteriaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshCriteriaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshCriteriaBtn.Location = new System.Drawing.Point(441, 392);
            this.refreshCriteriaBtn.Name = "refreshCriteriaBtn";
            this.refreshCriteriaBtn.Size = new System.Drawing.Size(40, 37);
            this.refreshCriteriaBtn.TabIndex = 15;
            this.refreshCriteriaBtn.UseVisualStyleBackColor = true;
            this.refreshCriteriaBtn.Click += new System.EventHandler(this.refreshCriteriaBtn_Click);
            // 
            // addCriteriaBtn
            // 
            this.addCriteriaBtn.ForeColor = System.Drawing.Color.Green;
            this.addCriteriaBtn.Location = new System.Drawing.Point(770, 306);
            this.addCriteriaBtn.Name = "addCriteriaBtn";
            this.addCriteriaBtn.Size = new System.Drawing.Size(100, 32);
            this.addCriteriaBtn.TabIndex = 14;
            this.addCriteriaBtn.Text = "Add";
            this.addCriteriaBtn.UseVisualStyleBackColor = true;
            this.addCriteriaBtn.Click += new System.EventHandler(this.addCriteriaBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Criteria Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add new Criteria";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(699, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 30);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin Panel";
            // 
            // feedbacksPage
            // 
            this.feedbacksPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.feedbacksPage.Controls.Add(this.label7);
            this.feedbacksPage.Controls.Add(this.sortOrderComboBox);
            this.feedbacksPage.Controls.Add(this.label6);
            this.feedbacksPage.Controls.Add(this.sortByComboBox);
            this.feedbacksPage.Controls.Add(this.label5);
            this.feedbacksPage.Controls.Add(this.saveBtn);
            this.feedbacksPage.Controls.Add(this.bulkImportBtn);
            this.feedbacksPage.Controls.Add(this.feedbacksGridView);
            this.feedbacksPage.Location = new System.Drawing.Point(4, 27);
            this.feedbacksPage.Name = "feedbacksPage";
            this.feedbacksPage.Size = new System.Drawing.Size(1257, 531);
            this.feedbacksPage.TabIndex = 0;
            this.feedbacksPage.Text = "Feedbacks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Customer Feedback";
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(524, 66);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(172, 28);
            this.sortOrderComboBox.TabIndex = 30;
            this.sortOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.sortOrderComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sort Order";
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Location = new System.Drawing.Point(141, 66);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(233, 28);
            this.sortByComboBox.TabIndex = 28;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sort By";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Green;
            this.saveBtn.Location = new System.Drawing.Point(559, 414);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 36);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bulkImportBtn
            // 
            this.bulkImportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkImportBtn.Location = new System.Drawing.Point(1027, 72);
            this.bulkImportBtn.Name = "bulkImportBtn";
            this.bulkImportBtn.Size = new System.Drawing.Size(140, 32);
            this.bulkImportBtn.TabIndex = 25;
            this.bulkImportBtn.Text = "Import from CSV";
            this.bulkImportBtn.UseVisualStyleBackColor = true;
            this.bulkImportBtn.Click += new System.EventHandler(this.bulkImportBtn_Click);
            // 
            // feedbacksGridView
            // 
            this.feedbacksGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedbacksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbacksGridView.GridColor = System.Drawing.Color.CadetBlue;
            this.feedbacksGridView.Location = new System.Drawing.Point(81, 132);
            this.feedbacksGridView.Name = "feedbacksGridView";
            this.feedbacksGridView.RowHeadersWidth = 51;
            this.feedbacksGridView.RowTemplate.Height = 24;
            this.feedbacksGridView.Size = new System.Drawing.Size(1086, 258);
            this.feedbacksGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.chartComboBox);
            this.tabPage1.Controls.Add(this.ratingChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1257, 531);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Reports";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Feedback Report";
            // 
            // chartComboBox
            // 
            this.chartComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartComboBox.FormattingEnabled = true;
            this.chartComboBox.Location = new System.Drawing.Point(942, 30);
            this.chartComboBox.Name = "chartComboBox";
            this.chartComboBox.Size = new System.Drawing.Size(213, 28);
            this.chartComboBox.TabIndex = 1;
            this.chartComboBox.SelectedIndexChanged += new System.EventHandler(this.chartComboBox_SelectedIndexChanged);
            // 
            // ratingChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ratingChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ratingChart.Legends.Add(legend2);
            this.ratingChart.Location = new System.Drawing.Point(253, 94);
            this.ratingChart.Name = "ratingChart";
            this.ratingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ratings";
            this.ratingChart.Series.Add(series2);
            this.ratingChart.Size = new System.Drawing.Size(731, 390);
            this.ratingChart.TabIndex = 0;
            this.ratingChart.Text = "chart1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 562);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl.ResumeLayout(false);
            this.addCriteriaPage.ResumeLayout(false);
            this.addCriteriaPage.PerformLayout();
            this.feedbacksPage.ResumeLayout(false);
            this.feedbacksPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addCriteriaPage;
        private System.Windows.Forms.ListBox criteriaList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshCriteriaBtn;
        private System.Windows.Forms.Button addCriteriaBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage feedbacksPage;
        private System.Windows.Forms.DataGridView feedbacksGridView;
        private System.Windows.Forms.Button bulkImportBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chartComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ratingChart;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}