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
            XmlReader xmlFeedReader = XmlReader.Create(url);
            SyndicationFeed syndicationFeed = SyndicationFeed.Load(xmlFeedReader);
            xmlFeedReader.Close();

            List <Episode> listOfEpisodes = new List<Episode>();

            foreach (SyndicationItem syndicationItem in syndicationFeed.Items)
            {
                Episode episode = new Episode(syndicationItem.Title.Text);

                listOfEpisodes.Add(episode);

            }

            var numberOfEpisodes = syndicationFeed.Items.Count();
            var name = syndicationFeed.Title.Text;
            

            Feed feed = new Feed(numberOfEpisodes, name, inFrequency, inCategory, listOfEpisodes);

            //Serialisera feed till json med serializer metoden

            string path = @"C:\Users\Henrik\source\repos\PodApplicationSamuel\Gui\Logic\test.json";

            serializer.Serialize(path, feed);

          

    

        }

        }
}
