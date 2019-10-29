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
using SharedModels.Models;

namespace Gui
{
    public partial class txtUpdateFrequency : Form
    {
        FeedController controller = new FeedController();
        CategoryController categoryController = new CategoryController();
        private List<Feed> allAvailibleFeeds;
        public txtUpdateFrequency()
        {
            InitializeComponent();
            allAvailibleFeeds = new List<Feed>();
            LoadAllFeeds();
            LoadCategories();

        }




        private void LoadAllFeeds()
        {
            var feeds = controller.GetAllFeeds();
            if (feeds != null)
            {
                allAvailibleFeeds = feeds;
                UpdateFeedList();
            }

        }
        private void UpdateFeedList()
        {
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
            //List<Feed> aList = controller.getFeed();



        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboxFrequency.SelectedIndex = 0;
            cboxCategory.SelectedIndex = 0;











        }

        private void button6_Click(object sender, EventArgs e)
        {
            string categoryInput = txtNewCategoryName.Text;
            categoryController.CreateCategory(categoryInput);
            LoadCategories();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {

        }

        private void btnNewFeed_Click(object sender, EventArgs e)
        {
            controller.createFeed(txtUrl.Text, cboxFrequency.SelectedItem.ToString(), cboxCategory.SelectedItem.ToString());
            LoadAllFeeds();
            UpdateFeedList();
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
    }
}
