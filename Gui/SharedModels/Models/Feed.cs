using SharedModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace SharedModels.Models
{
    public class Feed : IBaseClass
    {
        public int NumberOfEpisodes { get; set; }
       
        public override string Name { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
        public List<Episode> Episodes { get; set; }
       
        public Timer updateTimer { get; set; }

        public double Minutes { get; set; }



        public Feed()
        {

            Name = "körven";
            Frequency = "111";
            Category = "1212";


        }

        public Feed(int numberOfEpisodes, string name, string frequency, string category, List<Episode> episodes, string url)
        {
            updateTimer = new Timer();
            NumberOfEpisodes = numberOfEpisodes;
            Name = name;
            Frequency = frequency;
            Category = category;
            Episodes = episodes;
            Url = url;

            switch (frequency)
            {
                case "Var 1:a minut":
                    Minutes = 1;
                    break;
                case "Var 5:e minut":
                    Minutes = 5;
                    break;
                case "Var 10:e minut":
                    Minutes = 10;
                    break;
                case "Var 15:e minut":
                    Minutes = 15;
                    break;
                case "Var 20:e minut":
                    Minutes = 20;
                    break;
                default:
                    Minutes = 10;
                    break;
            }


        }
       



    }
}
