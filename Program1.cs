using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Student
    {
        public string Name;
        public int Group;
        public int[] Ses;

        public Student(string Name, int Group, int[] Ses)
        {
            this.Name = Name;
            this.Group = Group;
            this.Ses = Ses;
        }
        public void WriteStudent()
        {
            Console.WriteLine("Фамилия и инициалы: {0}, Номер группы:{1}", Name, Group);
        }
        public bool GoodStud(int[] Ses)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Ses[i] < 4)
                    return false;
            }
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество анкет: ");
            int k = int.Parse(Console.ReadLine());
            if (k <= 0)
            {
                Console.WriteLine("Программа не может быть выполнена");
                return;
            }
            Student[] Students = new Student[k];
            for (int i = 0; i < k; i++)
            {
                var student = new Student();
                Console.Write("Имя: ");
                student.Name = Console.ReadLine();

                Console.Write("Группа: ");
                student.Group = int.Parse(Console.ReadLine());
                student.Ses = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Оценки {0}: ", j + 1);
                    student.Ses[j] = int.Parse(Console.ReadLine());
                }
                Students[i] = student;
                Console.WriteLine();
            }
            Console.WriteLine("Студенты имеющиее 4 и 5:");
            int a = 0;
            foreach (var student in Students)
            {
               if (student.GoodStud(student.Ses))
                    {
                    student.WriteStudent();
                    a++;
                    }
             }
            if (a == 0)
                Console.WriteLine("Таких студентов нет");
               
            Console.ReadKey();
        }
    }
}