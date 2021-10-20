using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortedListDescending
{
    class SortedListDescending
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            SetOperations operations = new SetOperations();

            Console.WriteLine("Want to begin with demonstratively prepopulated list of students? Press P if Yes");
            ConsoleKeyInfo dKey = Console.ReadKey();

            if (dKey.Key == ConsoleKey.P)
            {
                studentList = new List<Student>(); Student stud;
                stud = new Student(); stud.Name = "Ivan"; stud.Surname = "Susanin"; stud.Age = 155; studentList.Add(stud);
                stud = new Student(); stud.Name = "Diego"; stud.Surname = "Maradonchik"; stud.Age = 78; studentList.Add(stud);
                stud = new Student(); stud.Name = "Vasea"; stud.Surname = "Kolupanov"; stud.Age = 22; studentList.Add(stud);
                stud = new Student(); stud.Name = "John"; stud.Surname = "Doe2"; stud.Age = 66; studentList.Add(stud);

                Console.WriteLine("Wanna sort descending? Press N to sort by name, S by surname, and A by Age");
                ConsoleKeyInfo rrKey = Console.ReadKey();
                operations.SortMembers(studentList, rrKey);
            }
            else
            {
                studentList = new List<Student>();
                while (true)
                {
                    Console.WriteLine("Want to add new memeber to be sorted by his personal info ? Press Y for Yes");
                    ConsoleKeyInfo rKey = Console.ReadKey();
                    if (rKey.Key == ConsoleKey.Y)
                    {
                        operations.AddMember(studentList);
                    }
                    else
                    {
                        Console.WriteLine("Wanna sort descending? Press N to sort by name, S by surname, and A by Age");
                        ConsoleKeyInfo rrKey = Console.ReadKey();
                        operations.SortMembers(studentList, rrKey);
                    }
                }
            }
        }

        internal class SetOperations
        {
            public void AddMember(List<Student> list)
            {
                Student novicheok = new Student();
                Console.WriteLine("Enter name");
                novicheok.Name = Console.ReadLine();
                Console.WriteLine("Enter surname");
                novicheok.Surname = Console.ReadLine();
                Console.WriteLine("Enter Age");
                novicheok.Age = Console.Read(); Console.WriteLine();

                list.Add(novicheok);
            }


            public void SortMembers(List<Student> list, ConsoleKeyInfo info)
            {
                switch (info.Key)
                {/*
                    case ConsoleKey.N:
                        {
                            PopulateList(list);
                            SortList(list, "Name");
                            return;
                        }
                    case ConsoleKey.S:
                        {
                            PopulateList(list);
                            SortList(list, "Surname");
                            return; 
                        }  */
                    case ConsoleKey.A:
                        {                            
                           
                            StudentByAgeDescending comparer = new StudentByAgeDescending();
                            SortedList<int, Student> students = new SortedList<int, Student>(comparer);
                            foreach (var stud in list)
                            {
                                students.Add(stud.Age, stud);
                            }


                            Console.WriteLine("  " + "Students' Age" + "  " + "Students' Name" + "  " + "Students' Surname" + "  ");
                            foreach (var stud in students)
                            {
                                Console.WriteLine("  " + stud.Key/* + "  " + stud.Value.Name + "  " + stud.Value.Surname + "  "*/);
                            }
                            Console.ReadLine();

                            return;
                        }
                }
            }            
        }


        internal class StudentByAgeDescending: IComparer<int>
        {

            public int Compare(int studA_Age, int studB_Age)
            {
                return studB_Age.CompareTo(studA_Age);
            }
        }


        public class Student
        {
            public int Age;
            public string Name;
            public string Surname;
        }        

    }
}
