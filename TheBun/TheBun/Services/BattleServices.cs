using TheBun.Models;

namespace TheBun.Services
{
    public static class BattleServices
    {
        public static int Hit(Battle battle)
        {
            return battle.Opponents[0].Damage;
        }

        public static int Buff(Battle battle)
        {
            return battle.Opponents[0].Buff;
        }
    }
}
