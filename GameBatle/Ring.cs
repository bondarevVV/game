using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Ring : Weapon
    {
        private String ability;
        private String hand;

        public string Ability { get => ability; set => ability = value; }
        public string Hand { get => hand; set => hand = value; }
    }
}
