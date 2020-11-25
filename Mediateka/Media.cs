using System;

namespace MediaBase
{
    public abstract class Media
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public int SizeFile { get; set; }

        
        public Media(string name,string format,int sizefile)
        {
            Name = name;
            Format = format;
            SizeFile = sizefile;
        }

        public abstract void Play();
        public abstract void Add();
        public abstract void Delete(string name);
        public abstract string Search(string name);

    }
}
