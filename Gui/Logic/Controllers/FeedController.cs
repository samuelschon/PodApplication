using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Logic;
using Logic.Models;

namespace Logic.Controllers
{
    public  class FeedController
    {
        public List<Feed> listOfAllFeeds = new List<Feed>();
        

        public void createFeed(string url, string inFrequency, string inCategory)
        {
            XmlReader xmlFeedReader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(xmlFeedReader);
            xmlFeedReader.Close();


            listOfAllFeeds.Add(new Feed(feed, inFrequency, inCategory));



        }

        public  List<Feed> getFeed()
        {
            return listOfAllFeeds;
     



        }








    }
}
