using System;

namespace MediaBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Music music = new Music();
            music.Play();
            Mediateka.PlayList playlist = new Mediateka.PlayList();
            playlist.Play(music);
            Console.ReadKey();

        }
    }
}
