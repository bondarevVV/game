using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Saruman : Unit
    {
        private Weapon weapon;
        private Ability magic;

        internal Weapon Weapon { get => weapon; set => weapon = value; }
        internal Ability Magic { get => magic; set => magic = value; }
    }

    internal class Ability
    {
        private int damage;
        private string name;

        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }
    }

    internal class Staff : Weapon
    {
        private String ability;

        public string Ability { get => ability; set => ability = value; }
    }
}
