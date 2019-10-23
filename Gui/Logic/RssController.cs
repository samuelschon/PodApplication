using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logic
{
    public class RssController
    {
        public static List<SyndicationItem> getRssFileByUrl(string url)
        {
            List<string> listOfInfo = new List<string>();
            XmlReader reader = XmlReader.Create(url);


            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

          

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<xml><aaa>Lasse Stefanz</aaa></xml>");


            doc.Save("Skrivbord3.xml");



            foreach (SyndicationItem oneItem in feed.Items)
            {

                listOfInfo.Add(oneItem.Title.Text);
                listOfInfo.Add(oneItem.LastUpdatedTime.ToString());
                listOfInfo.Add(oneItem.Summary.Text);
            }

            return feed.Items.ToList();



        }


    }
}
