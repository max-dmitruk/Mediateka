using System;
using MediaBase;

namespace Mediateka
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo("name","qw",23,23);
            Console.WriteLine(photo);
            Console.ReadKey();
        }
    }
}
