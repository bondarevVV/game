using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Ability
    {
        private int damage;
        private string name;

        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }
    }
}
