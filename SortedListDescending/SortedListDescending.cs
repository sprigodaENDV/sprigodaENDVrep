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
            ConcreteOperationsOnSortedList newExample = new ConcreteOperationsOnSortedList();

            Console.WriteLine("Want to begin with demonstratively prepopulated list of students? Press P if Yes");
            ConsoleKeyInfo dKey = Console.ReadKey();
            
            if (dKey.Key == ConsoleKey.P)
            {
                studentList = new List<Student>();   Student stud;
                stud = new Student();   stud.Add("Name", "Ivan");  stud.Add("Surname", "Susanin");  stud.Add("Age", 155);
                stud = new Student(); stud.Add("Name", "Diego"); stud.Add("Surname", "Maradonchik"); stud.Add("Age", 78);
                stud = new Student(); stud.Add("Name", "Vasea"); stud.Add("Surname", "Kolupanov"); stud.Add("Age", 22);
                stud = new Student(); stud.Add("Name", "John"); stud.Add("Surname", "Doe2"); stud.Add("Age", 66);

                Console.WriteLine("Wanna sort descending? Press N to sort by name, S by surname, and A by Age");
                ConsoleKeyInfo rrKey = Console.ReadKey();
                newExample.SortMembers(studentList, rrKey);
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
                        newExample.AddMember(studentList);
                    }
                    else 
                    {
                        Console.WriteLine("Wanna sort descending? Press N to sort by name, S by surname, and A by Age");
                        ConsoleKeyInfo rrKey = Console.ReadKey();
                        newExample.SortMembers(studentList, rrKey);
                    }
                }
            }
        }

        internal class ConcreteOperationsOnSortedList : AbstractOperationsOnSortedList
        {
            protected internal override void AddMember(List<Student> list)
            {
                base.AddMember(list); 
            }

            protected internal override void SortMembers(List<Student> list, ConsoleKeyInfo info)
            {
                base.SortMembers(list, info);
            }

            protected internal override void DemonstrateResults()
            {
                base.DemonstrateResults();
            }
        }

        internal abstract class AbstractOperationsOnSortedList
        {
            protected internal virtual void  AddMember(List<Student> list)
            {
                Student novicheok = new Student();
                Console.WriteLine("Enter name");
                novicheok.Add("Name", Console.ReadLine());
                Console.WriteLine("Enter surname");
                novicheok.Add("Surname", Console.ReadLine());
                Console.WriteLine("Enter Age");
                novicheok.Add("Age", (int)Console.Read()); Console.WriteLine();

                list.Add(novicheok);
            }


            protected internal virtual void SortMembers(List<Student> list, ConsoleKeyInfo info)
            {
                switch (info.Key)
                {
                    case ConsoleKey.N:
                        {
                            this.DemonstrateSortedList<string>(
                            this.SortListAlreadyCreated<string>(
                            this.PopulateListToSort<string>(list, "Name")));
                            return;
                        }
                    case ConsoleKey.S:
                        {
                            this.DemonstrateSortedList<string>(
                            this.SortListAlreadyCreated<string>(
                            this.PopulateListToSort<string>(list, "Surname")));
                            return;
                        }
                    case ConsoleKey.A:
                        {
                            this.DemonstrateSortedList<int>(
                            this.SortListAlreadyCreated<int>(
                            this.PopulateListToSort<int>(list, "Age")));
                            return;
                        }
                }
            }



            protected internal virtual void DemonstrateResults()
            { 

            }



            private SortedList<Student, studentPropertyType> PopulateListToSort<studentPropertyType>(List<Student> list, string fieldName)
            {
                SortedList<Student, studentPropertyType> listToSort = new SortedList<Student, studentPropertyType>(); 
                foreach (var stud in list)
                {
                    object field = null;
                    bool ifGotValue = stud.TryGetValue(fieldName, out field);
                    Type tip = field.GetType();
                    listToSort.Add(stud, (studentPropertyType)field);
                }
                return listToSort;
            }




            private SortedList<Student, studentPropertyType> SortListAlreadyCreated<studentPropertyType>(SortedList<Student, studentPropertyType> list)
            { /*
                SortedList<Student, studentPropertyType> listAlreadySorted = (SortedList<Student, studentPropertyType>)list.
                                                                             Cast<SortedList<Student, studentPropertyType>>().
                                                                             OrderByDescending(x => x.Values);
               
                SortedList<Student, studentPropertyType> listAlreadySorted = (SortedList<Student, studentPropertyType>)list.
                                                                             Cast<SortedList<Student, studentPropertyType>>().
                                                                             OrderBy(x => x.Values);
                */
                SortedList<Student, studentPropertyType> listAlreadySorted = (SortedList<Student, studentPropertyType>)list.Cast<SortedList<Student, studentPropertyType>>().
                                                                            OrderByDescending(x => x.Values);

                return listAlreadySorted;
            }


            protected internal void DemonstrateSortedList<studentPropertyType>(SortedList<Student, studentPropertyType> list)
            {
                foreach(var stud in list.Keys)
                {
                    bool l = false;
                    studentPropertyType value;
                    l = list.TryGetValue(stud, out value);
                    Console.Write(value);  Console.WriteLine(); Console.WriteLine("The end of program");
                }
            }

        }

        internal class Student : Dictionary<string, object>
        {
        }
        

    }
}
