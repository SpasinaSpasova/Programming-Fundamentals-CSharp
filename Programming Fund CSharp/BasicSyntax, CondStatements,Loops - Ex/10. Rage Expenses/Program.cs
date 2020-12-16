using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countTrashHeadset = countOfLostGames / 2;
            int countTrashMouse = countOfLostGames / 3;
            int countTrashKeyboard = countOfLostGames / 6;
            int countTrashDisplay = countOfLostGames/12;


            //Всяка 2ра игра се намира като общия брой се раздели на 2.
            //Ако има 7 игри ще се получи 3(7/2)==> (3*2=6), защото е целочислено деление.

            //  Всяка 3та по същия начин.

            //Пешо си чупи клавиатурата когато си чупи слушалките и мишката в една и съща игра.
            //Т.е.търсим игра, която е 2ра и 3та едновременно или която се дели на 2 * 3 = 6 без остатък.

            //Пешо си чупи монитора на всяка 2ра счупена клавиатура т.е.на всяка 2 * 6 = 12 игра.

            //После умножаваме броя на игрите по цените и сумираме.
            double total = countTrashHeadset * headsetPrice + countTrashMouse * mousePrice
                + countTrashKeyboard * keyboardPrice + countTrashDisplay * displayPrice;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
