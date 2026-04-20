using System;

namespace ConsoleApp1
{
    internal class Student : Status
    {
        private string _fullName;
        private uint _course;

        public Student() : base()
        {
            this._fullName = "Иванов Иван Иванович";
            this._course = 1;
        }

        public Student(string fullName, uint course) : base()
        {
            this._fullName = fullName;
            this._course = course;
        }

        public Student(string fullName, uint course, bool debt,
            bool flurOld) : base(debt, flurOld)
        {
            this._fullName = fullName;
            this._course = course;
        }

        public string FullName
        {
            get { return this._fullName; }
            set { this._fullName = value; }
        }

        public uint Course
        {
            get { return this._course; }
            set { this._course = value; }
        }

        public override string ToString()
        {
            return "ФИО: " + this._fullName +
                   "\nКурс: " + this._course +
                   "\n" + base.ToString() + '\n';
        }

        public bool Check()
        {
            if (base.Check())
            {
                Console.WriteLine("Студент " + this._fullName + " чист.");
                return true;
            }
            else if (base.Debt)
            {
                if (base.FlurOld)
                {
                    Console.WriteLine("У студента " + this._fullName +
                                      " есть долги по учебе и не сдана флюрография." +
                                      "ОТЧИСЛИТЬ!!!");
                }
                else
                {
                    Console.WriteLine("У студента " + this._fullName +
                                      " есть долги по учебе.");
                }
            }
            else if (base.FlurOld)
            {
                Console.WriteLine("У студента " + this._fullName +
                                  " не сдана флюрография.");
            }

            return false;
        }
        public bool Promote()
        {
            if (base.Check())
            {
                ++this._course;
                return true;
            }
            else { return false; }
        }
    }
}