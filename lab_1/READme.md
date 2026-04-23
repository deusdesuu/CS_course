# Мячин Валентин БАС-2 Лабораторная №6 (вариант 16)

# Задание 1

## Задача 1

### Текст задачи

<img width="805" height="118" alt="image" src="https://github.com/user-attachments/assets/eb4ca28c-be35-430a-848f-f400ccd28834" />

### Алгоритм решения

Реализация:

class Status:
- 2 логических поля: наличие долгов и статус флюрографии (true - устарела)
- метод Check() на отрицание дизъюнкции полей false + false -> true
  для проверки что студент не имеет задолженностей
- 3 конструктора:
  - пустой -> false, false
  - копирования
  - bool, bool
- перегрузка метода ToString() для вывода

class Student:Status:
- поля string _fullName и uint course
- конструкторы:
  - пустой
  - fullName, course
  - fullName, course, debt, flurOld
- перегрузка метода ToString() для вывода
- метод Check() на проверку задолженностей
- метод Promote() - попытаться перевести студента на следующий курс

class Input:
- класс для проверки ввода
- InputUint() - ввод беззнакового целого числа, с проверкой
- InputBool() - ввод логического значения, с проверкой

### Тестирование

<img width="639" height="713" alt="image" src="https://github.com/user-attachments/assets/ab307aa7-a85d-4dc2-85ae-c4d0ba0639bf" />

## Задача 2

### Текст задачи

<img width="795" height="80" alt="image" src="https://github.com/user-attachments/assets/3b42512c-c0de-4145-ab32-0b2e23076061" />

<img width="802" height="79" alt="image" src="https://github.com/user-attachments/assets/af7e0731-f0eb-454b-9eb5-b3df002301b3" />


### Алгоритм решения

class LineSegment:
- double _x, double _y
- 3 конструктора:
  - пустой -> (0, 0)
  - double -> (x, x) (точка)
  - double, double -> (x, y) || (y , x) (в зависимости от меньшей)
- перегрузка ToString()
- Min(double, double), Max(double, double) (чтобы не подключать Math)
- Intersection() -> пересечение двух отрезков -> LineSegment || null

class Input:
- InputDouble() - ввод double числа, с проверкой

### Тестирование

Скриншоты результата работы программы

<img width="608" height="477" alt="image" src="https://github.com/user-attachments/assets/d5c0bc78-469a-4c7f-972b-07133ef9e7c3" />


## Задача 3

### Текст задачи

<img width="786" height="37" alt="image" src="https://github.com/user-attachments/assets/86769a8d-27a4-4684-bd15-2f8e479c8ebe" />

<img width="807" height="257" alt="image" src="https://github.com/user-attachments/assets/8ad0aee5-34ea-4216-9900-525970f72a75" />


### Алгоритм решения

Реализация:
<img width="436" height="117" alt="image" src="https://github.com/user-attachments/assets/a63d70a6-5d76-4228-b237-b078407d8c88" />
- implicit operator int(LineSegment) -> int
- explicit operator double(LineSegment) -> double
- operator + (LineSegment, int) -> [x + value; y]
- operator + (int, LineSegment) -> [x; y + valuej]
- operator > (LineSegment, LineSegment) -> проверка вхождения второго отрезка в первый
- operator < (LineSegment, LineSegment) -> проверка вхождения первого отрезка во второй


### Тестирование 
<img width="351" height="497" alt="image" src="https://github.com/user-attachments/assets/2f27dd41-7a63-47c5-b73b-f98bd61a8fd9" />



