﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Azog : Unit
    {
        private Weapon weapon;

        internal Weapon Weapon { get => weapon; set => weapon = value; }
    }

}
