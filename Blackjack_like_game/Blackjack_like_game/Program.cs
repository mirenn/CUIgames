using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_like_game
{
//    class Hit
//    {
  //      Random rnd = new System.Random();
    //    int i = rnd.Next(1, 14);
    //}

    class Program
    {

        static void Main(string[] args)
        { 
            
            int Player = 0;

            Random rnd = new System.Random();
            int iResult1 = rnd.Next(2, 22);
            // Console.Write(iResult1);

            int iResult2 = rnd.Next(1, 14);
            Player += iResult2;
            Console.Write("あなたの今の手札の合計の数は、{0}です\nもう一枚カードを引いてその数を足すならば、Ｐキーを押してください\nこの数でディーラーと勝負するならば、Ｂキーを押してください",Player);
            
            bool bRead = true;

            while (bRead)
            {
                //キー入力を取得
              ConsoleKeyInfo c = Console.ReadKey(true);

               // Console.WriteLine(c.Key.ToString() + " が入力されました。");
                if (c.Key.ToString() == "P")
                {
                    int iResult3 = rnd.Next(1, 14);
                    Player += iResult3;
                 //   Console.Write(Player);
                    Console.Clear();
                    Console.Write("あなたの今の手札の合計の数は、{0}です\nもう一枚カードを引いてその数を足すならば、Ｐキーを押してください\nこの数でディーラーと勝負するならば、Ｂキーを押してください", Player);
                }
                if(c.Key.ToString()=="B")
                {
                    if(Player>=iResult1)
                    {
                        Console.Write("\n\nディーラーの数は{0}でした。あなたの勝ちです",iResult1);
                        break;
                    }
                    else
                    {
                        Console.Write("\n\nディーラーの数は{0}でした。あなたの負けです",iResult1);
                        break;
                    }
                }
               

                if (Player > 21)
                {
                    Console.Clear();
                    Console.Write("あなたの手札の合計の数が{0}となり、21を越えたのでバーストしました。残念失格です",Player);
                }
            }
            Console.Read();
            
        }
    }
}
