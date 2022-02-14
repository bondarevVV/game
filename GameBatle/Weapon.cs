namespace GameBatle
{

    /// <summary>
    /// Абстрактный класс Оружие
    /// </summary>
    internal abstract class Weapon : Loot
    {
        private string name;
        private int damage;
        private int durability;

        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Durability { get => durability; set => durability = value; }

        public Loot Use()
        {
            return this;
        }
    }
}