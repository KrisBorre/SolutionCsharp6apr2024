using static System.Console;

namespace LibraryChapter6_8apr2024
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD player is pausing.");
        }

        public void Play()
        {
            WriteLine("DVD player is playing.");
        }
    }
}
