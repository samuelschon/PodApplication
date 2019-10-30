using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using SharedModels.Models;

namespace Logic.Timers
{
    public static class TimerService
    {
        
        public static void StartTimer(Feed feed)
        {

            double minutes = feed.Minutes;
            Timer updateTimer = new Timer();
            updateTimer.Elapsed += TimerElapsedHandler;
            updateTimer.Interval = 1000 * 60 * (minutes*5);
            updateTimer.Enabled = true;
            updateTimer.AutoReset = true;

        }

        public static void TimerElapsedHandler(object sender, ElapsedEventArgs e)
        {
            
            System.Windows.Forms.MessageBox.Show("Nu fungerar detta..");
        }


    }
    
}
