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

        private static string path = Environment.CurrentDirectory + "\\dataxml.xml"; //Hamnar i PodApplication\Gui\Gui\Bin\Debug

        public static void Serialize(Feed feed)
        {

            

           XmlSerializer writer = new XmlSerializer(typeof(Feed));

           

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

        public static Feed Deserialize() { 

           
            Feed feed;
           
            StreamReader xmlStreamReader = new StreamReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof(Feed));

            feed = (Feed) serializer.Deserialize(xmlStreamReader);
            xmlStreamReader.Close();

            return feed;
        
        }

    }
}
