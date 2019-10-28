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



namespace Gui
{
    public partial class txtUpdateFrequency : Form
    {
        FeedController controller = new FeedController();
        public txtUpdateFrequency()
        {
            InitializeComponent();
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
      
      




           





        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
