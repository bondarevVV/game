using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Dagger : Weapon
    {
        private String ability;
        private int number;

        public string Ability { get => ability; set => ability = value; }
        public int Number { get => number; set => number = value; }
    }
}
