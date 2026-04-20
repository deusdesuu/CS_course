using System;

namespace ConsoleApp1
{
    class Input
    {
        public static uint InputUInt(string msg)
        {
            uint res;
            string input;

            while (true)
            {
                Console.Write(msg);
                input = Console.ReadLine();
                if (uint.TryParse(input, out res))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число должно быть натуральным!!!");
                }
            }
            return res;
        }
        public static bool InputBool(string msg)
        {
            bool res;
            string input;

            while (true)
            {
                Console.Write(msg);
                input = Console.ReadLine();
                if (bool.TryParse(input, out res))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ввод должен быть логическим!!!");
                }
            }
            return res;
        }
    }
}