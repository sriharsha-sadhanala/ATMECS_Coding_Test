using System;
using System.Threading;
using System.Threading.Tasks;

namespace ATMECS_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start----{0}", DateTime.Now.ToString("ss:fff"));//To show execution time

            Timer timer = new Timer(ShowTime, null, 0, 10); // To show main process is going on.

            //To run tasks in background and sequentially as added.
            Task.Run(() =>
            {
                Task1();
                Task2();
                Task3();
            });

            Console.WriteLine("End----{0}", DateTime.Now.ToString("ss:fff"));  //To show execution time
            Console.ReadLine();
        }

        /// <summary>
        /// Method to call in Tasks
        /// </summary>
        /// <param name="s"></param>
        private static void ShowName(string name)
        {
            Console.WriteLine(name);
        }

        /// <summary>
        /// Method to show timer ticks
        /// </summary>
        /// <param name="o"></param>
        private static void ShowTime(Object o)
        {
            Console.WriteLine("Timer: " + DateTime.Now.ToString("ss:fff"));
        }

        /// <summary>
        /// Task1 method
        /// </summary>
        private static void Task1()
        {
            Task.Run(() =>
            {
                ShowName("one");
                Console.WriteLine("one----{0}", DateTime.Now.ToString("ss:fff"));//To show execution time
            }).Wait();
        }

        /// <summary>
        /// Task2 method
        /// </summary>
        private static void Task2()
        {
            Task.Run(() =>
            {
                ShowName("two");
                Console.WriteLine("two----{0}", DateTime.Now.ToString("ss:fff"));//To show execution time
            }).Wait();
        }

        /// <summary>
        /// Task3 method
        /// </summary>
        private static void Task3()
        {
            Task.Run(() =>
            {
                ShowName("three");
                Console.WriteLine("three----{0}", DateTime.Now.ToString("ss:fff"));//To show execution time
            }).Wait();
        }
    }
}
