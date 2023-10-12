using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11_PracticeProblem
{
    internal class Program
    {
        /*static int findremainingchapters(int N,List<(int,int)> list,int k)
        {
            int chaptersleft = 0;
            foreach((int startpage,int endpage) in list)
            {
                if(k>=startpage && k <= endpage)
                {
                    chaptersleft = N - list.IndexOf((startpage , endpage));
                    break;
                }
            }
            return chaptersleft;
        }*/
        static void Main(string[] args)
        {
            /*int N = 4,k=7;
            List<(int, int)> list = new List<(int, int)> {(1,4),(5,7),(9,16),(17,26)};
            int chapters = findremainingchapters(N, list, k);
            Console.WriteLine(chapters);*/
            string[] s = Console.ReadLine().Split();
            int N = int.Parse(s[0]);
            int k = int.Parse(s[1]);

            List<int> BasketA = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> BasketB = Console.ReadLine().Split().Select(int.Parse).ToList();

            BasketA.Sort();
            BasketB.Sort();
            int i = 0;
            int j = N - 1;

            while(k>0 && i<N && j>=0 && BasketA[i] < BasketB[j])
            {
                BasketA[i] = BasketB[j];
                i++;
                j--;
                k--;
            }
            int MaxPrice = BasketA.Sum();
            Console.WriteLine(MaxPrice);
        }
    }
}
