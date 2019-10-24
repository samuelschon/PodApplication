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

  

   
        public int AmountOfParts { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }
        public List<Episode> episodes  { get; set; }



        public Feed()
        {

            Name = "körven";
            Frequency = "111";
            Category = "1212";


        }

        public Feed(string inName, string inFrequency, string inCategory , List<Episode>inList)
        {

            Name = inName;
            Frequency = inFrequency;
            Category = inCategory;
            episodes = inList;


        }
        


    }



    }

