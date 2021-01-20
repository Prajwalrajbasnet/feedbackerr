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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addCriteriaPage = new System.Windows.Forms.TabPage();
            this.criteriaList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshCriteriaBtn = new System.Windows.Forms.Button();
            this.addCriteriaBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbacksPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.feedbacksGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.addCriteriaPage.SuspendLayout();
            this.feedbacksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addCriteriaPage);
            this.tabControl.Controls.Add(this.feedbacksPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(902, 562);
            this.tabControl.TabIndex = 0;
            // 
            // addCriteriaPage
            // 
            this.addCriteriaPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addCriteriaPage.Controls.Add(this.criteriaList);
            this.addCriteriaPage.Controls.Add(this.label2);
            this.addCriteriaPage.Controls.Add(this.refreshCriteriaBtn);
            this.addCriteriaPage.Controls.Add(this.addCriteriaBtn);
            this.addCriteriaPage.Controls.Add(this.label4);
            this.addCriteriaPage.Controls.Add(this.label3);
            this.addCriteriaPage.Controls.Add(this.textBox1);
            this.addCriteriaPage.Controls.Add(this.label1);
            this.addCriteriaPage.Location = new System.Drawing.Point(4, 25);
            this.addCriteriaPage.Name = "addCriteriaPage";
            this.addCriteriaPage.Size = new System.Drawing.Size(894, 533);
            this.addCriteriaPage.TabIndex = 0;
            this.addCriteriaPage.Text = "Add Criteria";
            // 
            // criteriaList
            // 
            this.criteriaList.FormattingEnabled = true;
            this.criteriaList.ItemHeight = 16;
            this.criteriaList.Items.AddRange(new object[] {
            ""});
            this.criteriaList.Location = new System.Drawing.Point(203, 162);
            this.criteriaList.Name = "criteriaList";
            this.criteriaList.Size = new System.Drawing.Size(243, 212);
            this.criteriaList.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 111);
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
            this.refreshCriteriaBtn.Location = new System.Drawing.Point(300, 391);
            this.refreshCriteriaBtn.Name = "refreshCriteriaBtn";
            this.refreshCriteriaBtn.Size = new System.Drawing.Size(40, 37);
            this.refreshCriteriaBtn.TabIndex = 15;
            this.refreshCriteriaBtn.UseVisualStyleBackColor = true;
            this.refreshCriteriaBtn.Click += new System.EventHandler(this.refreshCriteriaBtn_Click);
            // 
            // addCriteriaBtn
            // 
            this.addCriteriaBtn.Location = new System.Drawing.Point(542, 285);
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
            this.label4.Location = new System.Drawing.Point(502, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Criteria Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add new Criteria";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(505, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 28);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin Panel";
            // 
            // feedbacksPage
            // 
            this.feedbacksPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.feedbacksPage.Controls.Add(this.button1);
            this.feedbacksPage.Controls.Add(this.feedbacksGridView);
            this.feedbacksPage.Location = new System.Drawing.Point(4, 25);
            this.feedbacksPage.Name = "feedbacksPage";
            this.feedbacksPage.Size = new System.Drawing.Size(894, 533);
            this.feedbacksPage.TabIndex = 0;
            this.feedbacksPage.Text = "Feedbacks";
            this.feedbacksPage.Click += new System.EventHandler(this.feedbacksPage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Import from CSV";
            this.button1.UseVisualStyleBackColor = true;
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
            this.feedbacksGridView.Size = new System.Drawing.Size(748, 258);
            this.feedbacksGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 533);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 562);
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
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksGridView)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}