using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext mdx = new MyDbContext();
            Console.WriteLine("Any info");
            foreach(var i in mdx.Albums)
            {
                Console.WriteLine($"{i.Name} {i.Id} ");
            }
        }
    }
}
