using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string a = Console.ReadLine();
            string[] str = a.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int max = 0, nomer = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length>max)
                {
                    max = str[i].Length;
                    nomer = i;
                }

            }
            Console.WriteLine("Самое длинное слово - {0}",str[nomer]);
            Console.ReadKey();
        }
    }
}
