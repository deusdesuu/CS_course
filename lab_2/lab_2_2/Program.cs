using System;

namespace lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 0;
            // Task6
            /*
            Console.WriteLine("Задание 6.");
            Console.WriteLine("Введите натуральное число n - кол-во элементов в списке.");

            n = Input.InputUInt("n: ");
            List<int> list = Structures.MakeListInt(n);

            Console.WriteLine("Исходный список:\n" + Structures.ListIntToString(list));
            Console.WriteLine("Результат работы программы:");
            Console.WriteLine(Structures.ListIntToString(Structures.Task6(list)) + '\n');
            */
            /*
            Console.WriteLine("Задание 7.");
            Console.WriteLine("Введите натуральное число n - кол-во элементов в списке.");

            n = Input.InputUInt("n: ");
            LinkedList<int> linkedList = Structures.MakeLinkedListInt(n);
            Console.WriteLine("Исходный список:");
            Console.WriteLine(Structures.LinkedListIntToString(linkedList));

            Console.WriteLine("Результат работы программы:");
            Console.WriteLine(Structures.LinkedListIntToString(Structures.Task7(linkedList)));
            */
            // Task10
            /*
             * 75 | 75 76 -> 76
             * 75 | 76 -> 76
             * 75 | ... 75 -> 75
             */
            Console.WriteLine("Задание 10.");
            KeyValuePair<int, SortedList<int, int>> pair = Structures.ReadFile("input.txt");

            int resultScore = Structures.Task10(pair);
            Console.WriteLine("Искомый минимальный балл на \"отлично\": " + resultScore);
        }
    }
}