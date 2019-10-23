using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
   public class Feed 

    {

        public SyndicationFeed feed;

        public List<Episode> episodes;
        public int AmountOfParts { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }
       




        public Feed(SyndicationFeed inFeed, string inFrequency, string inCategory)
        {

            feed = inFeed;
            Frequency = inFrequency;
            Category = inCategory;


        }

    }



    }

