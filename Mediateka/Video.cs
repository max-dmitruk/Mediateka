using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    class Video : Media
    {
        private string formatVideo;

        public string FormatVideo
        {
            get
            {
                return formatVideo;
            }
            set
            {
                formatVideo = value;
            }
        }

        public Video() { }

        public Video(string name, int duration, string formatVideo) : base(name, duration)
        {
            this.formatVideo = formatVideo;
        }

        public override void Play(string name)
        {
            Console.WriteLine("Вы смотрите видео: {0}", name);
            base.Play(name);

        }
        public override void Add()
        {
            base.Add();
        }

        public override void Delete()
        {
            base.Delete();
        }
        public override void Search()
        {
            base.Search();
        }
        
    }
}
