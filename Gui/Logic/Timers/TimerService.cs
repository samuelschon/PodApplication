using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using Data.Services;
using Logic.Controllers;
using SharedModels.Models;

namespace Logic.Timers
{
    public static class TimerService
    {
        
        public static void StartTimer(Feed feed)
        {          
            
            Timer updateTimer = new Timer();
            double minutes = feed.Minutes;

            updateTimer.Elapsed += (sender, e) => TimerElapsedHandler(feed);
            updateTimer.Interval = 1000 * 60 * minutes;
            updateTimer.Enabled = true;
            updateTimer.AutoReset = true;

            feed.UpdateTimer = updateTimer;

        }

   
        public static void TimerElapsedHandler(Feed feed)
        {
            Debug.WriteLine("Hej");
            SerializerService serializer = new SerializerService();

            List<Episode> episodeList = EpisodeController.GetEpisodes(feed.Url);

            feed.Episodes = episodeList;
 
            serializer.Serialize(feed);
              
        }
    }  
}
