

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication3
{
    class Program
    {
      static void linearPorb(int[] dizi)//100 eleman aldik
        {
            Hashtable MyHashTable = new Hashtable();
            int MyValue, Mykey,durum=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                MyValue=dizi[i];
                Mykey = MyValue % dizi.Length; //hash fonksiyonu bulduk
                if (MyHashTable[Mykey] == null)//Çakisma olmasin diye kontrol etsin.
                {
                    MyHashTable.Add(Mykey, MyValue);
                    durum = -1;
                }//hash indexi bossa hemen yeni elenanimiz eklesin.

                else   //Degilse Çakisma olumstur.
                {
                    if (Mykey == dizi.Length - 1) Mykey = 0; //eleman son index'teyse bastan baslasin.
                    else
                    {
                        Mykey = Mykey + 1;
                    }//Bi sonraki elemani kontrol etsin.

                }//Degilse index 1 artsin
                while (durum != -1 )
                {
                    if (MyHashTable[Mykey] == null)
                    {
                        MyHashTable.Add(Mykey,MyValue);
                        durum = -1;
                    }
                    else
                    {
                        if (Mykey == dizi.Length - 1) Mykey = 0;
                        else
                        Mykey = Mykey + 1; ;
                    }
                }
                durum = 0;
            }
            Console.Write("\n\t **Has table elemanlari\"Linear Probing\"**\n\t----------------------------------------\n");

            foreach (int key in MyHashTable.Keys)
            {
                Console.WriteLine("key no:{0}  value:{1}",key,MyHashTable[key]);
            } //index sirasi ve degeri yazdirsin.
               

        }

       static void QuadratikProbing(int [] dizi)
        {

            Hashtable MyHashta = new Hashtable();
            int MyValue, Mykey, durum = 0,t=1;
            for (int i = 0; i < dizi.Length; i++)
            {
                MyValue = dizi[i];
                Mykey = MyValue % dizi.Length; //hash fonksiyonu bulduk
                if (MyHashta[Mykey] == null)//Çakisma var mi diye kontrol etsin.
                {
                    MyHashta.Add(Mykey, MyValue);
                    durum = -1;
                }//hash indexi bossa hemen yeni elenanimiz eklesin.

                else   //Degilse Çakisma olumstur.
                {
                    if (Mykey == dizi.Length - 1) Mykey = 0; //eleman son index'teyse bastan baslasin.
                    else
                    {
                        Mykey = Mykey + t * t;
                    }

                }//Degilse index 1 artsin
                while (durum != -1)
                {
                    if (MyHashta[Mykey] == null)
                    {
                        MyHashta.Add(Mykey, MyValue);
                        durum = -1;
                        t = 1;
                    }
                    else
                    {
                        if (Mykey == dizi.Length - 1) Mykey = 0;
                        else
                        {
                            t++;
                            Mykey = Mykey + t * t;
                        }
                    }
                    
                }
                durum = 0;
            }
            Console.Write("\n\t **Has table elemanlari \"Quadratic Probing\"**\n\t---------------------------------------\n");

            foreach (int key in MyHashta.Keys)
            {
                Console.WriteLine("key no:{0}  value:{1}", key, MyHashta[key]);
            } //index sirasi ve degeri yazdirsin.

        }


        static void Main(string[] args)
        {

           int[] dizi = new int[100];
            Random rnd = new Random();
            for(int i=0; i<100; i++)
            {

                dizi[i] = rnd.Next(1,1000);

            }

            linearPorb(dizi);
            QuadratikProbing(dizi);

      
            Console.Read();




            
        }
    }
}