using System;
using TheBun.Models;
using TheBun.Models.Enemy;

namespace TheBun.Services
{
    public class EnemyHeroManager
    {
        private EnemyHeroCollection _heroes;
        private Random rnd;
        public EnemyHeroManager()
        {
            _heroes = new EnemyHeroCollection();
            rnd = new Random();
        }


        public void AddHero(int numberOfHero)
        {
            _heroes.enemyCollection.Add(new EnemyHero()
            {
                id = NumberHeros(),
                name = Enum.GetName(typeof(Name), numberOfHero),
                buff = SetBuff(),
                damage = SetDamage(),
                positiveCharacter = SetPositiveCharacter()
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
            _heroes.enemyCollection.RemoveAt(id);
        }
        public void EditHero(EnemyHero enemyHero, int id)
        {
            _heroes.enemyCollection[id] = enemyHero;
        }
        public EnemyHero GetHero(int id)
        {
            return _heroes.enemyCollection[id];
        }

        public int NumberHeros()
        {
            return _heroes.enemyCollection.Count;
        }

    }
}
