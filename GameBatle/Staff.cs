using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Staff : Weapon
    {
        private String ability;

        public string Ability { get => ability; set => ability = value; }
    }
}
