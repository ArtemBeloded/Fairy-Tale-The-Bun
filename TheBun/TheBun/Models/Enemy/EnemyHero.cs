
namespace TheBun.Models
{
    public class EnemyHero : BaseHero
    {
        public int id { get; set; }
        public string name { get; set; }
        public int buff { get; set; }
        public int damage { get; set; }
        public bool positiveCharacter { get; set; }
    }
}
