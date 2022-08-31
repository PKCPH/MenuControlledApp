using System;
using System.Collections.Generic;

namespace MenuControlledApp
{
    internal class Program
    {

        static List<string> nameList = new List<string>();

        static List<Person> personList = new List<Person>();

        static void Main(string[] args)
        {




            while (true)
            {
                displayMenu();
                string userInput = Console.ReadLine();
                if (userInput == "4")
                {
                    break;
                }
                if (userInput == "3")
                {
                    //Console.WriteLine("Du vil fjerne et navn");
                    deleteFromList();
                }
                if (userInput == "2")
                {
                    //Console.WriteLine("Vis navneliste");
                    showList();
                    Console.ReadKey();
                }
                if (userInput == "1")
                {
                    //Console.WriteLine("Tilføj navn");
                    addToList();
                }
            }

        }
        private static void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("Vælg fra menuen");
            Console.WriteLine("1: Tilføj navn");
            Console.WriteLine("2: Vis navne");
            Console.WriteLine("3: Fjern navn");
            Console.WriteLine("4: Afslut");
        }
        private static void addToList()
        {
            Console.WriteLine("Indtast et navn");
            string name = Console.ReadLine();
            Person person = new Person();
            person.setName(name);
            personList.Add(person);
            //nameList.Add(name);
        }
        private static void showList()
        {
            // for(int i = 0; i < nameList.Count; i++) {
            //     Console.WriteLine($"{i + 1} {nameList[i]}");
            // }
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {personList[i].getName()}");
            }
        }

        private static void deleteFromList()
        {
            Console.WriteLine("Indtaste nr på person");
            int pnr = Convert.ToInt32(Console.ReadLine());
            personList.RemoveAt(pnr - 1);
        }
    }
}
