using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Controllers;
using Logic.Validation;
using SharedModels.Models;

namespace Gui
{
    public partial class txtUpdateFrequency : Form
    {
        private readonly FeedController controller = new FeedController();
        private readonly CategoryController categoryController = new CategoryController();
        private List<Feed> allAvailibleFeeds;
        public txtUpdateFrequency()
        {
            InitializeComponent();
            txtEditCategoryNewName.Visible = false;
            btnSaveCategoryEdit.Visible = false;

            allAvailibleFeeds = new List<Feed>();

            LoadAllFeeds();
            UpdateFeedList();
            LoadCategories();
            starttimers();

        }

        private void starttimers()
        {
            foreach (Feed oneFeed in allAvailibleFeeds)
            {
                controller.StartFeedTimer(oneFeed);
            }
        }

        private void LoadAllFeeds()
        {
            allAvailibleFeeds = controller.GetAllFeeds();
        }

        private void UpdateFeedList()
        {
            lstAllFeeds.Items.Clear();

            foreach (Feed oneFeed in allAvailibleFeeds)
            {
                var oneListRow = new ListViewItem();
                oneListRow.Text = oneFeed.Episodes.Count.ToString();
                oneListRow.SubItems.Add(oneFeed.Name);
                oneListRow.SubItems.Add(oneFeed.Category);
                oneListRow.SubItems.Add(oneFeed.Frequency);
                lstAllFeeds.Items.Add(oneListRow);
            }
        }

        private void UpdateFeedListByCategory(string categoryName)
        {
            List<Feed> allAvailibleFeeds = new List<Feed>();
            
            allAvailibleFeeds = controller.GetAllFeeds();
            allAvailibleFeeds.RemoveAll(x => x.Category != categoryName);

            lstAllFeeds.Items.Clear();

            foreach (Feed oneFeed in allAvailibleFeeds)
            {
                ListViewItem oneListRow = new ListViewItem();
                oneListRow.Text = oneFeed.Episodes.Count.ToString();
                oneListRow.SubItems.Add(oneFeed.Name);
                oneListRow.SubItems.Add(oneFeed.Category);
                oneListRow.SubItems.Add(oneFeed.Frequency);

                lstAllFeeds.Items.Add(oneListRow);
            }
        }

        private void LoadCategories()
        {
            List<Category> categories = categoryController.GetCategories();
 
            cboxCategory.Items.Clear();
            lstAllCategories.Items.Clear();

            foreach (var category in categories)
            {
                string categoryName = category.Name;

                lstAllCategories.Items.Add(categoryName);
                cboxCategory.Items.Add(categoryName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.createFeed(txtUrl.Text, cboxFrequency.SelectedItem.ToString(), cboxCategory.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string categoryInput = txtNewCategoryName.Text;

            if (ValidationService.checkIfSpecialLetters(categoryInput) && ValidationService.checkLength(categoryInput))
            {
                if (!categoryController.DoesCategoryExist(categoryInput))
                {
                    categoryController.CreateCategory(categoryInput);
                    LoadCategories();
                }
                else 
                { MessageBox.Show("Kategorin finns redan"); }  //ska tas bort
            }
        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            if (lstAllFeeds.SelectedItems.Count > 0)
            {
                var selectedFeed = lstAllFeeds.SelectedItems[0].SubItems[1].Text;
                controller.DeleteFeed(selectedFeed);
                LoadAllFeeds();
                UpdateFeedList();
            }
        }

        private void btnNewFeed_Click(object sender, EventArgs e)
        {
            if (ValidationService.validateComboBox(cboxFrequency) && ValidationService.validateComboBox(cboxCategory))
            {
                controller.createFeed(txtUrl.Text, cboxFrequency.SelectedItem.ToString(), cboxCategory.SelectedItem.ToString());
                LoadAllFeeds();
                UpdateFeedList();
                starttimers();
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            //kontroll om den e tom

            string selectedCategoryName = lstAllCategories.SelectedItems[0].Text;

            if (ValidationService.validateIfListViewHasSelectedItem(lstAllCategories) && !ValidationService.doFeedsWithThisCategoryExist(controller.GetAllFeeds(), selectedCategoryName))
            {
               
                categoryController.DeleteCategory(selectedCategoryName);
                LoadCategories();
            }         
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            controller.createFeed("https://api.sr.se/api/rss/program/2447", cboxFrequency.SelectedItem.ToString(), cboxCategory.SelectedItem.ToString());
            LoadAllFeeds();
            UpdateFeedList();
        }

        private void lstAllFeeds_MouseClick(object sender, MouseEventArgs e)
        {
            var feedName = lstAllFeeds.SelectedItems[0].SubItems[1].Text;
          
            Feed feed = controller.GetSpecificFeed(feedName);

            txtUrl.Text = feed.Url;
            cboxFrequency.SelectedItem = feed.Frequency;
            cboxCategory.SelectedItem = null;
            cboxCategory.SelectedItem = feed.Category;
            lblCurrentFeed.Text = feed.Name;

            LoadEpisodes(feed);
        }

        private void LoadEpisodes(Feed feed)
        {
            lstAllEpisodes.Items.Clear();
            int counter = 0;
            foreach (Episode oneEpisode in feed.Episodes)
            {
                counter++;

                ListViewItem oneListRow = new ListViewItem();

                oneListRow.Text = counter.ToString();
                oneListRow.SubItems.Add(oneEpisode.Name);
                oneListRow.SubItems.Add(oneEpisode.Summary);
                oneListRow.SubItems.Add(oneEpisode.PublishedDate);

                lstAllEpisodes.Items.Add(oneListRow);
            }
        }

        private void btnSaveFeedChanges_Click(object sender, EventArgs e)
        {
            if (lblCurrentFeed.Text != "")
            {
                var Url = txtUrl.Text;
                var Frequency = cboxFrequency.SelectedItem.ToString();
                var Category = cboxCategory.SelectedItem.ToString();
                var nameOfFeed = lblCurrentFeed.Text;
                controller.UpdateSpecifikFeed(Url, Frequency, Category, nameOfFeed);
                LoadAllFeeds();
                UpdateFeedList();
                starttimers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEditCategoryNewName.Visible = true;
            btnSaveCategoryEdit.Visible = true;
        }

        private void btnSaveCategoryEdit_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = lstAllCategories.SelectedItems[0].Text;
            string newCategoryName = txtEditCategoryNewName.Text;

            if (!categoryController.DoesCategoryExist(newCategoryName))
            {
                categoryController.EditCategory(selectedCategoryName, newCategoryName);
                LoadCategories();
                txtEditCategoryNewName.Visible = false;
                btnSaveCategoryEdit.Visible = false;
            }
            else { MessageBox.Show( "Kategorin finns redan"); }
        }

        private void btnResetView_Click_1(object sender, EventArgs e)
        {
            UpdateFeedList();
        }

        private void lstAllCategories_MouseClick(object sender, MouseEventArgs e)
        {
            if (ValidationService.validateIfListViewHasSelectedItem(lstAllCategories))
            {
                string selectedCategoryName = lstAllCategories.SelectedItems[0].Text;
                UpdateFeedListByCategory(selectedCategoryName);
            }
        }

    }
}
