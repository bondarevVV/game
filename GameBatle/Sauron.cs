using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Sauron : Unit
    {
        private Weapon weapon1;
        private Weapon weapon2;
        private Armor armor;

        internal Weapon Weapon1 { get => weapon1; set => weapon1 = value; }
        internal Weapon Weapon2 { get => weapon2; set => weapon2 = value; }
        internal Armor Armor { get => armor; set => armor = value; }
    }

    internal class Ring : Weapon
    {
        private String ability;
        private String hand;

        public string Ability { get => ability; set => ability = value; }
        public string Hand { get => hand; set => hand = value; }
    }

    internal class Mace2 : Weapon
    {
        private String hand;

        public string Hand { get => hand; set => hand = value; }
    }

    internal class ArmorOfGod : Armor
    {
        private string rarity;

        public string Rarity { get => rarity; set => rarity = value; }
    }
}
