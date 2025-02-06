using Facade.Ex.SubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Ex.FacadeClass
{
    public class HomeTheaterFacade
    {
        private readonly DVDPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Projector projector, SoundSystem soundSystem)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _soundSystem = soundSystem;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Setting up the home theater system to watch a movie...");

            _projector.TurnOn();
            _projector.SetInput("DVD Player");

            _soundSystem.TurnOn();
            _soundSystem.SetVolume(10);

            _dvdPlayer.TurnOn();
            _dvdPlayer.PlayMovie(movie);

            Console.WriteLine("Enjoy your movie!");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater system...");

            _dvdPlayer.TurnOff();
            _projector.TurnOff();
            _soundSystem.TurnOff();

            Console.WriteLine("Goodbye!");
        }
    }
}
