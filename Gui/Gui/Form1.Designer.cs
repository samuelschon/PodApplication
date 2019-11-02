namespace Gui
{
    partial class txtUpdateFrequency
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
            this.label4 = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.cboxFrequency = new System.Windows.Forms.ComboBox();
            this.lstAllEpisodes = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnDeleteFeed = new System.Windows.Forms.Button();
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEpisode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAllFeeds = new System.Windows.Forms.ListView();
            this.txtNewCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewFeed = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveFeedChanges = new System.Windows.Forms.Button();
            this.lblCurrentFeed = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSaveCategoryEdit = new System.Windows.Forms.Button();
            this.txtEditCategoryNewName = new System.Windows.Forms.TextBox();
            this.btnResetView = new System.Windows.Forms.Button();
            this.lstAllCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEpisodeSummary = new System.Windows.Forms.Label();
            this.lblEpisodeTitle = new System.Windows.Forms.Label();
            this.lblEpisodePublished = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(802, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 1202);
            this.label4.TabIndex = 39;
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Items.AddRange(new object[] {
            "Historia",
            "Humor"});
            this.cboxCategory.Location = new System.Drawing.Point(645, 440);
            this.cboxCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(116, 28);
            this.cboxCategory.TabIndex = 36;
            // 
            // cboxFrequency
            // 
            this.cboxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFrequency.FormattingEnabled = true;
            this.cboxFrequency.Items.AddRange(new object[] {
            "Var 1:a minut",
            "Var 5:e minut",
            "Var 10:e minut",
            "Var 15:e minut",
            "Var 20:e minut"});
            this.cboxFrequency.Location = new System.Drawing.Point(459, 440);
            this.cboxFrequency.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboxFrequency.Name = "cboxFrequency";
            this.cboxFrequency.Size = new System.Drawing.Size(172, 28);
            this.cboxFrequency.TabIndex = 35;
            // 
            // lstAllEpisodes
            // 
            this.lstAllEpisodes.AutoArrange = false;
            this.lstAllEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7});
            this.lstAllEpisodes.FullRowSelect = true;
            this.lstAllEpisodes.HideSelection = false;
            this.lstAllEpisodes.Location = new System.Drawing.Point(30, 623);
            this.lstAllEpisodes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstAllEpisodes.Name = "lstAllEpisodes";
            this.lstAllEpisodes.Size = new System.Drawing.Size(415, 358);
            this.lstAllEpisodes.TabIndex = 33;
            this.lstAllEpisodes.UseCompatibleStateImageBehavior = false;
            this.lstAllEpisodes.View = System.Windows.Forms.View.Details;
            this.lstAllEpisodes.SelectedIndexChanged += new System.EventHandler(this.lstAllEpisodes_SelectedIndexChanged);
            this.lstAllEpisodes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAllEpisodes_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Title";
            this.columnHeader7.Width = 185;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(824, 597);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(147, 52);
            this.btnRemoveCategory.TabIndex = 32;
            this.btnRemoveCategory.Text = "Ta bort..";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(824, 515);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(147, 52);
            this.btnNewCategory.TabIndex = 30;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(348, 489);
            this.btnDeleteFeed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(147, 52);
            this.btnDeleteFeed.TabIndex = 29;
            this.btnDeleteFeed.Text = "Ta bort...";
            this.btnDeleteFeed.UseVisualStyleBackColor = true;
            this.btnDeleteFeed.Click += new System.EventHandler(this.btnDeleteFeed_Click);
            // 
            // colCategory
            // 
            this.colCategory.Text = "Kategori";
            this.colCategory.Width = 126;
            // 
            // colFrequency
            // 
            this.colFrequency.Text = "Frekvens";
            this.colFrequency.Width = 56;
            // 
            // colName
            // 
            this.colName.Text = "Namn";
            this.colName.Width = 128;
            // 
            // colEpisode
            // 
            this.colEpisode.Text = "Avsnitt";
            // 
            // lstAllFeeds
            // 
            this.lstAllFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEpisode,
            this.colName,
            this.colFrequency,
            this.colCategory});
            this.lstAllFeeds.FullRowSelect = true;
            this.lstAllFeeds.HideSelection = false;
            this.lstAllFeeds.Location = new System.Drawing.Point(30, 18);
            this.lstAllFeeds.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstAllFeeds.Name = "lstAllFeeds";
            this.lstAllFeeds.Size = new System.Drawing.Size(559, 358);
            this.lstAllFeeds.TabIndex = 27;
            this.lstAllFeeds.UseCompatibleStateImageBehavior = false;
            this.lstAllFeeds.View = System.Windows.Forms.View.Details;
            this.lstAllFeeds.SelectedIndexChanged += new System.EventHandler(this.lstAllFeeds_SelectedIndexChanged);
            this.lstAllFeeds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAllFeeds_MouseClick);
            // 
            // txtNewCategoryName
            // 
            this.txtNewCategoryName.Location = new System.Drawing.Point(824, 472);
            this.txtNewCategoryName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNewCategoryName.Name = "txtNewCategoryName";
            this.txtNewCategoryName.Size = new System.Drawing.Size(358, 26);
            this.txtNewCategoryName.TabIndex = 26;
            this.txtNewCategoryName.TextChanged += new System.EventHandler(this.txtNewCategoryName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "URL";
            // 
            // btnNewFeed
            // 
            this.btnNewFeed.Location = new System.Drawing.Point(30, 489);
            this.btnNewFeed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewFeed.Name = "btnNewFeed";
            this.btnNewFeed.Size = new System.Drawing.Size(147, 52);
            this.btnNewFeed.TabIndex = 24;
            this.btnNewFeed.Text = "Ny...";
            this.btnNewFeed.UseVisualStyleBackColor = true;
            this.btnNewFeed.Click += new System.EventHandler(this.btnNewFeed_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(30, 442);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(415, 26);
            this.txtUrl.TabIndex = 23;
            this.txtUrl.Text = "https://api.sr.se/api/rss/program/407";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Uppdateringsfrekvens:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ny2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSaveFeedChanges
            // 
            this.btnSaveFeedChanges.Location = new System.Drawing.Point(189, 489);
            this.btnSaveFeedChanges.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveFeedChanges.Name = "btnSaveFeedChanges";
            this.btnSaveFeedChanges.Size = new System.Drawing.Size(147, 52);
            this.btnSaveFeedChanges.TabIndex = 44;
            this.btnSaveFeedChanges.Text = "Spara";
            this.btnSaveFeedChanges.UseVisualStyleBackColor = true;
            this.btnSaveFeedChanges.Click += new System.EventHandler(this.btnSaveFeedChanges_Click);
            // 
            // lblCurrentFeed
            // 
            this.lblCurrentFeed.Location = new System.Drawing.Point(26, 558);
            this.lblCurrentFeed.Name = "lblCurrentFeed";
            this.lblCurrentFeed.Size = new System.Drawing.Size(183, 35);
            this.lblCurrentFeed.TabIndex = 45;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(982, 515);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 52);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Ändra";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSaveCategoryEdit
            // 
            this.btnSaveCategoryEdit.Location = new System.Drawing.Point(824, 915);
            this.btnSaveCategoryEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveCategoryEdit.Name = "btnSaveCategoryEdit";
            this.btnSaveCategoryEdit.Size = new System.Drawing.Size(147, 52);
            this.btnSaveCategoryEdit.TabIndex = 48;
            this.btnSaveCategoryEdit.Text = "Spara";
            this.btnSaveCategoryEdit.UseVisualStyleBackColor = true;
            this.btnSaveCategoryEdit.Click += new System.EventHandler(this.btnSaveCategoryEdit_Click);
            // 
            // txtEditCategoryNewName
            // 
            this.txtEditCategoryNewName.Location = new System.Drawing.Point(818, 872);
            this.txtEditCategoryNewName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEditCategoryNewName.Name = "txtEditCategoryNewName";
            this.txtEditCategoryNewName.Size = new System.Drawing.Size(358, 26);
            this.txtEditCategoryNewName.TabIndex = 49;
            // 
            // btnResetView
            // 
            this.btnResetView.Location = new System.Drawing.Point(633, 20);
            this.btnResetView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(147, 52);
            this.btnResetView.TabIndex = 51;
            this.btnResetView.Text = "Återställ vy";
            this.btnResetView.UseVisualStyleBackColor = true;
            this.btnResetView.Click += new System.EventHandler(this.btnResetView_Click_1);
            // 
            // lstAllCategories
            // 
            this.lstAllCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstAllCategories.HideSelection = false;
            this.lstAllCategories.Location = new System.Drawing.Point(824, 18);
            this.lstAllCategories.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lstAllCategories.Name = "lstAllCategories";
            this.lstAllCategories.Size = new System.Drawing.Size(397, 422);
            this.lstAllCategories.TabIndex = 52;
            this.lstAllCategories.UseCompatibleStateImageBehavior = false;
            this.lstAllCategories.View = System.Windows.Forms.View.Details;
            this.lstAllCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAllCategories_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category Name";
            // 
            // lblEpisodeSummary
            // 
            this.lblEpisodeSummary.Location = new System.Drawing.Point(454, 683);
            this.lblEpisodeSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodeSummary.Name = "lblEpisodeSummary";
            this.lblEpisodeSummary.Size = new System.Drawing.Size(326, 191);
            this.lblEpisodeSummary.TabIndex = 54;
            this.lblEpisodeSummary.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblEpisodeTitle
            // 
            this.lblEpisodeTitle.Location = new System.Drawing.Point(458, 618);
            this.lblEpisodeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodeTitle.Name = "lblEpisodeTitle";
            this.lblEpisodeTitle.Size = new System.Drawing.Size(266, 35);
            this.lblEpisodeTitle.TabIndex = 55;
            // 
            // lblEpisodePublished
            // 
            this.lblEpisodePublished.Location = new System.Drawing.Point(453, 868);
            this.lblEpisodePublished.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodePublished.Name = "lblEpisodePublished";
            this.lblEpisodePublished.Size = new System.Drawing.Size(266, 35);
            this.lblEpisodePublished.TabIndex = 56;
            this.lblEpisodePublished.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtUpdateFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 1028);
            this.Controls.Add(this.lblEpisodePublished);
            this.Controls.Add(this.lblEpisodeTitle);
            this.Controls.Add(this.lblEpisodeSummary);
            this.Controls.Add(this.lstAllCategories);
            this.Controls.Add(this.btnResetView);
            this.Controls.Add(this.txtEditCategoryNewName);
            this.Controls.Add(this.btnSaveCategoryEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCurrentFeed);
            this.Controls.Add(this.btnSaveFeedChanges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.cboxFrequency);
            this.Controls.Add(this.lstAllEpisodes);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.btnDeleteFeed);
            this.Controls.Add(this.lstAllFeeds);
            this.Controls.Add(this.txtNewCategoryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewFeed);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "txtUpdateFrequency";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.txtUpdateFrequency_FormClosing);
            this.Load += new System.EventHandler(this.txtUpdateFrequency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.ComboBox cboxFrequency;
        private System.Windows.Forms.ListView lstAllEpisodes;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnDeleteFeed;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colFrequency;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEpisode;
        private System.Windows.Forms.ListView lstAllFeeds;
        private System.Windows.Forms.TextBox txtNewCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewFeed;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveFeedChanges;
        private System.Windows.Forms.Label lblCurrentFeed;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveCategoryEdit;
        private System.Windows.Forms.TextBox txtEditCategoryNewName;
        private System.Windows.Forms.Button btnResetView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lstAllCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblEpisodeSummary;
        private System.Windows.Forms.Label lblEpisodeTitle;
        private System.Windows.Forms.Label lblEpisodePublished;
    }
}

