using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        public static void ShellSort(int[] MyArr)
        {
            int size = MyArr.Length;
            for (int gap = size / 2; gap > 0; gap /= 2)
            {
                for (int i = 0; i < size - gap; i++)
                {
                    if (MyArr[i] > MyArr[gap + i])
                    {
                        int swap = MyArr[gap + i];
                        MyArr[gap + i] = MyArr[i];
                        MyArr[i] = swap;
                        int swap1;
                        for (int j = 0; j <= i; j++)
                        {
                            if (MyArr[j] > MyArr[j + gap])
                            {
                                swap1 = MyArr[j];
                                MyArr[j] = MyArr[j + gap];
                                MyArr[j + 1] = swap;

                            }
                        }
                    }
                }
            }

            for (int i = 0; i < MyArr.Length; i++)
            {
                Console.WriteLine("{0}.eleman: {1}", i + 1, MyArr[i]);
            }
        }
        static void Main(string[] args)
        {

            int[] MyArray = new int[8];
            Random rastgele = new Random();
            Console.WriteLine("the elements befor sorting.");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = rastgele.Next(0, 100);
                Console.WriteLine("{0}.eleman: {1}", i + 1, MyArray[i]);
            }

            Console.WriteLine("the elements sfter sorting using shell sort algorthim.");
            ShellSort(MyArray);
            Console.ReadKey();
        }
    }
}
