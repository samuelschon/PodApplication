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
          
            Feed feed = new Feed(numberOfEpisodes, name, inFrequency, inCategory, getEpisodes(url), url);
           
            if (!checkIfFeedExist(url))
            {
                AddFeed(feed, Environment.CurrentDirectory + "\\test.json");
            }
            else
            {
                MessageBox.Show("There is already a feed with this Url.");
            }
                
                
        }
        public Boolean checkIfFeedExist(string url)
        {
            Boolean exist = false;
            List<Feed> allFeeds = GetAllFeeds();
            foreach (Feed oneFeed in allFeeds)
            {
                if (oneFeed.Url == url)
                {
                    exist = true;
                    break;
                }
            }


            return exist;
        }



        public List<Feed> GetAllFeeds()
        {
            return serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
        }

        public Feed GetSpecificFeed(string inFeedName) {

           List<Feed> allFeeds = serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
            Feed returnFeed = new Feed();
            foreach (Feed aFeed in allFeeds)
            {
                if (aFeed.Name == inFeedName)
                {
                    returnFeed = aFeed;
                }
            }
            return returnFeed;
        }
        public void UpdateSpecifikFeed(string url, string inFrequency, string inCategory, string nameOfFeed )
        {
            List<Feed> currentFeed = serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
            Feed feed = new Feed();
            foreach (Feed aFeed in currentFeed)
            {
                if (aFeed.Name == nameOfFeed)
                {
                    feed = aFeed;
                    DeleteFeed(nameOfFeed);
                    break;
                }
                


            }





            createFeed(url, inFrequency, inCategory);
            

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
        }
        public void DeleteFeed(string feedName) {

            List<Feed> currentFeed = serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
           
            currentFeed.RemoveAll(x => x.Name == feedName);

            serializer.SerializeList(Environment.CurrentDirectory + "\\test.json",currentFeed);

        }
    }
  

}


