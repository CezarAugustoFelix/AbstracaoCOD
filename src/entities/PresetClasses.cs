using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoCOD.src.entities
{
    

    public class PresetClasses
    {
        public PresetClasses(string Name, string Slot1, string Slot2 ,int Life)
            {
            this.Name = Name;
            this.Slot1 = Slot1;
            this.Slot2 = Slot2;
            this.Life = Life;
            }

        public string Name;
        public string Slot1;
        public string Slot2;
        public int Life;

        public override string ToString()
        { 
            return this.Name + " ";

        }

        public virtual string Action()

        {
            if (Life < 25)
            {
                return this.Name + " está com " + Life + " de Vida, precisa de um kit medico Urgente" ;
            }
            else
            {
                return this.Name + " utilizou " + Slot1 + " e " + Slot2 + " e segue o jogo";
            }
        }

        


    }

}

