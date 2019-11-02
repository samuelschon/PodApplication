using Logic.Validation;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Controllers
{
    public static class EpisodeController
    {

        public static List<Episode> GetEpisodes(string url)
        {
            List<Episode> allEpisodes = new List<Episode>();
            SyndicationFeed feed = RssReader.ReadRss(url);

            if (ValidationService.checkIfRssReturnAFeed(feed))
            {
                foreach (SyndicationItem oneEpisode in feed.Items.ToList())
                {
                    Episode episode = new Episode(oneEpisode.Title.Text, oneEpisode.Summary.Text, oneEpisode.PublishDate.DateTime.ToString());

                    allEpisodes.Add(episode);
                }
            }
            return allEpisodes;
        }


    }
}
