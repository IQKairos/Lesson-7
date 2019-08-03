using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

        abstract public class Животные
        {
            abstract public string eat();
        }
         class Хищники: Животные
        {
            string animalTYpe;
            public Хищники (string animalTYpe)
            {
                this.animalTYpe = animalTYpe;
            }
            public override string eat()
            {
                return "мясо";
            }
        }
        class ТравояднЫе : Животные
        {
            string animalTYpe;
            public ТравояднЫе(string animalTYpe)
            {
                this.animalTYpe = animalTYpe;
            }
            public override string eat()
            {
                return "трава";
            }
        }
        class Волк : Хищники
        {
            public Волк (string animalTYpe) :base(animalTYpe) { }
        }
        class Лиса : Хищники
        {
            public Лиса(string animalTYpe) : base(animalTYpe) { }
        }
        class Заяц : ТравояднЫе
        {
            public Заяц(string animalTYpe) : base(animalTYpe) { }
        }
        class Олень : ТравояднЫе
        {
            public Олень(string animalTYpe) : base(animalTYpe) { }
        }


    
}
