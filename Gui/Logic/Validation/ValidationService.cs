using Logic.Controllers;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Validation
{
    public static class ValidationService
    {
       
        public static Boolean validateComboBox(ComboBox box)
        {
            Boolean selected = true;
            if (string.IsNullOrEmpty(box.Text))
            {
                selected = false;
                MessageBox.Show("Du måste välja ett värde i listan.");
                
            }

          
            return selected;
        }
        public static Boolean checkIfFeedExist(List<Feed> allFeeds, string url)
        {
            Boolean exist = false;
            
            foreach (Feed oneFeed in allFeeds)
            {
                if (oneFeed.Url == url)
                {
                    exist = true;
                    break;
                }
            }


            return exist;
        }
        public static Boolean checkIfRssReturnAFeed(SyndicationFeed feed)
        {
            var exist = true;
            if (feed.Title == null)
            {
                exist = false;
                MessageBox.Show("Något är fel med RSS-Länken.");
            }



            return exist;
        }








    }
}
