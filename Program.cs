using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoCOD.src.entities
{
    public class Program
    {
        static void Main(string[] args)
        {

            AntiArmor armor = new AntiArmor("Anti Tanque", "RPG", "Minas Terrestres", 50);
            Rifleman rifleman = new Rifleman("Sniper", "M40A3", "Pistola", 28);
            Medic medic = new Medic("Medico", "Kit Medico", "Bereta", 70);
            Support support = new Support("Apoio", "Kit de Minição", "M60", 22);


            Console.WriteLine(armor.Action());
            Console.WriteLine(rifleman.Action());
            Console.WriteLine(medic.Action());
            Console.WriteLine(support.Action());

            Console.WriteLine();
            Console.ReadLine();


        }

    }
}

