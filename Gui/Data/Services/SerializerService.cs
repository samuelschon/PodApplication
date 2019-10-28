using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Data.Services
{
    public class SerializerService
    {

        public void Serialize<T>(string path, T inObject)
        {

            var serializer = CreateSerializer();
         


            using (var sw = new StreamWriter(path))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    serializer.Serialize(jw, inObject);

                }
            }
        }

        public static void Deserialize() {
        
        
        
        }

        private JsonSerializer CreateSerializer()
        {
            return new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.All
            };
        }



    }
}
