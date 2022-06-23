using System;

namespace Prakt_5
{
    class Program
    {
        static int[] Input()
        {
            int[] a = new int[30];
            for (int i = 0; i < 30; ++i)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int elem in a)
            {
                sum += elem;
            }
            return sum;
        }
/*        static void Main()
        {
            int[] a = Input();
            Console.WriteLine("{Сумма элементов в массиве=0}", Sum(a));
        }*/


        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            double sum = 0;
            int temp1, temp2;
            for (int i = 1; i <= m; i++)
            {
                temp1 = i;
                temp2 = i;
                while (temp1 != 0)
                {
                    temp1 /= 10;
                    n++;
                }
                while (temp2 != 0)
                {
                    int number = temp2 % 10;
                    sum += Math.Pow(number, n);
                    temp2 /= 10;
                }
                if (sum == i) Console.WriteLine(i);

                n = 0;
                sum = 0;
            }
        }
    }
}

