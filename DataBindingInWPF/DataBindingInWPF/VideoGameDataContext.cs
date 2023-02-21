using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingInWPF
{
    public class VideoGameDataContext
    {
        //private VideoGame aGame = new VideoGame();

        //public VideoGame AGame { get { return aGame; } }

        private ObservableCollection<VideoGame> games = new ObservableCollection<VideoGame>();
        public ObservableCollection<VideoGame> Games { get { return games; } }

        public VideoGameDataContext()
        {
            games.Add(new VideoGame() { GameName="Quake II", DeveloperName="id Software", ShortDesc="An awesome early FPS!", ReleaseDate=new DateTime(1997, 12, 9) });
            games.Add(new VideoGame() { GameName = "PacMan", DeveloperName = "Atari", ShortDesc = "An awesome early FPS!", ReleaseDate = new DateTime(1997, 12, 9) });
            games.Add(new VideoGame() { GameName = "Space Invaders", DeveloperName = "Atari", ShortDesc = "An awesome early FPS!", ReleaseDate = new DateTime(1997, 12, 9) });
        }
    }
}
