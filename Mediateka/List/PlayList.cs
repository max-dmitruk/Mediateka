using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    public class PlayList
    {
        List<MediaBase.Media> playlist = new List<MediaBase.Media> ();

        public void Add(MediaBase.Media file)
        {
            playlist.Add(file);
        }

        public string Search(string name)
        {
            return name;
        }

        public void Delete(MediaBase.Media file)
        {
            playlist.Remove(file);
        }
        public void Play(MediaBase.Media file)
        {
            foreach (var i in playlist)
            {
                i.Play(file);
            }
        }
    }
}