using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new Sword();
            sword.Name = "Iron sword";
            sword.Damage = 70;
            sword.Durability = 100;
            sword.Material = "Metal";

            Sword sword2 = new Sword();
            sword2.Name = "Silver sword";
            sword2.Damage = 100;
            sword2.Durability = 200;
            sword2.Material = "Silver";

            ChainArmor chainarmor = new ChainArmor();
            chainarmor.Name = "Chain Armor";
            chainarmor.Material = "Steel";
            chainarmor.Durability = 100;
            chainarmor.Create = "Gondor";

            Human human = new Human();
            human.Name = "Aragorn";
            human.Health = 500;
            human.Loot = new Loot[5];
            human.Weapon1 = sword;
            human.Weapon2 = sword2;
            human.Armor = chainarmor;


            Dagger dagger = new Dagger();
            dagger.Name = "Elf dagger";
            dagger.Damage = 25;
            dagger.Durability = 100;
            dagger.Ability = "Throw";
            dagger.Number = 10;

            Bow bow = new Bow();
            bow.Name = "Elven Bow";
            bow.Damage = 100;
            bow.Durability = 200;
            bow.Material = "Elven Tree";

            Mantle mantle = new Mantle();
            mantle.Name = "Mantle";
            mantle.Material = "Enchanted Silk";
            mantle.Durability = 100;
            mantle.Ability = "Invisibility";

            Elf elf = new Elf();
            elf.Name = "Legolas";
            elf.Health = 750;
            elf.Loot = new Loot[3];
            elf.Weapon1 = bow;
            elf.Weapon2 = dagger;
            elf.Armor = mantle;


            Hammer hammer = new Hammer();
            hammer.Name = "Hammer";
            hammer.Damage = 100;
            hammer.Durability = 300;
            hammer.Create = "Moria";

            Healmet healmet = new Healmet();
            healmet.Name = "Healmet";
            healmet.Material = "Niflheim";
            healmet.Durability = 100;
            healmet.Create = "Moria";

            Shield shield = new Shield();
            shield.Name = "Ghome Shield";
            shield.Material = "Niflheim";
            shield.Durability = 100;
            shield.Ability = "Push";

            Gnome gnome = new Gnome();
            gnome.Name = "Gimmli";
            gnome.Health = 800;
            gnome.Loot = new Loot[3];
            gnome.Weapon = hammer;
            gnome.Armor1 = healmet;
            gnome.Armor2 = shield;




            Mace mace = new Mace();
            mace.Name = "Mace";
            mace.Damage = 80;
            mace.Durability = 100;
            mace.Hand = "Right hand";

            Azog azog = new Azog();
            azog.Name = "Azog";
            azog.Health = 1200;
            azog.Loot = new Loot[3];
            azog.Weapon = mace;

            Staff staff = new Staff();
            staff.Name = "Magic staff";
            staff.Damage = 60;
            staff.Durability = 100;
            staff.Ability = "Magic";

            Ability ability = new Ability();
            ability.Name = "Magic";
            ability.Damage = 250;
            
            Saruman saruman = new Saruman();
            saruman.Name = "Saruman";
            saruman.Health = 1500;
            saruman.Loot = new Loot[5];
            saruman.Weapon = staff;
            saruman.Magic = ability;

            Ring ring = new Ring();
            ring.Name = "Ring of Omnipotence";
            ring.Damage = 250;
            ring.Durability = 1000;
            ring.Ability = "Magic";
            ring.Hand = "Left Hand";

            Mace2 mace2 = new Mace2();
            mace2.Name = "Dragon Mace";
            mace2.Damage = 120;
            mace2.Durability = 500;
            mace2.Hand = "Right Hand";

            Sauron sauron = new Sauron();
            sauron.Name = "Sauron";
            sauron.Health = 2000;
            sauron.Loot = new Loot[1];
            sauron.Weapon1 = ring;
            sauron.Weapon2 = mace2;
        }
    }
}
