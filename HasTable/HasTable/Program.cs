

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //girilen bir ifade polindrom olup olmadigini kontrol eden program.
            int sayac = 0;
            Stack<char> yigin = new Stack<char>();
            string kelime = Console.ReadLine();
            for (int i = 0; i < kelime.Length; i++)
            {
                yigin.Push(kelime[i]);
            }
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] != yigin.Pop())
                {
                    Console.WriteLine("girilen ifade  polindrom degildir.");
                    sayac++;
                    break;

                }//end if clo

            }//end for loop
            if (sayac == 0)
            {
                Console.WriteLine("girilen ifade bir polindrom ifadesi.");
            }


                Console.ReadKey();
        }
    }
}