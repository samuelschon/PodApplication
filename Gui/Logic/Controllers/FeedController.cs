using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using Data.Services;
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
            var numberOfEpisodes = EpisodeController.GetEpisodes(url).Count;
          
            Feed feed = new Feed(numberOfEpisodes, name, inFrequency, inCategory, EpisodeController.GetEpisodes(url), url);
           
            if (!ValidationService.checkIfFeedExist(GetAllFeeds(), url))
            {
                AddFeed(feed);
            }
            else
            {
                MessageBox.Show("There is already a feed with this Url.");
            }
            }

        }
        


        public List<Feed> GetAllFeeds()
        {
            return serializer.Deserialize();
        }

        public Feed GetSpecificFeed(string inFeedName) 
        {
           List<Feed> allFeeds = serializer.Deserialize();
            Feed returnFeed = null;
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
            List<Feed> currentFeed = serializer.Deserialize();
          
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
                    EpisodeController.GetEpisodes(feed.Url);
                    MessageBox.Show("Updated " + feed.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while checking for new Episodes " + ex);          
            }           
        }

        public void StartFeedTimer(Feed feed)
        {
            TimerService.StopTimer(feed);
            TimerService.StartTimer(feed);
        }

        public void AddFeed(Feed feed)
        {
           serializer.Serialize(feed);
        }
        public void DeleteFeed(string feedName) {
            List<Feed> currentFeed = GetAllFeeds();

            Feed feedToDelete = GetSpecificFeed(feedName);
            TimerService.StopTimer(feedToDelete);

            currentFeed.RemoveAll(x => x.Name == feedName);
           
            serializer.SerializeList(currentFeed);
        }
    }

}


