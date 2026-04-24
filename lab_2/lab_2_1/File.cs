using System;
using System.IO;


namespace ConsoleApp1
{
    internal class File
    {
        private static Random _rnd;

        static File()
        {
            _rnd = new Random();
        }

        public static void MakeFile1(uint n, string filename)
        {
            try
            {
                StreamWriter stream = new StreamWriter(filename);
                for (uint i = 0; i < n; ++i)
                {
                    stream.WriteLine(_rnd.Next() % 1_000_000 - 500_000 + 1);
                }
                stream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        public static void Task1(int k, string inputFile, string outputFile)
        {
            try
            {
                StreamReader input = new StreamReader(inputFile);
                StreamWriter output = new StreamWriter(outputFile);

                string line = "";
                int n = 0;

                while ((line = input.ReadLine()) != null)
                {
                    n = int.Parse(line);
                    output.WriteLine(n / k);
                }

                input.Close();
                output.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        public static void MakeFile2(uint n, uint k, string filename)
        {
            try
            {
                StreamWriter stream = new StreamWriter(filename);

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < k; ++j)
                    {
                        stream.Write(_rnd.Next() % 1_000_000 - 500_000 + 1);
                        stream.Write(" ");
                    }
                    stream.WriteLine();
                }

                stream.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        public static int Task2(string filename)
        {
            try
            {
                string line;
                StreamReader stream = new StreamReader(filename);
                bool firstFlag = true;

                int firstElem = 0;
                int max = 0;
                int elemInt = 0;

                while ((line = stream.ReadLine()) != null)
                {
                    foreach (string elem in line.Split(' '))
                    {
                        if (elem == "")
                        {
                            continue;
                        }
                        elemInt = int.Parse(elem);
                        if (firstFlag)
                        {
                            firstElem = elemInt;
                            max = elemInt;
                            firstFlag = false;
                            continue;
                        }
                        if (elemInt > max)
                        {
                            max = elemInt;
                        }
                    }
                }
                return firstElem + max;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
                return 0;
            }
        }
        public static void MakeFile3(string filename)
        {
            try
            {
                StreamWriter stream = new StreamWriter(filename);
                string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                int n = 33;
                int k = 100;

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < k; ++j)
                    {
                        stream.Write(alph[_rnd.Next(33)]);
                    }
                    stream.WriteLine();
                }
                stream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        public static void Task3(string inputFile, string outputFile)
        {
            try
            {
                StreamReader input = new StreamReader(inputFile);
                StreamWriter output = new StreamWriter(outputFile);

                string line;
                while ((line = input.ReadLine()) != null)
                {
                    if (line[0] == 'б' || line[1] == 'б')
                    {
                        output.WriteLine(line);
                    }
                }

                input.Close();
                output.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        public static void MakeFile4(uint n, string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter stream = new BinaryWriter(fs);

                Console.WriteLine("Исходный файл:");
                int value = 0;

                for (int i = 0; i < n; ++i)
                {
                    value = (int)(_rnd.Next() % 1_000_000 - 500_000 + 1);
                    Console.WriteLine(value);
                    stream.Write(value);
                }
                stream.Close();
                fs.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        public static void Task4(string inputFile, string outputFile)
        {
            try
            {
                FileStream inputStream = new FileStream(inputFile, FileMode.Open);
                FileStream outputStream = new FileStream(outputFile, FileMode.Create);

                BinaryReader input = new BinaryReader(inputStream);
                BinaryWriter output = new BinaryWriter(outputStream);

                Console.WriteLine("\nРезультат работы программы:");

                int value = 0;

                while (inputStream.Position < inputStream.Length)
                {
                    value = input.ReadInt32();
                    if (CheckNum(value))
                    {
                        Console.WriteLine(value);
                        output.Write(value);
                    }
                }
                input.Close();
                output.Close();
                inputStream.Close();
                outputStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в имени файла.");
            }
        }
        private static bool CheckNum(int n)
        {
            if (n < 0)
            {
                n *= -1;
            }
            int a = n % 10;
            int b = a;
            
            while (n != 0)
            {
                b = n % 10;
                n /= 10;
            }
            return a == b;
        }
    }
}
