using SharedModels.Interfaces;
using System.Collections.Generic;
using System.Timers;

namespace SharedModels.Models
{
    public class Feed : IBaseClass
    {
        public override string Name { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
           
        public int NumberOfEpisodes { get; set; }
        public double Minutes { get; set; }
        public List<Episode> Episodes { get; set; }
        public Timer updateTimer { get; set; }



        public Feed(int numberOfEpisodes, string name, string frequency, string category, List<Episode> episodes, string url)
        {
            updateTimer = new Timer();
            NumberOfEpisodes = numberOfEpisodes;
            Name = name;
            Frequency = frequency;
            Category = category;
            Episodes = episodes;
            Url = url;
            Minutes = getFrequencyMinutes(frequency);
       }

        private int getFrequencyMinutes(string inFrequency)
        {
            int minutes;
            switch (inFrequency)
            {
                case "Var 1:a minut":
                    minutes = 1;
                    break;
                case "Var 5:e minut":
                    minutes = 5;
                    break;
                case "Var 10:e minut":
                    minutes = 10;
                    break;
                case "Var 15:e minut":
                    minutes = 15;
                    break;
                case "Var 20:e minut":
                    minutes = 20;
                    break;
                default:
                    minutes = 10;
                    break;
            }
            return minutes;
        }
    }
}
