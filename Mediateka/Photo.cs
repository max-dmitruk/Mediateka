using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    
    class Photo:Media
    {
        private string formatPhoto;
        public string FormatPhoto
        {
            get 
            {
                return formatPhoto;
            }
            set
            {
                    formatPhoto = value;
            }
        }
        public Photo() { }

        public Photo(string namePhoto, string formatPhoto) : base(namePhoto)
        {
            FormatPhoto = formatPhoto;
        }
        public override void Play(string name)
        {
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
