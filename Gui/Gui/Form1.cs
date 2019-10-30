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
using Logic;
using Logic.Controllers;
using Logic.Validation;
using SharedModels.Models;

namespace Gui
{
    public partial class txtUpdateFrequency : Form
    {
        FeedController controller = new FeedController();
        CategoryController categoryController = new CategoryController();
      
        public txtUpdateFrequency()
        {
            InitializeComponent();
            txtEditCategoryNewName.Visible = false;
            btnSaveCategoryEdit.Visible = false;


            LoadAllFeeds();
            LoadCategories();

        }

        private void LoadAllFeeds()
        {
             List<Feed> allAvailibleFeeds = new List<Feed>();

             allAvailibleFeeds = controller.GetAllFeeds();
             UpdateFeedList();
            

        }
        private void UpdateFeedList()
        {
            List<Feed> allAvailibleFeeds = new List<Feed>();
            allAvailibleFeeds = controller.GetAllFeeds();
            
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


            boxCategories.Items.Clear();
            cboxCategory.Items.Clear();


            foreach (var category in categories)
            {
                string categoryName = category.Name;

                boxCategories.Items.Add(categoryName);
                cboxCategory.Items.Add(categoryName);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.createFeed(txtUrl.Text, cboxFrequency.SelectedItem.ToString(), cboxCategory.SelectedItem.ToString());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //cboxFrequency.SelectedIndex = 0;
            //cboxCategory.SelectedIndex = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string categoryInput = txtNewCategoryName.Text;
            if (!categoryController.DoesCategoryExist(categoryInput))
            {
                categoryController.CreateCategory(categoryInput);
                LoadCategories();
            }

            else { txtNewCategoryName.Text = "Kategorin finns redan"; } //Ska tas bort

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            if (lstAllFeeds.SelectedItems.Count > 0)
            {
                var selectedFeed = lstAllFeeds.SelectedItems[0].SubItems[1].Text;
                controller.DeleteFeed(selectedFeed);

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
            }
      
        }

        private void lstAllFeeds_DoubleClick(object sender, EventArgs e)
        {




        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = boxCategories.SelectedItem.ToString();
            categoryController.DeleteCategory(selectedCategoryName);
            LoadCategories();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            Feed feed = new Feed();
            
            feed = controller.GetSpecificFeed(feedName);

            txtUrl.Text = feed.Url;
            cboxFrequency.SelectedItem = feed.Frequency;
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

                lstAllEpisodes.Items.Add(oneListRow);
            }

           


        }

        private void btnSaveFeedChanges_Click(object sender, EventArgs e)
        {
            if (lblCurrentFeed.Text !=  "")
            {
                var Url = txtUrl.Text;
                var Frequency = cboxFrequency.SelectedItem.ToString();
                var Category = cboxCategory.SelectedItem.ToString();
                var nameOfFeed = lblCurrentFeed.Text;
                controller.UpdateSpecifikFeed(Url, Frequency, Category, nameOfFeed);
                LoadAllFeeds();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEditCategoryNewName.Visible = true;
            btnSaveCategoryEdit.Visible = true;
        }

        private void btnSaveCategoryEdit_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = boxCategories.SelectedItem.ToString();
            string newCategoryName = txtEditCategoryNewName.Text;

            if (!categoryController.DoesCategoryExist(newCategoryName))
            {

                categoryController.EditCategory(selectedCategoryName, newCategoryName);
                LoadCategories();
                txtEditCategoryNewName.Visible = false;
                    btnSaveCategoryEdit.Visible = false;
        


            }

            else { txtEditCategoryNewName.Text = "Kategorin finns redan"; }
        }
    }
}
