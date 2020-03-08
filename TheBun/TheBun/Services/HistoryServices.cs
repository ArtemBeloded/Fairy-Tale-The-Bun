using System;
using TheBun.Models;

namespace TheBun.Services
{
    public class HistoryServices
    {
        public int countOfEnemyHeroes { get; private set; }
        private int _numOfHero;
        private EnemyHeroManager _enemyHeroManager;
        private MainHeroManager _mainHeroManager;
        private Battle _battle;

        private delegate void Assistant();
        private event Assistant Preparation;
        private Random rnd;

        public HistoryServices()
        {
            rnd = new Random();
            _enemyHeroManager = new EnemyHeroManager();
            _mainHeroManager = new MainHeroManager();
            Preparation = CreateEnemyHeroes;
            Preparation += CreateMainHeroes;
            CountOfEnemyHeroes();
        }

        public void CreateEnemyHeroes()
        {
            for (int i = 0; i < countOfEnemyHeroes; i++)
            {
                _enemyHeroManager.AddHero(NameOfEnemyHero());
            }
        }

        private int NameOfEnemyHero()
        {
            return rnd.Next(1, 9);
        }
        private void CountOfEnemyHeroes()
        {
            countOfEnemyHeroes = rnd.Next(3, 16);
            Preparation();
        }

        public void CreateMainHeroes()
        {
            _mainHeroManager.AddHero(0);
        }

        public bool CheckHp()
        {
            if (_mainHeroManager.GetHero(0).hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SelectEnemyHeroForBattle()
        {
            _numOfHero = rnd.Next(0, _enemyHeroManager.NumberHeros() - 1);
        }

        public bool GetHeroPositiveCharacter() 
        {
            return _enemyHeroManager.GetHero(_numOfHero).positiveCharacter;
        }

        public string GetHeroName()
        {
            return _enemyHeroManager.GetHero(_numOfHero).name;
        }

        public void CreateBatle()
        {
            _battle = new Battle();
            _battle.opponents.Add(_enemyHeroManager.GetHero(_numOfHero));
            var mainHero = _mainHeroManager.GetHero(0);
            if (_battle.opponents[0].positiveCharacter)
            {
                mainHero.hp += BattleServices.Buff(_battle);
            }
            else
            {
                mainHero.hp -= BattleServices.Hit(_battle);
            }
            _mainHeroManager.EditHero(mainHero, 0);
        }

        public void DeletHeroAfterBattle()
        {
            _enemyHeroManager.DeleteHero(_numOfHero);
        }
    }
}
