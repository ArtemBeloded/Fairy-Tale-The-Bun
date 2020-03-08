using TheBun.Models;

namespace TheBun.Services
{
    public static class BattleServices
    {
        public static int Hit(Battle battle)
        {
            return battle.opponents[0].damage;
        }

        public static int Buff(Battle battle)
        {
            return battle.opponents[0].buff;
        }
    }
}
