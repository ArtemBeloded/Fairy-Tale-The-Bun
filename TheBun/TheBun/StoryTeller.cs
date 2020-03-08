using System;
using TheBun.Services;

namespace TheBun
{
    class StoryTeller
    {
        private static HistoryServices _historyServices;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Жил-был однажды колобок скучно и боязно ему было с бабкой да дедом.");
                Console.WriteLine("Решил он однажды укатиться от них..");
                Console.WriteLine("Катится он...катится как вдруг..");
                _historyServices = new HistoryServices();

                for (int i = 0; i < _historyServices.countOfEnemyHeroes; i++)
                {
                    if (History()) 
                    {
                        break;
                    }
                }
                if (_historyServices.IsLive())
                {
                    Console.WriteLine("Колобок не смог укатиться от бабки с дедом, потому что злые звери были сильнее него.");
                }
                else
                {
                    Console.WriteLine("Колобок был хитрее и проворнее всех остальных и смог убежать");
                }
                Console.WriteLine("");
                Console.WriteLine("Хотите попробывать еще раз? Y/N");



                if (!Console.ReadKey().Key.Equals(ConsoleKey.Y))
                {
                    break;
                }
            }
        }

        private static bool History() 
        {
            _historyServices.SelectEnemyHeroForBattle();
            Console.WriteLine("Как вдруг встречает он незнакомца. И тот говорнит: ");

            if (_historyServices.IsHeroPositiveCharacter())
            {
                Console.WriteLine("Я {0} и я тебе помогу!! И {0} хиллит колобка", _historyServices.GetHeroName());
                Console.WriteLine("Колобок поблагодарил и покатился дальше..");
            }
            else
            {
                Console.WriteLine("Я {0} и я тебя съем!! И нападает на колобка", _historyServices.GetHeroName());
                _historyServices.CreateBatle();
                if (_historyServices.IsLive())
                {
                    Console.WriteLine("Колобок не смог уйти от {0} и он его съел", _historyServices.GetHeroName());
                    return true;
                }
                else
                {
                    _historyServices.DeletHeroAfterBattle();
                    Console.WriteLine("Колобок был хитрее своего обидчика и покатился дальше..");
                }
            }
            return false;
        }
    }
}

