using MenuControlledApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIndex.Helpers
{
    public static class DataStorage
    {
        public static List<Person> personList { get; set; } = new List<Person>();

        private static string path = Path.GetFullPath(@"..\\..\\..\\PersonData.json");

        internal static void SaveData()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(personList);
            File.WriteAllText(path, json);
            Console.WriteLine("File saved succesfully at " + path);
        }

        internal static void AddData(string person)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(personList.ToList());
            //File.WriteAllText(path, json);
            File.AppendAllText(path, json);
            Console.WriteLine("names added succesfully at " + path);
        }

        internal static List<Person> LoadData()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Creating new file at: " + path);
                SaveData();
            }

            string json = File.ReadAllText(path);
            //TODO Does File Exists?

            var loadedListPerson = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(json);

            Console.WriteLine("File loaded succesfully from " + path);

            return loadedListPerson;

        }
    }
}
