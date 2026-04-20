using System;

namespace ConsoleApp2
{
    class Input
    {
        public static double InputDouble(string msg)
        {
            double res;
            string input;
            
            while (true)
            {
                Console.Write(msg);
                input = Console.ReadLine();
                if (double.TryParse(input, out res))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ожидался тип double!!!");
                }
            }
            return res;
        }
    }
}