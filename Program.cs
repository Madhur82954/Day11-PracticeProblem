using System;
using System.Collections.Generic;

namespace Day11_PracticeProblem
{
    internal class Program
    {
        static int findremainingchapters(int N,List<(int,int)> list,int k)
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
        }
        static void Main(string[] args)
        {
            int N = 4,k=7;
            List<(int, int)> list = new List<(int, int)> {(1,4),(5,7),(9,16),(17,26)};
            int chapters = findremainingchapters(N, list, k);
            Console.WriteLine(chapters);
        }
    }
}
