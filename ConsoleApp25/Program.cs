using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Один на суше, другой на море ";
            string[] rez;
            rez = x.Split(' ', ',');
            Console.WriteLine(rez[0]);
            Console.WriteLine(rez[1]);
            Console.WriteLine(rez[2]);
            Console.WriteLine(rez[3]);
            Console.WriteLine(rez[4]);
            Console.WriteLine(rez[5]);
            Console.WriteLine(rez[6]);
            Console.WriteLine(" ");
            string x1 = string.Join(":", rez);
            Console.WriteLine(x1);
        }
    }
}
