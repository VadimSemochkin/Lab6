using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            string strLow = str.ToLower();
            //Console.Write("предложение в нижнем регистре: ");
            //Console.WriteLine(strLow);
            
            string[] ar = { " ", ",", ".", "!", "?", "-" };
            for (int i = 0; i < ar.Length; i++)
            {
                strLow = strLow.Replace(ar[i], "");
                
            }
            //Console.Write("предложение в нижнем регистре и без знаков: ");
            //Console.WriteLine(strLow);

            string reversStr = "";
         
            for (int i = strLow.Length-1; i>=0; i--)
            {
                reversStr += strLow[i];
            }
            //Console.WriteLine(reversStr);
 
            if (strLow==reversStr)
            {
                Console.WriteLine("Введенная строка - палиндром.");
            }
            else

                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.ReadKey();

        }
       
       
    }
}
