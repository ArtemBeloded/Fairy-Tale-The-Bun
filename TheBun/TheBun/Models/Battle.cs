using TheBun.Containers;

namespace TheBun.Models
{
    public class Battle
    {
        public MyContainer<EnemyHero> opponents { get; set; }
        public Battle()
        {
            opponents = new MyContainer<EnemyHero>();
        }
    }
}
