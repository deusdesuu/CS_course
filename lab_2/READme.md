# Мячин Валентин БАС-2 Лабораторная №6 (вариант 16)

# Задание 1

## Задача 1

### Текст задачи

<img width="470" height="18" alt="image" src="https://github.com/user-attachments/assets/b5bbe890-6614-4a23-ab8c-9429be771d14" />

<img width="303" height="16" alt="image" src="https://github.com/user-attachments/assets/bb571c7b-2a9e-48df-bc57-b3829977d314" />

### Алгоритм решения

Реализация:

class Input:
- bool InputBoolRU(string msg) - ввод да/нет

class VisitStat:
- int _id - id записи - ключ
- string _pageUrl - страница сайта, которую посещали
- DateTime _visitTime - дата посещения
- int _duration - длительность посещения страницы
- bool _isRegistered - зарегистрировал ли пользователь
- 2 конструктора: VisitStat() и VisitStat(int, string, DateTime, int, bool)
- свойства get, set для каждого поля
- перегруженный метод ToString()
- метод bool IsUrl(string) - простая проверка, является ли строка страницей сайта

class DatabaseHandler:
- void MakeStockBinFile() - создание тестового бинарного файла (на 6 записей) для проверки работы программы
- List<VisitStat> LoadFile(string path) - считывание бинарного файла в массив
- void UpdateDatabase(List<VisitStat>) - перезаписывание файла для случаев, если мы его изменяли
- void PrintDatabase(List<VisitStat>) - вывод массива в консоль
- void AddEntry(List<VisitStat>, string) - добавление записи в базу данных
- List<VisitStat> RemoveById(List<VisitStat>, string) - удаление записи по id
- List<VisitStat> GetLongVisits(List<VisitStat>) - возвращает выборку из базы записей, где посещение сайта (_duration) более 60 сек
- List<VisitStat> GetVisitsByUrl(List<VisitStat>, string url) - выборка посещений конкретной страницы сайта, с сортировкой по времени
- double GetAverageDuration(List<VisitStat>) - среднее посещение страниц (_duration) среди всех записей
- string GetMostVisitedPage(List<VisitData) - наиболее посещаемая страница

class Program:
- пользовательский интерфейс для удобной работы с программой

### Тестирование

<img width="471" height="475" alt="image" src="https://github.com/user-attachments/assets/5bd3c433-e358-4880-8adf-b25f9c626cb9" />

<img width="669" height="298" alt="image" src="https://github.com/user-attachments/assets/1a3a9de4-f400-45e8-adaa-2a907e2aac24" />

<img width="682" height="651" alt="image" src="https://github.com/user-attachments/assets/a8dc761d-480c-42b4-8126-77d20f8957f1" />

<img width="661" height="497" alt="image" src="https://github.com/user-attachments/assets/faf61bd1-a3be-4232-bf78-78cde892f2af" />

<img width="1156" height="517" alt="image" src="https://github.com/user-attachments/assets/e1ef57af-d78a-4197-b65e-23b8f724dfa2" />

