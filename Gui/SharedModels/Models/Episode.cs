using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.Models
{
    public class Episode
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string PublishedDate { get; set; }

        public Episode(string name, string summary, string publishedDate) {

            Name = name;
            Summary = summary;
            PublishedDate = publishedDate;
        }
    }
}
