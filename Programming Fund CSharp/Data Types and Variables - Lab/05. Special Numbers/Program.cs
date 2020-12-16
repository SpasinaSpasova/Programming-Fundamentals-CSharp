using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());//брояча

            for (int i = 1; i <= count; i++)
            {
                int summOfDigist = 0;
                int digit = i;//14
                //за да запазим стойността на "i" и for цикъла да си върти правилно
                
                while (digit > 0)//14>0
                {
                    summOfDigist += digit % 10;//4=>4; 1=>5
                    //сумираме цифрите като взимаме последната
                    digit /= 10;//остава 1 и пак завърта уайл цикъла
                    //при второто завъртане остава 0  и цикъла приключва и влиза в проверките
                    //а тук взимаме числото преди последната и тн.
                    //и същевременно тук не губим стойността на "и" за " фор" цикъла

                }
               

                if (summOfDigist == 5 || summOfDigist == 7 || summOfDigist == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }


        }
    }
}
