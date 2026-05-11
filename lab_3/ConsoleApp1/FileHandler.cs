using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class DatabaseHandler
    {
        public static void MakeStockBinFile()
        {
            string filename = "test.bin";

            List<VisitStat> initData = new List<VisitStat>
            {
                new VisitStat { Id = 1, PageUrl = "/home", VisitTime = DateTime.Now.AddHours(-5), Duration = 45, IsRegistered = true },
                new VisitStat { Id = 2, PageUrl = "/shop/items", VisitTime = DateTime.Now.AddHours(-4), Duration = 120, IsRegistered = false },
                new VisitStat { Id = 3, PageUrl = "/contacts", VisitTime = DateTime.Now.AddHours(-3), Duration = 15, IsRegistered = true },
                new VisitStat { Id = 4, PageUrl = "/shop/items", VisitTime = DateTime.Now.AddHours(-2), Duration = 300, IsRegistered = true },
                new VisitStat { Id = 5, PageUrl = "/news/today", VisitTime = DateTime.Now.AddHours(-1), Duration = 55, IsRegistered = false },
                new VisitStat { Id = 6, PageUrl = "/home", VisitTime = DateTime.Now.AddMinutes(-30), Duration = 10, IsRegistered = false }
            };

            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter stream = new BinaryWriter(fs);

            foreach (VisitStat item in initData)
            {
                stream.Write(item.Id);
                stream.Write(item.PageUrl);
                stream.Write(item.VisitTime.ToBinary());
                stream.Write(item.Duration);
                stream.Write(item.IsRegistered);
            }
            Console.WriteLine($"Бинарный файл {filename} был успешно создан с {initData.Count} записями.");

            stream.Close();
            fs.Close();
        }
        public static List<VisitStat> LoadFile(string path)
        {
            List<VisitStat> list = new List<VisitStat>();
            if (!File.Exists(path))
            {
                throw new Exception("Указанный файл не найден.");
            }

            try
            {
                FileStream inputStream = new FileStream(path, FileMode.Open);
                BinaryReader stream = new BinaryReader(inputStream);

                while (inputStream.Position < inputStream.Length)
                {
                    list.Add(new VisitStat
                    {
                        Id = stream.ReadInt32(),
                        PageUrl = stream.ReadString(),
                        VisitTime = DateTime.FromBinary(stream.ReadInt64()),
                        Duration = stream.ReadInt32(),
                        IsRegistered = stream.ReadBoolean()
                    });
                }

                stream.Close();
                inputStream.Close();
                Console.WriteLine($"База данных {path} была успешно считана.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ошибка чтения: " + ex.Message);
            }

            return list;
        }
        
        // empty path -> return
        // file does not exist -> create and fill
        public static void UpdateDatabase(string path, List<VisitStat> data)
        {
            if (path == "")
            {
                return;
            }
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter stream = new BinaryWriter(fs);

            foreach (VisitStat item in data)
            {
                stream.Write(item.Id);
                stream.Write(item.PageUrl);
                stream.Write(item.VisitTime.ToBinary());
                stream.Write(item.Duration);
                stream.Write(item.IsRegistered);
            }

            stream.Close();
            fs.Close();
        }
        
        public static void PrintDatabase(List<VisitStat> data)
        {
            foreach (VisitStat item in data)
            {
                Console.WriteLine(item);
            }
        }
        public static void AddEntry(List<VisitStat> data, string path)
        {
            string url = "";
            while (true)
            {
                Console.Write("URL: ");
                url = Console.ReadLine();
                if (VisitStat.IsUrl(url))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Указанная строка не является URL адресом.");
                }
            }
            data.Add(new VisitStat
            {
                Id = data.Last().Id + 1,
                PageUrl = url,
                VisitTime = DateTime.Now,
                Duration = (int)Input.InputUInt("Длительность (сек): "),
                IsRegistered = Input.InputBoolRU("Пользователь зарегистрирован (да/нет)? ")
            });
            DatabaseHandler.UpdateDatabase(path, data);
        }
        public static List<VisitStat> RemoveById(List<VisitStat> data, string path)
        {
            int id = (int)Input.InputUInt("Введите ID для удаления: ");
            data = data.Where(item => item.Id != id).ToList();
            DatabaseHandler.UpdateDatabase(path, data);
            Console.WriteLine($"ID [{id}] был удален из базы данных.");
            return data;
        }
        // Посещения дольше 60 сек - перечень
        public static List<VisitStat> GetLongVisits(List<VisitStat> data)
        {
            return data.Where(item => item.Duration > 60).ToList();
        }
        // Посещения конкретной страницы с сортировкой по времени посещения - перечень
        public static List<VisitStat> GetVisitsByUrl(List<VisitStat> data, string url)
        {
            return data.Where(item => item.PageUrl.Contains(url)).OrderByDescending(item => item.VisitTime).ToList();
        }
        // Среднее время посещения - значение
        public static double GetAverageDuration(List<VisitStat> data)
        {
            return !data.Any() ? 0 : data.Average(item => item.Duration);
        }
        // Наиболее посещаемая страница - значение
        public static string GetMostVisitedPage(List<VisitStat> data)
        {
            return data.GroupBy(item => item.PageUrl)
                .OrderByDescending(item => item.Count())
                .Select(item => item.Key)
                .FirstOrDefault() ?? "Нет Данных";
        }
    }
}
