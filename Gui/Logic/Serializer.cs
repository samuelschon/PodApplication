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

            Feed feed = new Feed();

           XmlSerializer writer = new XmlSerializer(typeof(Feed));

            var path = Environment.CurrentDirectory + "\\dataxml.xml"; //Hamnar i PodApplication\Gui\Gui\Bin\Debug

            if (!File.Exists(path))
            {

                using (FileStream file = File.Create(path))

                    writer.Serialize(file, feed);
            }

            else {

                using (FileStream file = new FileStream(path, FileMode.Append))

                    writer.Serialize(file, feed);
            
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
