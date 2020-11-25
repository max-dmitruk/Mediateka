using System;

namespace MediaBase
{
    public class Video : Media
    {

        private string fps;
        public string FPS
        {
            get
            {
                return fps;
            }
            set
            {
                fps = value;
            }
        }

        public override void Play() {}
        public override void Add() {}
        public override void Delete(string name) {}
        public override string Search(string name)
        {
            return name;
        }
    }
}
