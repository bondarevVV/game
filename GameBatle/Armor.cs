namespace GameBatle
{
    /// <summary>
    /// Абстрактный класс Броня
    /// </summary>
    internal abstract class Armor : Loot
    {
        private string name;
        private string material;
        private int durability;

        public string Name { get => name; set => name = value; }
        public string Material { get => material; set => material = value; }
        public int Durability { get => durability; set => durability = value; }

        public Loot Use()
        {
            return this;
        }
    }
}