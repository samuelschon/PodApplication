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
            this.label4.Location = new System.Drawing.Point(535, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(3, 781);
            this.label4.TabIndex = 39;
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Items.AddRange(new object[] {
            "Historia",
            "Humor"});
            this.cboxCategory.Location = new System.Drawing.Point(430, 286);
            this.cboxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(79, 21);
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
            this.cboxFrequency.Location = new System.Drawing.Point(306, 286);
            this.cboxFrequency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxFrequency.Name = "cboxFrequency";
            this.cboxFrequency.Size = new System.Drawing.Size(116, 21);
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
            this.lstAllEpisodes.Location = new System.Drawing.Point(20, 405);
            this.lstAllEpisodes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstAllEpisodes.Name = "lstAllEpisodes";
            this.lstAllEpisodes.Size = new System.Drawing.Size(278, 234);
            this.lstAllEpisodes.TabIndex = 33;
            this.lstAllEpisodes.UseCompatibleStateImageBehavior = false;
            this.lstAllEpisodes.View = System.Windows.Forms.View.Details;
            
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
            this.btnRemoveCategory.Location = new System.Drawing.Point(549, 388);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(98, 34);
            this.btnRemoveCategory.TabIndex = 32;
            this.btnRemoveCategory.Text = "Ta bort..";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(549, 335);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(98, 34);
            this.btnNewCategory.TabIndex = 30;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(232, 318);
            this.btnDeleteFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(98, 34);
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
            this.lstAllFeeds.Location = new System.Drawing.Point(20, 12);
            this.lstAllFeeds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstAllFeeds.Name = "lstAllFeeds";
            this.lstAllFeeds.Size = new System.Drawing.Size(374, 234);
            this.lstAllFeeds.TabIndex = 27;
            this.lstAllFeeds.UseCompatibleStateImageBehavior = false;
            this.lstAllFeeds.View = System.Windows.Forms.View.Details;
         
            this.lstAllFeeds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAllFeeds_MouseClick);
            // 
            // txtNewCategoryName
            // 
            this.txtNewCategoryName.Location = new System.Drawing.Point(549, 307);
            this.txtNewCategoryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewCategoryName.Name = "txtNewCategoryName";
            this.txtNewCategoryName.Size = new System.Drawing.Size(240, 20);
            this.txtNewCategoryName.TabIndex = 26;
        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "URL";
            // 
            // btnNewFeed
            // 
            this.btnNewFeed.Location = new System.Drawing.Point(20, 318);
            this.btnNewFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewFeed.Name = "btnNewFeed";
            this.btnNewFeed.Size = new System.Drawing.Size(98, 34);
            this.btnNewFeed.TabIndex = 24;
            this.btnNewFeed.Text = "Ny...";
            this.btnNewFeed.UseVisualStyleBackColor = true;
            this.btnNewFeed.Click += new System.EventHandler(this.btnNewFeed_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(20, 287);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(278, 20);
            this.txtUrl.TabIndex = 23;
            this.txtUrl.Text = "https://api.sr.se/api/rss/program/407";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Uppdateringsfrekvens:";
            // 
            // btnSaveFeedChanges
            // 
            this.btnSaveFeedChanges.Location = new System.Drawing.Point(126, 318);
            this.btnSaveFeedChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveFeedChanges.Name = "btnSaveFeedChanges";
            this.btnSaveFeedChanges.Size = new System.Drawing.Size(98, 34);
            this.btnSaveFeedChanges.TabIndex = 44;
            this.btnSaveFeedChanges.Text = "Spara";
            this.btnSaveFeedChanges.UseVisualStyleBackColor = true;
            this.btnSaveFeedChanges.Click += new System.EventHandler(this.btnSaveFeedChanges_Click);
            // 
            // lblCurrentFeed
            // 
            this.lblCurrentFeed.Location = new System.Drawing.Point(17, 363);
            this.lblCurrentFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentFeed.Name = "lblCurrentFeed";
            this.lblCurrentFeed.Size = new System.Drawing.Size(122, 23);
            this.lblCurrentFeed.TabIndex = 45;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(655, 335);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 34);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Ändra";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSaveCategoryEdit
            // 
            this.btnSaveCategoryEdit.Location = new System.Drawing.Point(549, 595);
            this.btnSaveCategoryEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveCategoryEdit.Name = "btnSaveCategoryEdit";
            this.btnSaveCategoryEdit.Size = new System.Drawing.Size(98, 34);
            this.btnSaveCategoryEdit.TabIndex = 48;
            this.btnSaveCategoryEdit.Text = "Spara";
            this.btnSaveCategoryEdit.UseVisualStyleBackColor = true;
            this.btnSaveCategoryEdit.Click += new System.EventHandler(this.btnSaveCategoryEdit_Click);
            // 
            // txtEditCategoryNewName
            // 
            this.txtEditCategoryNewName.Location = new System.Drawing.Point(545, 567);
            this.txtEditCategoryNewName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditCategoryNewName.Name = "txtEditCategoryNewName";
            this.txtEditCategoryNewName.Size = new System.Drawing.Size(240, 20);
            this.txtEditCategoryNewName.TabIndex = 49;
            // 
            // btnResetView
            // 
            this.btnResetView.Location = new System.Drawing.Point(422, 13);
            this.btnResetView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(98, 34);
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
            this.lstAllCategories.Location = new System.Drawing.Point(549, 12);
            this.lstAllCategories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstAllCategories.Name = "lstAllCategories";
            this.lstAllCategories.Size = new System.Drawing.Size(266, 276);
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
            this.lblEpisodeSummary.Location = new System.Drawing.Point(303, 444);
            this.lblEpisodeSummary.Name = "lblEpisodeSummary";
            this.lblEpisodeSummary.Size = new System.Drawing.Size(217, 124);
            this.lblEpisodeSummary.TabIndex = 54;
           
            // 
            // lblEpisodeTitle
            // 
            this.lblEpisodeTitle.Location = new System.Drawing.Point(305, 402);
            this.lblEpisodeTitle.Name = "lblEpisodeTitle";
            this.lblEpisodeTitle.Size = new System.Drawing.Size(177, 23);
            this.lblEpisodeTitle.TabIndex = 55;
            // 
            // lblEpisodePublished
            // 
            this.lblEpisodePublished.Location = new System.Drawing.Point(302, 564);
            this.lblEpisodePublished.Name = "lblEpisodePublished";
            this.lblEpisodePublished.Size = new System.Drawing.Size(177, 23);
            this.lblEpisodePublished.TabIndex = 56;
            
            // 
            // txtUpdateFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 668);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "txtUpdateFrequency";
            this.Text = "Form1";
            
            
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

