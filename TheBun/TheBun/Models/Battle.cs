using TheBun.Containers;

namespace TheBun.Models
{
    public class Battle
    {
        public MyContainer<EnemyHero> Opponents { get; set; }

        public Battle()
        {
            Opponents = new MyContainer<EnemyHero>();
        }
    }
}
