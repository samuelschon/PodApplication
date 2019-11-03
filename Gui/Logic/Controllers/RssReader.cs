using System;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Logic.Controllers
{
    public static class RssReader
    {
        public static SyndicationFeed ReadRss(string url)
        {
            SyndicationFeed feed = new SyndicationFeed();
            try
            {
                XmlReader xmlFeedReader = XmlReader.Create(url);
                feed = SyndicationFeed.Load(xmlFeedReader);
                xmlFeedReader.Close();
            }
            catch (Exception)
            {

             
            }
            

          
            return feed;
        }

    }
}
