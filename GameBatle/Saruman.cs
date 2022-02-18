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
}
