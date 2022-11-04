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

        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)// untuk n - 1 passes
            {
                //pada pass i,bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int ar = 0; ar < n - i; ar++)
                {
                    if (alif[ar] > alif[ar + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp; //membuat temporary
                        temp = alif[ar]; //mhigheklarasikan alif[ar]; sebagai temporary
                        alif[ar] = alif[ar + 1]; //memindahkan alif[ar + 1] ke posisi alif[ar] yang dimana sebagai temporary
                        alif[ar + 1] = temp; // alif[ar + 1] sudah berada di posisi alif[ar] yang dimana sebagai temporary
                    }
                }
            }
        }

        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine(""); //membuat space kosong
            Console.WriteLine("------------------------------------"); //membuat batasan garis
            Console.WriteLine(" Elemen array yang telah tersusun "); //membuat teks " Elemen array yang telah tersusun "
            Console.WriteLine("------------------------------------"); //membuat batasan garis
            for (int ar = 0; ar < n; ar++)
            {
                Console.WriteLine(alif[ar]);
            }
            Console.WriteLine(""); //membuat space kosong
        }
        


        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu Option");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Bubble sort");
            Console.WriteLine("2. Merge sort");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice (1,2,3) : ");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Bubble sort");
                    Console.WriteLine("------------------");
                    myList.input();
                    myList.BubbleSortArray();
                    myList.display();
                    Console.ReadLine();
                    break;
            }
        }
    }
}