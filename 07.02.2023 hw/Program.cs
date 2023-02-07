using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using website;
using magazine;
using shop;

namespace _07._02._2023_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite site = new WebSite();
            site.name = "Test";
            Console.WriteLine(site);

            Console.ReadKey();
        }
    }
}
