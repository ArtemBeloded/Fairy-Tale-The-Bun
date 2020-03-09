
namespace TheBun.Models
{
    public class EnemyHero : BaseHero
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Buff { get; set; }

        public int Damage { get; set; }

        public bool PositiveCharacter { get; set; }
    }
}
