using Data;
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
            Podcast podcast = new Podcast("EttNAMN", 123);

            XmlSerializer writer = new XmlSerializer(typeof(Podcast));

            var path = @"C:\Users\Henrik\source\repos\PodApplication\Gui\Testmapp\dokument.xml";
                FileStream file = File.Create(path);

                writer.Serialize(file, podcast);
                file.Close();
         

        }

    }
}
