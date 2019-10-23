using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Podcast
    {

        public string Name { get; set; }
        public int AntalTimmar { get; set; }

        public Podcast() {

            Name = "Namnet";
            AntalTimmar = 4;
        
        }

        public Podcast(string namn, int antalTimmar)
        {

            Name = namn;
            AntalTimmar = antalTimmar;

        }

    }
}
