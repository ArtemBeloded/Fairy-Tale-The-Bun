using System;
using TheBun.Models;
using TheBun.Models.Main;

namespace TheBun.Services
{
    public class MainHeroManager
    {
        private MainCharacterCollection _heroes;
        public MainHeroManager()
        {
            _heroes = new MainCharacterCollection();
        }

        public void AddHero(int numberOfHero)
        {
            _heroes.mainCollection.Add(new MainCharacter()
            {
                id = NumberHeros(),
                name = Enum.GetName(typeof(Name), numberOfHero),
                hp = 100
            });
        }

        public void DeleteHero(int id)
        {
            _heroes.mainCollection.RemoveAt(id);
        }

        public void EditHero(MainCharacter mainCharacter, int id)
        {
            _heroes.mainCollection[id] = mainCharacter;
        }

        public MainCharacter GetHero(int id)
        {
            return _heroes.mainCollection[id];
        }

        public int NumberHeros()
        {
            return _heroes.mainCollection.Count;
        }
    }
}
