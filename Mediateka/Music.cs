using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    class Music : Media
    {
        private string formatMusic;
        private string genreOfMusic;

        public string FormatMusic
        {
            get 
            {
                return formatMusic;
            }
            set 
            {
                formatMusic = value;
            }
        }

        public string  GenreOfMusic
        {
            get
            {
                return genreOfMusic;
            }
            set
            {
                genreOfMusic = value;
            }
        }

        public Music() { }

        public Music(string nameMusic, int durationMusic, string formatMusic, string genreOfMusic) : base(nameMusic,durationMusic)

        {
            this.formatMusic = formatMusic;
            this.genreOfMusic = genreOfMusic;
        }

        public override void Play(string name)
        {
            Console.WriteLine("Вы слушаете песню: {0}", name);
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
