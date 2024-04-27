using static System.Console;

namespace LibraryChapter6_8apr2024
{
    public interface IPlayable
    {
        void Play();

        void Pause();

        void Stop() // default interface implementation
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}
