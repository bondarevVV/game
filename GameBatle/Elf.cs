using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Elf : Unit
    {
        private Weapon weapon1;
        private Weapon weapon2;
        private Armor armor;

        internal Weapon Weapon1 { get => weapon1; set => weapon1 = value; }
        internal Weapon Weapon2 { get => weapon2; set => weapon2 = value; }
        internal Armor Armor { get => armor; set => armor = value; }
    }

    internal class Bow : Weapon
    {
        private String material;

        public string Material { get => material; set => material = value; }
    }

    internal class Dagger : Weapon
    {
        private String ability;
        private int number;

        public string Ability { get => ability; set => ability = value; }
        public int Number { get => number; set => number = value; }
    }

    internal class Mantle : Armor
    {
        private String ability;

        public string Ability { get => ability; set => ability = value; }
    }
}
