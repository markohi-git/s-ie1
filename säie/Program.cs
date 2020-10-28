using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace säie
{
    class Program
    {
        public static void WorkerThreadMethod1()
        {
            Console.WriteLine("säi 1 käynnistetty");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("1");
                Thread.Sleep(1);

            }
        }
        public static void WorkerThreadMethod2()
        {
            Console.WriteLine("säi 2 käynnistetty");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("2");
                Thread.Sleep(1);
            }
        }
        static void Main(string[] args)
        {
            //delegaatti säikeenluomista varten
            ThreadStart worker1 = new ThreadStart(WorkerThreadMethod1);
            ThreadStart worker2 = new ThreadStart(WorkerThreadMethod2);
            Console.WriteLine("Main - luodaan Säie");

            Thread t1 = new Thread(worker1);
            Thread t2 = new Thread(worker2);

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
