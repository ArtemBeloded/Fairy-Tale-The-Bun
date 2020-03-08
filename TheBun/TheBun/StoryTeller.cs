using System;
using TheBun.Services;

namespace TheBun
{
    class StoryTeller
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Укатился однажды колобок от бабки с дедом");
                Console.WriteLine("Катится он...катится");
                HistoryServices historyServices = new HistoryServices();

                for (int i = 0; i < historyServices.countOfEnemyHeroes; i++)
                {
                    Console.WriteLine("И тут он встречает..");
                    historyServices.SelectEnemyHeroForBattle();
                    Console.WriteLine("Я {0} и я тебя съем!! И нападает на колобка", historyServices.GetHeroName());
                    historyServices.CreateBatle();
                    if (historyServices.CheckHp())
                    {
                        Console.WriteLine("Колобок не смог уйти от {0} и он его съел", historyServices.GetHeroName());
                        break;
                    }
                    else
                    {
                        historyServices.DeletHeroAfterBattle();
                        Console.WriteLine("Колобок был хитрее своего обидчика и укатился");
                    }
                }
                if (historyServices.CheckHp())
                {
                    Console.WriteLine("Колобок не смог укатиться от бабки с дедом, потому что злые звери его съели");
                }
                else
                {
                    Console.WriteLine("Колобок был хитрее и проворнее всех остальных и смог убежать");
                }
                Console.WriteLine("Хотите попробывать еще раз? Y/N");



                if (!Console.ReadKey().Key.Equals(ConsoleKey.Y))
                {
                    break;
                }
            }
        }
    }
}

