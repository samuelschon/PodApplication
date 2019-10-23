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
           List<Feed> aList = controller.getFeed();
          


        }
    }
}
