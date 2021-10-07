using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortedListDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Student> mySortedList = new SortedList<int, Student>();

            while (true)
            {
                Console.WriteLine("Want to add new memeber ? Press Y for Yes");
                ConsoleKeyInfo rKey = Console.ReadKey();
                if (rKey.Key == ConsoleKey.Y)
                {
                    OperationsOnSortedList newExample = new OperationsOnSortedList();
                    newExample.AddMember(mySortedList);

                    Console.WriteLine("Wanna sort descending? Press N to sort by name, S by surname, ans A by Age");
                    ConsoleKeyInfo rrKey = Console.ReadKey();
                    switch(rrKey.Key)
                    {
                        case ConsoleKey.N : 
                        case ConsoleKey.S :
                        case ConsoleKey.A :




                    }
                    if (rrKey.Key == ConsoleKey.S)
                    {
                        newExample.Order(mySortedList);
                    }

                }
               

            }

        }

        internal class OperationsOnSortedList
        {
            public void AddMember(SortedList<int, Student> list)
            {
                Student novicheokTMvector = new Student();
                Console.WriteLine("Enter name");
                novicheokTMvector.Name = Console.ReadLine();
                Console.WriteLine("Enter surname");
                novicheokTMvector.Surname = Console.ReadLine();
                Console.WriteLine("Enter Age");
                novicheokTMvector.Age = (int)Console.Read(); Console.WriteLine();

                list.Add(list.Count + 1, novicheokTMvector);
            }            


            private void Order<studentPropertyType>(SortedList<int, Student> list)
            {
                /*
                Type refType = studentField.GetType();
                studValueType = studentField.GetType();
                TypeCode xtype = Type.GetTypeCode(refType);
                */

                SortedList<object, Student> newQQQ =
                    (SortedList<object, Student>)list.Cast<SortedList<object, Student>>().OrderByDescending(x => x.Values);

                

                for (int i = 0; i < list.Count()-1; i++ )
                {
                    object stValue = list.Values[i].Age;
                    newQQQ.Add(list.Values[i].Age, list.Values[i]);


                }

                SortedList<int, Student> newOrderedDescendingSortedList =
                    (SortedList<int, Student>)list.Cast<SortedList<int, Student>>().OrderByDescending(x => x.Values);


                SortedList<int, Student> newOrderedSortedList = 
                    (SortedList<int, Student>)list.Cast<SortedList<int, Student>>().OrderBy(x => x.Values);


                Console.WriteLine("key:  value: ");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("{0}: {1}:", list., list.GetByIndex(i));
                }               
            }

        }

        internal class Student
        {
            public string Name;
            public string Surname;
            public int Age;
        }
        

    }
}
