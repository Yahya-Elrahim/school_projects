

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
      

        //insertion sort 
      public static  void insertionSort(int[] dizi) {
          int time = DateTime.Now.Millisecond;

         for(int i=0; i<dizi.Length-1; i++){
             for (int j = 1+i; j >0; j--) {
                 if (dizi[j] < dizi[j - 1]) { 
                  int gecici=dizi[j-1];
                     dizi[j-1]=dizi[j];
                     dizi[j] = gecici;
                 
                 }
             
             }

         }
         Console.WriteLine(" insertion sort dizinin sýralanmiþ halindedir\n-------------------------------------------");
         for (int i = 0; i < dizi.Length; i++)
         {
             Console.WriteLine("dizinin {0}.elaman\t{1}", i + 1, dizi[i]);
         }


         int time1 = DateTime.Now.Millisecond;
         int insert = time1 - time;
         Console.WriteLine("\n\tgeçen süre :{0}",insert);
        }
        //selection
      public static void selction(int[] dizi)
      {
          int time = DateTime.Now.Millisecond; ;
          for (int i = 0; i < dizi.Length; i++)
          {
              for (int j = 1+i; j < dizi.Length; j++)
              {
                  if (dizi[j] < dizi[i])
                  {
                      int gecici = dizi[i];
                      dizi[i] = dizi[j];
                      dizi[j] = gecici;

                  }

              }
            
          }
          Console.WriteLine("\nselection sort dizinin sýralanmiþ halindedir\n----------------------------------------------");
          for (int i = 0; i < dizi.Length; i++)
          {
              Console.WriteLine("dizinin {0}.elaman\t{1}", i + 1, dizi[i]);
          }
          int time1 = DateTime.Now.Millisecond;
          int selc = time1 - time;
          Console.WriteLine("\n\tgeçen sure :{0}", selc);
      }
        //bubble sort
      public static void bubble(int[] dizi)
      {
          int time = DateTime.Now.Millisecond;
          for (int i = 0; i < dizi.Length; i++)
          {
              for (int j = 0; j < dizi.Length-1; j++)
              {
                  if (dizi[j] > dizi[j+1])
                  {
                      int gecici = dizi[j+1];
                      dizi[j+1] = dizi[j];
                      dizi[j] = gecici;

                  }

              }
            
          }
          Console.WriteLine("\bubble sort dizinin sýralanmiþ halindedir\n----------------------------------------------");
          for (int i = 0; i < dizi.Length; i++)
          {
              Console.WriteLine("dizinin {0}.elaman\t{1}", i + 1, dizi[i]);
          }
          int time1 = DateTime.Now.Millisecond;
          int bubb = time1 - time;
          Console.WriteLine("\n\tgeçen süre :{0}", bubb);
      }

        static void Main(string[] args)
        {
            int[] dizi = new int[100];
            Random rn = new Random();
            Console.Write("dizinin ilk haldir");
            for (int i = 0; i < dizi.Length; i++) {
                dizi[i] = rn.Next(1,100);
                Console.WriteLine("dizinin {0}.elaman\t{1}", i + 1, dizi[i]);
            }


            insertionSort(dizi);
            selction(dizi);
            bubble(dizi);
            


            Console.ReadKey();
       }
    }
}
