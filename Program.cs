using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(2,10,3));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int X,int Y,int D)
        {
            return (int)Math.Ceiling((Y - X) / (double)D);
        }
    }
}
