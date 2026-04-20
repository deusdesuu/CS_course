/*
 * Очередная задачка про студента.
 * 2 переменные: есть ли долги? Сделана ли флюрография?
 * not(A + B)
 * проверять данные на корректность
 * 
 * Student()
 * Student(имя, курс)
 * Student(имя, курс, долги, флюр)
 * 
 */
using System;


namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            uint n = Input.InputUInt("Введите кол-во студентов: ");
            string name;
            string buffer;
            uint course;
            bool debt;
            bool flurOld;
            bool f;
            List<Student> students = [];

            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine("Студент " + i + ":");
                Console.Write("Введите имя (-, если нет): ");
                name = Console.ReadLine();
                if (name == "-")
                {
                    students.Add(new Student());
                    continue;
                }
                course = Input.InputUInt("Введите курс: ");
                Console.Write("Есть ли у вас данные по задолженностям и флюрографии? (+/-): ");
                buffer = Console.ReadLine();
                if (buffer == "-")
                {
                    students.Add(new Student(name, course));
                    continue;
                }
                else if (buffer == "+")
                {
                    debt = Input.InputBool("Введите наличие задолженностей и устарела ли флюрография (true|false):\n");
                    flurOld = Input.InputBool("");
                    students.Add(new Student(name, course, debt, flurOld));
                }
            }
            Console.WriteLine("\nИтоговый список студентов:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nПроверим всех студентов:");
            foreach(Student student in students)
            {
                student.Check();
            }

            Console.WriteLine("\nПопробуем перевести всех на следующий курс:");
            foreach(Student student in students)
            {
                f = student.Promote();
                if (f)
                {
                    Console.WriteLine(student.FullName + " перешел на следующий курс.");
                }
                else
                {
                    Console.WriteLine(student.FullName + " не перешел на следующий курс.");
                }
            }
        }
    }
}
/*
    Test:
    Введите кол-во студентов: 3
    Студент 1:
    Введите имя (-, если нет): -
    Студент 2:
    Введите имя (-, если нет): John Pork
    Введите курс: 3
    Есть ли у вас данные по задолженностям и флюрографии? (+/-): -
    Студент 3:
    Введите имя (-, если нет): Maksim Boltun
    Введите курс: 1
    Есть ли у вас данные по задолженностям и флюрографии? (+/-): +
    Введите наличие задолженностей и устарела ли флюрография (true|false):
    true
    true

    Итоговый список студентов:
    ФИО: Иванов Иван Иванович
    Курс: 1
    Задолженности по учебе: Нет
    Флюрография просрочена: Нет

    ФИО: John Pork
    Курс: 3
    Задолженности по учебе: Нет
    Флюрография просрочена: Нет

    ФИО: Maksim Boltun
    Курс: 1
    Задолженности по учебе: Есть
    Флюрография просрочена: Да


    Проверим всех студентов:
    Студент Иванов Иван Иванович чист.
    Студент John Pork чист.
    У студента Maksim Boltun есть долги по учебе и не сдана флюрография.ОТЧИСЛИТЬ!!!

    Попробуем перевести всех на следующий курс:
    Иванов Иван Иванович перешел на следующий курс.
    John Pork перешел на следующий курс.
    Maksim Boltun не перешел на следующий курс.
  */