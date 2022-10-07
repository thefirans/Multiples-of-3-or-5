using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class Kata
    {
        public static int Solution(int value)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    list.Add(i);
                }
            }
            return list.Sum();
        }
    }
}
