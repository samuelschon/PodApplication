﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using Logic.Controllers;
using SharedModels.Models;

namespace Logic.Timers
{
    public static class TimerService
    {
        
        public static void StartTimer(Feed feed)
        {          
            Timer updateTimer = feed.updateTimer;
            updateTimer.Stop();
            updateTimer.Start();
            double minutes = feed.Minutes;

            updateTimer.Elapsed += (sender, e) => TimerElapsedHandler(sender, e, feed);
            updateTimer.Interval = 1000 * 60 * minutes;
            updateTimer.Enabled = true;
            updateTimer.AutoReset = true;
        }

        public static void StopTimer(Feed feed)
        {        
            Timer updateTimer = feed.updateTimer;          

            updateTimer.Stop();
        }
   
        public static void TimerElapsedHandler(object sender, ElapsedEventArgs e, Feed feed)
        {
            FeedController controller = new FeedController();
            

            if (controller.GetAllFeeds().Where(c=>c.Name == feed.Name).Count() > 0)
            {
                controller.checkIfThereAreNewEpisodes(feed);
                
            }
            else
            {
                StopTimer(feed);

              
            }               
        }
    }  
}
