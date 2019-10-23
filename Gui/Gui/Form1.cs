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
using Logic.Models;


namespace Gui
{
    public partial class Form1 : Form
    {
        FeedController controller = new FeedController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.createFeed(txtUrl.Text, cboxFrequency.SelectedIndex.ToString(), cboxCategory.SelectedIndex.ToString());






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
           controller.createFeed("https://api.sr.se/api/rss/program/407", "Var 5:e minut", "Humor");
            controller.createFeed("https://api.sr.se/api/rss/program/407", "Var 10:e minut", "Humor");




            List<ListViewItem> korv = controller.loadFeed();
            List<ListViewItem> korv2 = controller.loadEpisodes();



            lstAllPodcasts.Items.AddRange(korv.ToArray());
            lstAllEpisodes.Items.AddRange(korv2.ToArray());





        }
    }
}
