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
            this.label5 = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.cboxFrequency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstAllEpisodes = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnSortFeedsByCategory = new System.Windows.Forms.Button();
            this.btnResetView = new System.Windows.Forms.Button();
            this.lstAllCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(717, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 962);
            this.label4.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(732, 646);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 12);
            this.label5.TabIndex = 37;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Items.AddRange(new object[] {
            "Historia",
            "Humor"});
            this.cboxCategory.Location = new System.Drawing.Point(573, 404);
            this.cboxCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(104, 24);
            this.cboxCategory.TabIndex = 36;
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            this.cboxFrequency.Location = new System.Drawing.Point(408, 404);
            this.cboxFrequency.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboxFrequency.Name = "cboxFrequency";
            this.cboxFrequency.Size = new System.Drawing.Size(153, 24);
            this.cboxFrequency.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(725, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 12);
            this.label6.TabIndex = 38;
            // 
            // lstAllEpisodes
            // 
            this.lstAllEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstAllEpisodes.HideSelection = false;
            this.lstAllEpisodes.Location = new System.Drawing.Point(56, 569);
            this.lstAllEpisodes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstAllEpisodes.Name = "lstAllEpisodes";
            this.lstAllEpisodes.Size = new System.Drawing.Size(457, 166);
            this.lstAllEpisodes.TabIndex = 33;
            this.lstAllEpisodes.UseCompatibleStateImageBehavior = false;
            this.lstAllEpisodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Title";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Summary";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Publish date";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(896, 466);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(131, 42);
            this.btnRemoveCategory.TabIndex = 32;
            this.btnRemoveCategory.Text = "Ta bort..";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(755, 466);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(131, 42);
            this.btnNewCategory.TabIndex = 30;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(336, 466);
            this.btnDeleteFeed.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(131, 42);
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
            this.lstAllFeeds.HideSelection = false;
            this.lstAllFeeds.Location = new System.Drawing.Point(27, 14);
            this.lstAllFeeds.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstAllFeeds.Name = "lstAllFeeds";
            this.lstAllFeeds.Size = new System.Drawing.Size(519, 354);
            this.lstAllFeeds.TabIndex = 27;
            this.lstAllFeeds.UseCompatibleStateImageBehavior = false;
            this.lstAllFeeds.View = System.Windows.Forms.View.Details;
            this.lstAllFeeds.DoubleClick += new System.EventHandler(this.lstAllFeeds_DoubleClick);
            this.lstAllFeeds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAllFeeds_MouseClick);
            // 
            // txtNewCategoryName
            // 
            this.txtNewCategoryName.Location = new System.Drawing.Point(732, 405);
            this.txtNewCategoryName.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewCategoryName.Name = "txtNewCategoryName";
            this.txtNewCategoryName.Size = new System.Drawing.Size(319, 22);
            this.txtNewCategoryName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "URL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnNewFeed
            // 
            this.btnNewFeed.Location = new System.Drawing.Point(56, 466);
            this.btnNewFeed.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewFeed.Name = "btnNewFeed";
            this.btnNewFeed.Size = new System.Drawing.Size(131, 42);
            this.btnNewFeed.TabIndex = 24;
            this.btnNewFeed.Text = "Ny...";
            this.btnNewFeed.UseVisualStyleBackColor = true;
            this.btnNewFeed.Click += new System.EventHandler(this.btnNewFeed_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(27, 405);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(369, 22);
            this.txtUrl.TabIndex = 23;
            this.txtUrl.Text = "https://api.sr.se/api/rss/program/407";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Uppdateringsfrekvens:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ny2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSaveFeedChanges
            // 
            this.btnSaveFeedChanges.Location = new System.Drawing.Point(197, 466);
            this.btnSaveFeedChanges.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveFeedChanges.Name = "btnSaveFeedChanges";
            this.btnSaveFeedChanges.Size = new System.Drawing.Size(131, 42);
            this.btnSaveFeedChanges.TabIndex = 44;
            this.btnSaveFeedChanges.Text = "Spara";
            this.btnSaveFeedChanges.UseVisualStyleBackColor = true;
            this.btnSaveFeedChanges.Click += new System.EventHandler(this.btnSaveFeedChanges_Click);
            // 
            // lblCurrentFeed
            // 
            this.lblCurrentFeed.AutoSize = true;
            this.lblCurrentFeed.Location = new System.Drawing.Point(69, 433);
            this.lblCurrentFeed.Name = "lblCurrentFeed";
            this.lblCurrentFeed.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentFeed.TabIndex = 45;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1037, 466);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 42);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Ändra";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSaveCategoryEdit
            // 
            this.btnSaveCategoryEdit.Location = new System.Drawing.Point(1063, 559);
            this.btnSaveCategoryEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveCategoryEdit.Name = "btnSaveCategoryEdit";
            this.btnSaveCategoryEdit.Size = new System.Drawing.Size(131, 42);
            this.btnSaveCategoryEdit.TabIndex = 48;
            this.btnSaveCategoryEdit.Text = "Spara";
            this.btnSaveCategoryEdit.UseVisualStyleBackColor = true;
            this.btnSaveCategoryEdit.Click += new System.EventHandler(this.btnSaveCategoryEdit_Click);
            // 
            // txtEditCategoryNewName
            // 
            this.txtEditCategoryNewName.Location = new System.Drawing.Point(732, 569);
            this.txtEditCategoryNewName.Margin = new System.Windows.Forms.Padding(5);
            this.txtEditCategoryNewName.Name = "txtEditCategoryNewName";
            this.txtEditCategoryNewName.Size = new System.Drawing.Size(319, 22);
            this.txtEditCategoryNewName.TabIndex = 49;
            // 
            // btnSortFeedsByCategory
            // 
            this.btnSortFeedsByCategory.Location = new System.Drawing.Point(1093, 75);
            this.btnSortFeedsByCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnSortFeedsByCategory.Name = "btnSortFeedsByCategory";
            this.btnSortFeedsByCategory.Size = new System.Drawing.Size(131, 68);
            this.btnSortFeedsByCategory.TabIndex = 50;
            this.btnSortFeedsByCategory.Text = "Visa podcasts med vald kategori";
            this.btnSortFeedsByCategory.UseVisualStyleBackColor = true;
            // 
            // btnResetView
            // 
            this.btnResetView.Location = new System.Drawing.Point(564, 42);
            this.btnResetView.Margin = new System.Windows.Forms.Padding(5);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(131, 42);
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
            this.lstAllCategories.Location = new System.Drawing.Point(732, 14);
            this.lstAllCategories.Name = "lstAllCategories";
            this.lstAllCategories.Size = new System.Drawing.Size(353, 338);
            this.lstAllCategories.TabIndex = 52;
            this.lstAllCategories.UseCompatibleStateImageBehavior = false;
            this.lstAllCategories.View = System.Windows.Forms.View.Details;
            this.lstAllCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAllCategories_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category Name";
            // 
            // txtUpdateFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 840);
            this.Controls.Add(this.lstAllCategories);
            this.Controls.Add(this.btnResetView);
            this.Controls.Add(this.btnSortFeedsByCategory);
            this.Controls.Add(this.txtEditCategoryNewName);
            this.Controls.Add(this.btnSaveCategoryEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCurrentFeed);
            this.Controls.Add(this.btnSaveFeedChanges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.cboxFrequency);
            this.Controls.Add(this.label6);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.ComboBox cboxFrequency;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btnSortFeedsByCategory;
        private System.Windows.Forms.Button btnResetView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lstAllCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

