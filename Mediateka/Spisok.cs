using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    class Spisok:Media
    {
        private string spisokName;
        public string SpisokName 
        {
            get
            {
                return spisokName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Ошибка!!! Слишком длинное название");
                }
                else
                {
                    spisokName = value;
                }
            }
        }

        private int lenghtSpisok;
        public int LenghtSpisok
        {
            get
            {
                return lenghtSpisok;
            }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Ошибка!!! Больше 100 медиафайлов");
                }
                else
                {
                    lenghtSpisok = value;
                }
            }
        }
        public Spisok() { }

        public Spisok(string spisokName, int lenghtSpisok) : base(spisokName, lenghtSpisok)
        {
            SpisokName = spisokName;
            LenghtSpisok = lenghtSpisok;
        }
        public override void Play(string name)
        {
            Console.WriteLine("Вы воспроизводите плейлист под названием: {0}",SpisokName);
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
