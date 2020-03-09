using System;
using TheBun.Models;

namespace TheBun.Services
{
    public class EnemyHeroManager
    {
        private HeroesCollection<EnemyHero> _heroes;

        private Random rnd;

        public EnemyHeroManager()
        {
            _heroes = new HeroesCollection<EnemyHero>();
            rnd = new Random();
        }

        public void AddHero(int numberOfHero)
        {
            _heroes.Collection.Add(new EnemyHero()
            {
                Id = NumberHeros(),
                Name = Enum.GetName(typeof(Name), numberOfHero),
                Buff = SetBuff(),
                Damage = SetDamage(),
                PositiveCharacter = SetPositiveCharacter()
            });
        }

        private int SetBuff()
        {
            return rnd.Next(10, 20);
        }

        private int SetDamage()
        {
            return rnd.Next(10, 30);
        }

        private bool SetPositiveCharacter()
        {
            return rnd.Next(100) < 40 ? true : false;
        }

        public void DeleteHero(int id)
        {
            _heroes.Collection.RemoveAt(id);
        }
        public void EditHero(EnemyHero enemyHero, int id)
        {
            _heroes.Collection[id] = enemyHero;
        }
        public EnemyHero GetHero(int id)
        {
            return _heroes.Collection[id];
        }

        public int NumberHeros()
        {
            return _heroes.Collection.Count;
        }

    }
}
