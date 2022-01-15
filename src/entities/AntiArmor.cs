using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoCOD.src.entities
{
    internal class AntiArmor : PresetClasses
    {
        //public AntiArmor(string Name, string Slot1, string Slot2, int life) : base(Name, Slot1, Slot2, life);
        public AntiArmor(string Name, string Slot1, string Slot2, int Life) : base(Name, Slot1, Slot2, Life)
        {
            this.Name = Name;
            this.Slot1 = Slot1;
            this.Slot2 = Slot2;
            this.Life = Life;
        }

        //public string name;
       // public string slot1;
        //public string slot2;
        //public int life;
    }
  

}



    
