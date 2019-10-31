﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Data.Services;
using Logic;
using Logic.Timers;
using Logic.Validation;
using SharedModels.Models;

namespace Logic.Controllers
{
    public  class FeedController
    {
        private readonly SerializerService serializer = new SerializerService();

        public void createFeed(string url, string inFrequency, string inCategory)
        {

            SyndicationFeed syndicationFeed = RssReader.ReadRss(url);

            if (ValidationService.checkIfRssReturnAFeed(syndicationFeed))
            {

            
            var name = syndicationFeed.Title.Text;
            var numberOfEpisodes = getEpisodes(url).Count;
          
            Feed feed = new Feed(numberOfEpisodes, name, inFrequency, inCategory, getEpisodes(url), url);
           
            if (!ValidationService.checkIfFeedExist(GetAllFeeds(), url))
            {
                AddFeed(feed, Environment.CurrentDirectory + "\\test.json");
            }
            else
            {
                MessageBox.Show("There is already a feed with this Url.");
            }
            }

        }
        


        public List<Feed> GetAllFeeds()
        {
            return serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
        }

        public Feed GetSpecificFeed(string inFeedName) {

           List<Feed> allFeeds = serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
            Feed returnFeed = new Feed();
            foreach (Feed aFeed in allFeeds)
            {
                if (aFeed.Name == inFeedName)
                {
                    returnFeed = aFeed;
                }
            }
            return returnFeed;
        }
        public void UpdateSpecifikFeed(string url, string inFrequency, string inCategory, string nameOfFeed )
        {
            List<Feed> currentFeed = serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");
          
            foreach (Feed aFeed in currentFeed)
            {
                if (aFeed.Name == nameOfFeed)
                {
                    
                    DeleteFeed(nameOfFeed);
                    break;
                }
                


            }





            createFeed(url, inFrequency, inCategory);
            

        }

        public void checkIfThereAreNewEpisodes(Feed feed)
        {
          
            try
            {
                var inFeedName = feed.Name;
                int inFeedAmountOfEpisodes = feed.Episodes.Count;


                Feed existingFeed = GetSpecificFeed(inFeedName);
                int existingFeedAmountOfEpisodes = existingFeed.Episodes.Count;

                if (existingFeedAmountOfEpisodes > inFeedAmountOfEpisodes)
                {
                    getEpisodes(feed.Url);
                    MessageBox.Show("Updated " + feed.Name);

                }

            }
            catch (Exception ex)
            {

                
            }
           

           


        }


        //Ska brytas ut till episodecontroller.
            public static List<Episode> getEpisodes(string url)
        {
            List<Episode> allEpisodes = new List<Episode>();
            SyndicationFeed feed = RssReader.ReadRss(url);


            //Ska brytas ut till episodecontroller.
            foreach (SyndicationItem oneEpisode in feed.Items.ToList())
            {
                Episode episode = new Episode(oneEpisode.Title.Text, oneEpisode.Summary.Text, oneEpisode.PublishDate.DateTime.ToString());
               

                allEpisodes.Add(episode);

            }

            return allEpisodes;

        }

        public void StartFeedTimer(Feed feed)
        {
            TimerService.StopTimer(feed);
            TimerService.StartTimer(feed);

        }


        public void AddFeed(Feed feed, string path)
        {
           serializer.Serialize(path, feed);
        }
        public void DeleteFeed(string feedName) {

            List<Feed> currentFeed = serializer.Deserialize(Environment.CurrentDirectory + "\\test.json");

            Feed feedToDelete = GetSpecificFeed(feedName);
            TimerService.StopTimer(feedToDelete);

            currentFeed.RemoveAll(x => x.Name == feedName);
           

            serializer.SerializeList(Environment.CurrentDirectory + "\\test.json",currentFeed);

        }
    }
  

}


