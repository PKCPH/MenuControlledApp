using MenuControlledApp;
using PersonIndex.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIndex.Helpers
{
    public class ListEditor
    {
        internal static void Search()
        {
            Console.WriteLine("Search for name: ");
            var searchInput = Console.ReadLine();

            if (DataStorage.personList.Count == 0) Console.WriteLine("There are no names added to the database");

            foreach (var person in DataStorage.personList)
            {
                if (person.getName().Contains(searchInput))
                {
                    Console.WriteLine($"Results for {searchInput}: ");
                    Console.WriteLine(person.name);
                }
                else
                {

                }
            }

            Console.ReadKey();

        }

        internal static void addToList()
        {
            Console.WriteLine("Indtast et navn");
            string name = Console.ReadLine();
            Person person = new Person();
            person.setName(name);
            DataStorage.personList.Add(person);
            DataStorage.AddData(person.name);

            
            //nameList.Add(name);
        }
        internal static void ShowList(List<Person> dataList)
        {
            // for(int i = 0; i < nameList.Count; i++) {
            //     Console.WriteLine($"{i + 1} {nameList[i]}");
            // }
            //for (int i = 0; i < DataStorage.personList.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1} {DataStorage.personList[i].getName()}");
            //}

            foreach (var person in dataList) Console.WriteLine($"{person.name}"); ;

        }

        internal static void DeleteFromList()
        {
            Console.WriteLine("Indtaste nr på person");
            int pnr = Convert.ToInt32(Console.ReadLine());
            DataStorage.personList.RemoveAt(pnr - 1);
        }
    }
}
