using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Logic;
using Logic.Models;


namespace Logic.Controllers
{
    public  class FeedController
    {

        public List<Feed> listOfFeeds = new List<Feed>();

        public void createFeed(string url, string inFrequency, string inCategory)
        {
            XmlReader xmlFeedReader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(xmlFeedReader);
            //listOfFeeds.Add(feed);
            xmlFeedReader.Close();

            Feed a = new Feed(feed, inFrequency, inCategory);

            listOfFeeds.Add(a);
        }

        public  List<ListViewItem> loadFeed()
        {
            List<ListViewItem> allFeeds = new List<ListViewItem>();

            foreach (Feed oneSyndicationFeed in listOfFeeds)
            {
                ListViewItem oneRow = new ListViewItem();
                oneRow.Text = ("");
                oneRow.SubItems.Add(oneSyndicationFeed.feed.Title.Text);
                oneRow.SubItems.Add(oneSyndicationFeed.Frequency);
                oneRow.SubItems.Add(oneSyndicationFeed.Category);



                allFeeds.Add(oneRow);
            }

                return allFeeds;
        }

        public List<ListViewItem> loadEpisodes()
        {
            List<ListViewItem> allEpisodes = new List<ListViewItem>();
            int i = 0;
            foreach (Feed item in listOfFeeds)
            {

                foreach (SyndicationItem anItem in item.feed.Items)
                {
                    i++;


                    ListViewItem oneEpisode = new ListViewItem();
                    oneEpisode.Text = (i.ToString());
                    oneEpisode.SubItems.Add(anItem.Title.Text);
                    oneEpisode.SubItems.Add(anItem.PublishDate.DateTime.ToString());
                    oneEpisode.SubItems.Add(anItem.Summary.Text);

                    allEpisodes.Add(oneEpisode);



                }
                

            }

            return allEpisodes;

        }











        }
}
