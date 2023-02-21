using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingInWPF
{
    public class VideoGame
    {
        public string GameName { get; set; }

        public string DeveloperName { get; set; }

        public string ShortDesc { get; set; }

        public DateTime ReleaseDate { get; set; }

        public VideoGame()
        {
            GameName = "Starcraft";
            DeveloperName = "Blizzard";
            ShortDesc = "An all-time great RTS";
            ReleaseDate = new DateTime(1998, 3, 31);
        }

        public string Summary
        {
            get
            {
                return $"{GameName} by {DeveloperName}, released: {ReleaseDate.ToString("M")}";
            }
        }
    }
}
