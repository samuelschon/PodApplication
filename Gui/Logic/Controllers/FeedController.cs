using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Data.Services;
using Logic;
using SharedModels.Models;

namespace Logic.Controllers
{
    public  class FeedController
    {
        private SerializerService serializer = new SerializerService();

        public void createFeed(string url, string inFrequency, string inCategory)
        {
         
            SyndicationFeed syndicationFeed = RssReader.ReadRss(url);

            var name = syndicationFeed.Title.Text;
            var numberOfEpisodes = getEpisodes(url).Count;
            Feed feed = new Feed(numberOfEpisodes, name, inFrequency, inCategory, getEpisodes(url));

            AddFeed(feed, Environment.CurrentDirectory + "\\test.json");
        }
        public List<Feed> GetAllFeeds()
        {
            return serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
        }




        public static List<Episode> getEpisodes(string url)
        {
            List<Episode> allEpisodes = new List<Episode>();
            SyndicationFeed feed = RssReader.ReadRss(url);

            foreach (SyndicationItem syndicationItem in feed.Items.ToList())
            {
                Episode episode = new Episode(syndicationItem.Title.Text);

                allEpisodes.Add(episode);

            }

            return allEpisodes;

        }

        public void AddFeed(Feed feed, string path)
        {

           serializer.Serialize(path, feed);

            GetAllFeeds();

        }

        }
}
