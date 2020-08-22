using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4._2
{
    class Program
    {
        static void Write(AbstractHandler handler1, AbstractHandler handler2, AbstractHandler handler3)
        {
            handler1.Open();
            handler1.Create();
            handler1.Change();
            handler1.Save();
            Console.WriteLine();

            handler2.Open();
            handler2.Create();
            handler2.Change();
            handler2.Save();
            Console.WriteLine();

            handler3.Open();
            handler3.Create();
            handler3.Change();
            handler3.Save();
        }
        static void Main(string[] args)
        {
            AbstractHandler handler1 = new DOCHandler();
            AbstractHandler handler2 = new TXTHandler();
            AbstractHandler handler3 = new XMLHandler();

            Write(handler1, handler2, handler3);

            Console.ReadKey();
        }
    }
}
