using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.Models
{
    public class Feed
    {
        public int NumberOfEpisodes { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
        public List<Episode> Episodes { get; set; }



        public Feed()
        {

            Name = "körven";
            Frequency = "111";
            Category = "1212";


        }

        public Feed(int numberOfEpisodes, string name, string frequency, string category, List<Episode> episodes, string url)
        {

            NumberOfEpisodes = numberOfEpisodes;
            Name = name;
            Frequency = frequency;
            Category = category;
            Episodes = episodes;
            Url = url;

        }
       



    }
}
