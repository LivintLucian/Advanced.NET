using System;
using System.Threading;


namespace Lab1
{
    class Threading
    {
        void IsPrime()
        {
            Console.WriteLine("Enter the number: ");
            string string_Number = Console.ReadLine();
            int number = Int32.Parse(string_Number);
            if (number == 2) Console.WriteLine("Prime");
            if (number < 2) Console.WriteLine("Not Prime");
            if (number % 2 == 0 && number != 2) 
                Console.WriteLine("Not Prime");
            else
            {
                for (int i = 3; i <= number / 2; i+=2)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        break;
                    }
                    else
                        Console.WriteLine("Prime");
                }
            }

        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "fir principal";

            Threading t = new Threading();
            Thread first_thread = new Thread(t.IsPrime);
            Thread second_thread = new Thread(t.IsPrime);

            first_thread.Name = "fir2";
            first_thread.Start();

            var first_dateTime = DateTime.Now;
            Console.WriteLine(first_dateTime);

            while (first_thread.IsAlive)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                first_dateTime = first_dateTime.Add(TimeSpan.FromSeconds(1));
                Console.WriteLine(first_dateTime);
            }

            second_thread.Name = "fir2";
            second_thread.Start();

            var second_dateTime = DateTime.Now;
            Console.WriteLine(second_dateTime);

            while (second_thread.IsAlive)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                second_dateTime = second_dateTime.Add(TimeSpan.FromSeconds(1));
                Console.WriteLine(second_dateTime);
            }
        }
    }
}