using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(4);
            li.Add(1);
            li.Add(3);
            li.Add(2);

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            li.MySortFunction();

            Console.WriteLine("After sorting");

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static class MyListFunction
    {
        public static void MySortFunction(this List<int> li)
        {
            int temp;
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        //swap
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
                Console.WriteLine(".......................");
                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(".......................");
            }
        }
    }
}