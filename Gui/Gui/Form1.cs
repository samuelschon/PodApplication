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

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SyndicationItem> korv = RssController.getRssFileByUrl(txtUrl.Text);

            foreach (SyndicationItem item in korv)
            {
                ListViewItem oneRow = new ListViewItem();
                oneRow.Text = (item.Title.Text);
                oneRow.SubItems.Add(item.Summary.Text);
                oneRow.SubItems.Add(item.PublishDate.DateTime.ToString());
                oneRow.SubItems.Add(item.LastUpdatedTime.DateTime.ToString());

                lstAllPodcasts.Items.Add(oneRow);

            }






        }
    }
}
