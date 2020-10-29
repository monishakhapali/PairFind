using System;

namespace pairfind
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] a = { 9, 29, 10, 2, 50, 24, 100 };
            int n = 50;
            
            Array.Sort(a);
            findpair(a,n);
            //bool flag = false;
           
           

        }
        public static bool findpair(int[] a, int n)
        {
            int i = 0;
            int j = i + 1;
            while (i < a.Length && j < a.Length)
            {
                if (i < j && a[j] - a[i] == n)
                {
                    Console.WriteLine(a[i] + " " + a[j]);
                    Console.ReadLine();
                    return true;
                }
                else if (a[j] - a[i] < n)
                {
                    j++;
                }
                else if (a[j] - a[i] > n)
                {
                    i++;
                }
            }
            return false;
        }
    }
}
