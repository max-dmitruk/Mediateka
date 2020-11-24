using System;
using System.Collections.Generic;
using MediaBase;

namespace Mediateka
{
    public class PlayList
    {
        List<Media> MediaList = new List<Media> ();

        public void Add(Media file)
        {
            MediaList.Add(file);
        }

        public string Search(string name)
        {
            return name;
        }

        public void Delete(Media file)
        {
            MediaList.Remove(file);
        }
        public void PlayMediaList (Media file)
        {
            foreach (var i in MediaList)
            {
                i.Play();
            }
        }
    }
}