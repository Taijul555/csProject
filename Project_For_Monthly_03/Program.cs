using Project_For_Monthly_03.Factories;
using Project_For_Monthly_03.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_For_Monthly_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IModelFactory mf = new ModelFactory();
            DemoClass c = new DemoClass(mf);
            c.Run();
            Console.ReadLine();
        }
    }
}
