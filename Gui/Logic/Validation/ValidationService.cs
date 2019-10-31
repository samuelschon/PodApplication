using Logic.Controllers;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.RegularExpressions;
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
        public static Boolean validateIfListViewHasSelectedItem(ListView list)
        {
            Boolean selected = true;
            if ((list.SelectedItems.Count) <= 0)
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
        public static Boolean checkIfSpecialLetters(string nameToCheck)
        {
            bool textConfirmation = true;
            if (!Regex.IsMatch(nameToCheck, @"^[a-zA-Z0-9_ ]+$")) 
                
            {
                
                textConfirmation = false;
                MessageBox.Show("Använd inte special tecken i kategori namnet. Exempelvis * , : / % @ ");
            }

            return textConfirmation;
        }

        public static Boolean checkLength(string lengthToCheck)
        {
            bool lengthConfirmation = true;
            if (lengthToCheck.Length >15 )
            {
                lengthConfirmation = false;
                MessageBox.Show("Namnet får inte vara längre än 10 bokstäver");
            }
            return lengthConfirmation;
        }
        

        







    }
}
