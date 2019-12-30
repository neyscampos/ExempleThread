using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteX);
            t.Start();

            Task task = Task.Run(() => {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("BackGround thread!!");
                    Thread.Sleep(500);
                }
            });
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("O");
            //}   
        }

        static void WriteX()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("ForeGround thread!!");
                Thread.Sleep(500);
            }
        }
    }
}
