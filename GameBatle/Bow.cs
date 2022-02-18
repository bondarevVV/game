using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Bow : Weapon
    {
        private String material;

        public string Material { get => material; set => material = value; }
    }
}
