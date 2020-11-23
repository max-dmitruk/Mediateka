using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    abstract class Media
    {
        private string name;
        private int duration;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 25)
                {
                    Console.WriteLine("Ошибка!!! Слишком длинное название");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value > 10)
                {
                    Console.WriteLine("Ошибка!!! Слишком длительный файл");
                }
                else
                {
                    duration = value;
                }
            }
        }

        public Media() { }

        public Media(string name)
        {
            this.name = name;

        }

        public Media(string name, int duration) : this(name)
        {
            this.duration = duration;
        }

        public virtual void Play(string name)
        {
        }
        public virtual void Add()
        {
        }
        public virtual void Delete()
        { 
        }
        public virtual void Search()
        { 
        }

    }
}
