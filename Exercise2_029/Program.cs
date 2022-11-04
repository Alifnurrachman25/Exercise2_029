using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_029
{
    internal class Program
    {
        private int[] alif = new int[31];

        private int n;

        private int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 31))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 31 elements.\n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                alif[i] = Int32.Parse(s1);
            }
        }

 

        static void Main(string[] args)
        {

        }
    }
}