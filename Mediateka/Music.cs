using System;

namespace MediaBase
{
    public class Music : Media
    {
        private string genre;
        public string Genre 
        {
            get 
            {
                return genre;
            } 
            set
            {
                genre = value;
            }
        }
        public override void Play()
        {
            Console.WriteLine("Играет трек");
        }
        public override void Add() {}
        public override void Delete(string name) {}
        public override string Search(string name)
        {
            return name;
        }
    }

}
