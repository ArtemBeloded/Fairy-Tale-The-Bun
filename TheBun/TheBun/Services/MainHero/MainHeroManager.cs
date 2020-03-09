using System;
using TheBun.Models;

namespace TheBun.Services
{
    public class MainHeroManager
    {
        private HeroesCollection<MainCharacter> _heroes;

        public MainHeroManager()
        {
            _heroes = new HeroesCollection<MainCharacter>();
        }

        public void AddHero(int numberOfHero)
        {
            _heroes.Collection.Add(new MainCharacter()
            {
                Id = NumberHeros(),
                Name = Enum.GetName(typeof(Name), numberOfHero),
                Hp = 100
            });
        }

        public void DeleteHero(int id)
        {
            _heroes.Collection.RemoveAt(id);
        }

        public void EditHero(MainCharacter mainCharacter, int id)
        {
            _heroes.Collection[id] = mainCharacter;
        }

        public MainCharacter GetHero(int id)
        {
            return _heroes.Collection[id];
        }

        public int NumberHeros()
        {
            return _heroes.Collection.Count;
        }
    }
}
