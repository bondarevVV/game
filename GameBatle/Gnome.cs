using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Gnome : Unit
    {
        private Weapon weapon;
        private Armor armor1;
        private Armor armor2;

        internal Weapon Weapon { get => weapon; set => weapon = value; }
        internal Armor Armor1 { get => armor1; set => armor1 = value; }
        internal Armor Armor2 { get => armor2; set => armor2 = value; }
    }
}
