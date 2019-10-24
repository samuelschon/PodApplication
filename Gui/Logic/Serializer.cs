using Data;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Logic
{
    public class Serializer
    {

        public static void Serialize()
        {


            XmlSerializer xsSubmit = new XmlSerializer(typeof(Feed));
            var subReq = new Feed();
            var xml = "Doc.xml";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, subReq);
                    xml = sww.ToString(); // Your XML
                }
            }



        }

        public static string Deserialize() { //Deserialiserar objektet i XML filen, returnerar värdet på dess "Name" property

            //Har bara testat på ett objekt

            Podcast podcast;
            //Filutpekningen nedan måste såklart ändras
            StreamReader xmlStreamReader = new StreamReader(@"C:\Users\Henrik\source\repos\PodApplication\Gui\Testmapp\dokument.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Podcast));

            podcast = (Podcast) serializer.Deserialize(xmlStreamReader);

            string name = podcast.Name;
            return name;
        
        }

    }
}
