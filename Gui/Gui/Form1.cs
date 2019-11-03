using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Controllers;
using Logic.Timers;
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
                oneListRow.SubItems.Add(oneFeed.Frequency);
                oneListRow.SubItems.Add(oneFeed.Category);
                
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
                
                oneListRow.SubItems.Add(oneFeed.Frequency);
                oneListRow.SubItems.Add(oneFeed.Category);

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
            if (ValidationService.isAFeedSelected(lstAllFeeds))
            {
                var selectedFeed = lstAllFeeds.SelectedItems[0].SubItems[1].Text;
                controller.DeleteFeed(selectedFeed);
                LoadAllFeeds();
                UpdateFeedList();
                lstAllEpisodes.Items.Clear();


            }
        }

        private async void btnNewFeed_Click(object sender, EventArgs e)
        {

            

            if (ValidationService.validateComboBox(cboxFrequency) && ValidationService.validateComboBox(cboxCategory))
            {

                string frequency = cboxFrequency.SelectedItem.ToString();
                string categoryName = cboxCategory.SelectedItem.ToString();

                Task createFeedTask = Task.Run(() => controller.createFeed(txtUrl.Text, frequency, categoryName));
                await createFeedTask;


                   
                LoadAllFeeds();
                UpdateFeedList();
               
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            

            string selectedCategoryName = lstAllCategories.SelectedItems[0].Text;

            if (ValidationService.validateIfListViewHasSelectedItem(lstAllCategories) && !ValidationService.doFeedsWithThisCategoryExist(controller.GetAllFeeds(), selectedCategoryName))
            {
               
                categoryController.DeleteCategory(selectedCategoryName);
                LoadCategories();
            }         
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


                lstAllEpisodes.Items.Add(oneListRow);
            }
        }

        private void LoadEpisodeSummary() {

            var feedName = lstAllFeeds.SelectedItems[0].SubItems[1].Text;
          
            Feed feed = controller.GetSpecificFeed(feedName);
            string episodeTitle = lstAllEpisodes.SelectedItems[0].SubItems[1].Text;

            Episode episode = feed.Episodes.Single(x => x.Name == episodeTitle);

            lblEpisodeSummary.Text = episode.Summary;
            lblEpisodeTitle.Text = episode.Name;
            lblEpisodePublished.Text = episode.PublishedDate;


        }

        private async void btnSaveFeedChanges_Click(object sender, EventArgs e)
        {
            if (lblCurrentFeed.Text != "")
            {
                var Url = txtUrl.Text;
                var Frequency = cboxFrequency.SelectedItem.ToString();
                var Category = cboxCategory.SelectedItem.ToString();
                var nameOfFeed = lblCurrentFeed.Text;

           

                Task updateFeedTask = Task.Run(() => controller.UpdateSpecifikFeed(Url, Frequency, Category, nameOfFeed));
                await updateFeedTask;

                //Metoderna nedan ska inte köras om inte createfeed fungerar

           
                LoadAllFeeds();
                UpdateFeedList();
                
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEditCategoryNewName.Visible = true;
            btnSaveCategoryEdit.Visible = true;
        }

        private void btnSaveCategoryEdit_Click(object sender, EventArgs e)
        {
            if (ValidationService.validateIfListViewHasSelectedItem(lstAllCategories))
            {

                string selectedCategoryName = lstAllCategories.SelectedItems[0].Text;
                string newCategoryName = txtEditCategoryNewName.Text;

                if (!categoryController.DoesCategoryExist(newCategoryName))
                {
                    categoryController.EditCategory(selectedCategoryName, newCategoryName);
                    LoadCategories();
                    LoadAllFeeds();
                    UpdateFeedList();
                    txtEditCategoryNewName.Visible = false;
                    btnSaveCategoryEdit.Visible = false;
                }
                else { MessageBox.Show("Kategorin finns redan"); }
            }
        }

        private void btnResetView_Click_1(object sender, EventArgs e)
        {
            LoadAllFeeds();
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



        private void lstAllEpisodes_MouseClick(object sender, MouseEventArgs e)
        {
            if (ValidationService.isAFeedSelected(lstAllFeeds))
            {

                LoadEpisodeSummary();
            }
        }


        private void txtUpdateFrequency_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadAllFeeds();
            UpdateFeedList();
            
        }
    }
}
