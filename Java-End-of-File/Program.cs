using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_End_of_File
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 3)
            {
                String st = Console.ReadLine();
                Console.WriteLine(x + st);
                x++;
            }
        }
    }
}
