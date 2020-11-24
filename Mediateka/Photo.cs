using System;

namespace MediaBase
{
    public class Photo : Media
    {
        private int resolution;
        public int Resolution 
        {
            get
            {
                return resolution;
            }
            set
            {
                resolution = value;
            }
        }

        public override void Play()
        {
            Console.WriteLine("Играет картинка");
        }
        public override void Add() {}
        public override void Delete(string name) {}
        public override string Search(string name)
        {
            return name;
        }
    }
}
