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
                Console.WriteLine("Жил-был однажды колобок скучно и боязно ему было с бабкой да дедом.");
                Console.WriteLine("Решил он однажды укатиться от них..");
                Console.WriteLine("Катится он...катится как вдруг..");
                HistoryServices historyServices = new HistoryServices();

                for (int i = 0; i < historyServices.countOfEnemyHeroes; i++)
                {
                    historyServices.SelectEnemyHeroForBattle();
                    Console.WriteLine("Как вдруг встречает он незнакомца. И тот говорнит: ");
                    
                    if (historyServices.GetHeroPositiveCharacter())
                    {
                        Console.WriteLine("Я {0} и я тебе помогу!! И {0} хиллит колобка", historyServices.GetHeroName());
                        Console.WriteLine("Колобок поблагодарил и покатился дальше..");
                    }
                    else 
                    {
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
                            Console.WriteLine("Колобок был хитрее своего обидчика и покатился дальше..");
                        }
                    }
                }
                if (historyServices.CheckHp())
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
    }
}

