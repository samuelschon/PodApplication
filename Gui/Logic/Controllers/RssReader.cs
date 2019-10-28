using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logic.Controllers
{
   public static class RssReader
    {


        public static SyndicationFeed ReadRss(string url)
        {
            XmlReader xmlFeedReader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(xmlFeedReader);
         
            xmlFeedReader.Close();


            return feed;
        }

    }
}
