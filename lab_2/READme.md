# Мячин Валентин БАС-2 Лабораторная №6 (вариант 16)

# Задание 1

## Задача 1

### Текст задачи

<img width="470" height="18" alt="image" src="https://github.com/user-attachments/assets/b5bbe890-6614-4a23-ab8c-9429be771d14" />


### Алгоритм решения

Реализация:

class File:
- Random _rnd - поле Random
- static File() - инициализация _rnd
- void MakeFile1(uint, string) - создает текстовый файл, заполненный случайными числами [-500_000; +500_000]
- void Task1(int, string, string) - создает новый текстовый файл, на основе исходного, уменьшая каждое значение в k раз

class Input:
- int InputInt(string) - ввод целого числа из консоли, с проверкой

### Тестирование

<img width="461" height="473" alt="image" src="https://github.com/user-attachments/assets/2dcd0a33-8234-4eda-b21b-357c9de26450" />


## Задача 2

### Текст задачи

<img width="354" height="18" alt="image" src="https://github.com/user-attachments/assets/79b855fa-77a8-4ee7-8a13-07edc8a84c37" />

### Алгоритм решения

class File:
- void MakeFile2(uint, uint, string) - создает файл с матрицей случайных чисел [-500_000; +500_000]
- int Task2(string) - считывает файл, находит первый и максимальный элементы и возвращает их сумму


### Тестирование

Скриншоты результата работы программы

<img width="530" height="283" alt="image" src="https://github.com/user-attachments/assets/70112179-339e-4f50-bef8-525c161e812f" />

## Задача 3

### Текст задачи

<img width="615" height="32" alt="image" src="https://github.com/user-attachments/assets/8c1822db-1221-474c-b562-c7d9c1fffdbe" />

### Алгоритм решения

class File:
- void MakeFile3(string) - создает файл из 33 строк, в каждой из которых по 100 строчных символов русского алфавита
- void Task3(string, string) - считывает исходный текстовый файл и переписывает в новый строки, в которых 1-ый или 2-ой символ 'б'


### Тестирование

<img width="1280" height="608" alt="image" src="https://github.com/user-attachments/assets/fcb8460e-3c31-43cc-907d-972686958494" />

## Задача 4

### Текст задачи

<img width="646" height="40" alt="image" src="https://github.com/user-attachments/assets/45136afe-3230-4c2c-8313-6b730491efc0" />


### Алгоритм решения

class File:
- void MakeFile4(uint, string) - создает бинарный файл из случайных int32 чисел [-500_000; +500_000]
- void Task4(string, string) - считывает бинарный файл, проверяет числа через CheckNum(), и переписывает подходящие в результирующий бинарный файл
- bool CheckNum(int) - проверяет что число начинается и заканчивается на одну и ту же цифру


### Тестирование

<img width="1012" height="576" alt="image" src="https://github.com/user-attachments/assets/03ac4600-8171-45a7-9412-650c7ceb6bc8" />

# Задание 2

## Задача 6

### Текст задачи

<img width="420" height="18" alt="image" src="https://github.com/user-attachments/assets/8a1b84a4-e365-43b5-bc94-bc620324dff9" />

### Алгоритм решения

class Structures:
- Random _rnd - поле Random
- static Structures() - инициализация _rnd
- List<int> MakeListInt(uint) - создает List<int> со случайными значениями [-500; 500]
- List<int> Task6(List<int>) - создает новый массив, в котором элементы из данного повторяются дважды
- string ListIntToString(List<int>) - преобразует массив в строку для вывода


### Тестирование

<img width="696" height="122" alt="image" src="https://github.com/user-attachments/assets/1a08fb6c-741d-4d81-a352-2b10b21c9723" />

## Задача 7

### Текст задачи

<img width="598" height="15" alt="image" src="https://github.com/user-attachments/assets/d0d4624c-360b-49e7-883c-0f87302b761b" />


### Алгоритм решения

class Structures:
- LinkedList<int> MakeLinkedListInt(uint) - создает список, заполненный случайными значениями [-500; 500]
- string LinkedListToString(LinkedList<int>) - преобразует список в строку для вывода
- LinkedList<int> Task7(LinkedList<int>) - находит максимальное и минимальное значения в списке, меняет местами элементы между ними


### Тестирование

<img width="480" height="152" alt="image" src="https://github.com/user-attachments/assets/71b26cab-185a-40b6-9a6e-7b9d074ecc2f" />

## Задача 10

### Текст задачи

<img width="651" height="389" alt="image" src="https://github.com/user-attachments/assets/e733ecbd-e2a5-4d79-807b-2f18d3cd874e" />



### Алгоритм решения

class Structures:
- KeyValuePair<int, SortedList<int, int>> ReadFile(string) - считывает файл, возвращает данные в виде пары

  <
  
  кол-во элементов в списке
  
  SortedList<
  
    кол-во баллов,
  
    сколько учеников набрало этот балл>
  
  >
  
- int Task10(KeyValuePair<int, SortedList<int, int>>) - набирает студентов на отметку "отлично" под условие 20%,
                                                        проверяя все входные условия, выдает минимальный балл на "отлично"


### Тестирование

<img width="340" height="40" alt="image" src="https://github.com/user-attachments/assets/c2b4a7cf-0ef4-4379-88ea-6549092e4b0f" />






