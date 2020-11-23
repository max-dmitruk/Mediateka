using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("видео 1", 15,"15");
            video.Play(video.Name);

            
            Music music = new Music("песня 1", 5,"mp3","Rock");
            music.Play(music.Name);
           

            Spisok spisok = new Spisok("Плейлист1", 50);
            Console.WriteLine(spisok.SpisokName);
            Console.WriteLine(spisok.LenghtSpisok);
            spisok.Play(spisok.SpisokName);

            Photo photo = new Photo("Фото 1","JPEG");
            Console.WriteLine(photo.Name);
            Console.WriteLine(photo.FormatPhoto);
           
            Console.ReadLine();

        }
    }
}
