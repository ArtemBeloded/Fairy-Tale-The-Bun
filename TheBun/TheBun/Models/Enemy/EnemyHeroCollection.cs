using TheBun.Containers;

namespace TheBun.Models.Enemy
{
    public class EnemyHeroCollection
    {
        public MyContainer<EnemyHero> enemyCollection { get; set; }

        public EnemyHeroCollection()
        {
            enemyCollection = new MyContainer<EnemyHero>();
        }
    }
}
