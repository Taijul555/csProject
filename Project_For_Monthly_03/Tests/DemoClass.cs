using Project_For_Monthly_03.Factories;
using Project_For_Monthly_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_For_Monthly_03.Tests
{
    public class DemoClass
    {
        IModelFactory mf;
        public DemoClass(IModelFactory mf) 
        { 
            this.mf = mf;
        }
        public void Run()
        {
            List<Publisher> publishers = new List<Publisher>()
            {
                mf.Create< Publisher>(1, "Wrox Inc."),
                mf.Create<Publisher>(2, "A Press"),
                mf.Create<Publisher>(3, "M Press")
            };
            Console.WriteLine("//////////////////////Publishers");
            publishers
                 .ForEach(x => Console.WriteLine(x));
            List<Book> books = new List<Book>()
            {
                mf.Create<Book>(1, "AA", 1),
                mf.Create<Book>(2, "BB", 1),
                mf.Create<Book>(3, "CC", 2)
            };
            Console.WriteLine("//////////////////////Books");
            books
                 .ForEach(b => Console.WriteLine(b));
        }
    }
}
