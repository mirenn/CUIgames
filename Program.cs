using System;
using System.Diagnostics;
using System.Threading;


namespace Zero_Button_mirenn
{
    public class MakeBase64
    {

       static bool left = false;
       static int a = 1;
       public static void Main()
       {
           
           
           while (a == 1)
           {
               if (left == false)
               {
                   for (int i = 0; i <= 15; ++i)
                   {
                       for (int j = 0; j < i; ++j)
                       { Console.Write("　"); }
                       Console.Write("爆");

                       Console.Write("\n\n\n\n\n\n　　　　　　敵");
                       Thread.Sleep(300);
                       Console.Clear();

                       if (i == 15)
                       {
                           left = true;
                       }

                      
                   }
               }
               if (left == true)
               {
                   for (int i = 15; i >= 0; --i)
                   {
                       for (int j = 0; j < i; ++j)
                       { Console.Write("　"); }
                       Console.Write("爆");
                       Console.Write("\n\n\n\n\n\n　　　　　　敵");
                       Thread.Sleep(300);
                       Console.Clear();

                       if(i==7)
                       {
                        //ここが無かったら右へ左へ動く
                           a = 2;
                           break;
                       }

                       if (i == 0)
                       {
                           left = false;
                       }
                   }
               }
           } 
           while(a==2)
           {
               for(int i=0;i<=6;++i)
               {
                   for (int j = 0; j < i; ++j)
                   { Console.Write("\n");
                   }
                   Console.Write("　　　　　　爆");
                   switch (i)
                   {
                       case 0:
                           Console.Write("\n\n\n\n\n\n　　　　　　敵");
                           break;
                       case 1:
                           Console.Write("\n\n\n\n\n　　　　　　敵");
                           break;
                       case 2:
                           Console.Write("\n\n\n\n　　　　　　敵");
                           break;
                       case 3:
                           Console.Write("\n\n\n　　　　　　敵");
                           break;
                       case 4:
                           Console.Write("\n\n　　　　　　敵");
                           break;
                       case 5:
                           Console.Write("\n　　　　　　敵");
                           break;
                       case 6:
                           Console.Clear();
                           Console.Write("\n\n\n\n\n\n\n　　　　　　破");
                           a = 3;
                           break;
                   }
                   Thread.Sleep(300);
                   Console.Clear();
               }
               Console.Write("撃破しました");
               Console.Read();
           }
       }
    }
}
