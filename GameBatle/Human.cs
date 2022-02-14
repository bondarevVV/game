﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Human:Unit
    {
        private Weapon weapon1;
        private Weapon weapon2;
        private Armor armor;

        internal Weapon Weapon1 { get => weapon1; set => weapon1 = value; }
        internal Weapon Weapon2 { get => weapon2; set => weapon2 = value; }
        internal Armor Armor { get => armor; set => armor = value; }
    }

    internal class Sword : Weapon
    {
        private String material;

        public string Material { get => material; set => material = value; }
    }

    internal class ChainArmor : Armor
    {
        private String create;

        public string Create { get => create; set => create = value; }
    }

}
