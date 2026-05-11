using System;
using System.IO.Enumeration;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHandler.MakeStockBinFile();
            List<VisitStat> data = new List<VisitStat>();
            string currentFile = "";
            string choice = "";

            while(true)
            {
                Console.WriteLine($"\n--- Меню ---{(currentFile == "" ? "" : '(' + currentFile + ')')}");
                Console.WriteLine("1. Чтение базы данных из файла");
                Console.WriteLine("2. Просмотреть базу данных");
                Console.WriteLine("3. Добавить запись");
                Console.WriteLine("4. Удалить по ID");
                Console.WriteLine("5. Запросы LINQ");
                Console.WriteLine("0. Выход");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        while (true)
                        {
                            try
                            {
                                Console.Write("Введите название файла базы данных: ");
                                currentFile = Console.ReadLine();
                                data = DatabaseHandler.LoadFile(currentFile);
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка чтения: " + ex.Message);
                            }
                        }
                        break;
                    case "2":
                        if (!data.Any())
                        {
                            Console.WriteLine("Не была выбрана база данных.");
                        }
                        else
                        {
                            Console.WriteLine("Текущая база данных:");
                            DatabaseHandler.PrintDatabase(data);
                        }
                        break;
                    case "3":
                        DatabaseHandler.AddEntry(data, currentFile);
                        break;
                    case "4":
                        data = DatabaseHandler.RemoveById(data, currentFile);
                        break;
                    case "5":
                        Console.WriteLine("Посещения дольше 60 сек:");
                        DatabaseHandler.PrintDatabase(DatabaseHandler.GetLongVisits(data));
                        Console.WriteLine("Посещения страницы '/home' с сортировкой по времени:");
                        DatabaseHandler.PrintDatabase(DatabaseHandler.GetVisitsByUrl(data, "/home"));
                        Console.WriteLine($"Среднее время посещения страниц: {DatabaseHandler.GetAverageDuration(data)}");
                        Console.WriteLine($"Наиболее посещаемая страница: {DatabaseHandler.GetMostVisitedPage(data)}");
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}
/*
Test:

Бинарный файл test.bin был успешно создан с 6 записями.

--- Меню ---
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
123

--- Меню ---
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
1
Введите название файла базы данных: nonexistent.txt
Ошибка чтения: Указанный файл не найден.
Введите название файла базы данных: test.bin
База данных test.bin была успешно считана.

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
2
Текущая база данных:
[1]      09.05.2026 20:23:41     | /home         | Время: 45с    | Рег: Да
[2]      09.05.2026 21:23:41     | /shop/items   | Время: 120с   | Рег: Нет
[3]      09.05.2026 22:23:41     | /contacts     | Время: 15с    | Рег: Да
[4]      09.05.2026 23:23:41     | /shop/items   | Время: 300с   | Рег: Да
[5]      10.05.2026 0:23:41      | /news/today   | Время: 55с    | Рег: Нет
[6]      10.05.2026 0:53:41      | /home         | Время: 10с    | Рег: Нет

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
3
URL: Hello World!
Указанная строка не является URL адресом.
URL: /home
Длительность (сек): -123
Число должно быть натуральным!!!
Длительность (сек): 5
Пользователь зарегистрирован (да/нет)? что?
Неверный ввод.
Пользователь зарегистрирован (да/нет)? да

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
2
Текущая база данных:
[1]      11.05.2026 19:15:36     | /home         | Время: 45с    | Рег: Да
[2]      11.05.2026 20:15:36     | /shop/items   | Время: 120с   | Рег: Нет
[3]      11.05.2026 21:15:36     | /contacts     | Время: 15с    | Рег: Да
[4]      11.05.2026 22:15:36     | /shop/items   | Время: 300с   | Рег: Да
[5]      11.05.2026 23:15:36     | /news/today   | Время: 55с    | Рег: Нет
[6]      11.05.2026 23:45:36     | /home         | Время: 10с    | Рег: Нет
[7]      12.05.2026 0:15:46      | /home         | Время: 5с     | Рег: Да

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
4
Введите ID для удаления: 4
ID [4] был удален из базы данных.

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
2
Текущая база данных:
[1]      11.05.2026 19:15:36     | /home         | Время: 45с    | Рег: Да
[2]      11.05.2026 20:15:36     | /shop/items   | Время: 120с   | Рег: Нет
[3]      11.05.2026 21:15:36     | /contacts     | Время: 15с    | Рег: Да
[5]      11.05.2026 23:15:36     | /news/today   | Время: 55с    | Рег: Нет
[6]      11.05.2026 23:45:36     | /home         | Время: 10с    | Рег: Нет
[7]      12.05.2026 0:15:46      | /home         | Время: 5с     | Рег: Да

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
5
Посещения дольше 60 сек:
[2]      11.05.2026 20:15:36     | /shop/items   | Время: 120с   | Рег: Нет
Посещения страницы '/home' с сортировкой по времени:
[7]      12.05.2026 0:15:46      | /home         | Время: 5с     | Рег: Да
[6]      11.05.2026 23:45:36     | /home         | Время: 10с    | Рег: Нет
[1]      11.05.2026 19:15:36     | /home         | Время: 45с    | Рег: Да
Среднее время посещения страниц: 41,666666666666664
Наиболее посещаемая страница: /home

--- Меню ---(test.bin)
1. Чтение базы данных из файла
2. Просмотреть базу данных
3. Добавить запись
4. Удалить по ID
5. Запросы LINQ
0. Выход
0

C:\Users\valus\source\repos\CS_course\lab_3\ConsoleApp1\bin\Debug\net10.0\ConsoleApp1.exe (процесс 14448) завершил работу с кодом 0 (0x0).
 */
