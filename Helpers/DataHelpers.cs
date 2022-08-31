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
        internal static List<Person> personList = new List<Person>();

        private static string path = Path.GetFullPath(@"..\\..\\PersonData.json");

        internal static void SaveData()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(personList);
            File.WriteAllText(path, json);
            Console.WriteLine("File saved succesfully at " + path);
        }

        internal static void LoadData()
        {
            string json = File.ReadAllText(path);
            //TODO Does File Exists?
            System.Text.Json.JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine("File loaded succesfully from " + path);
        }
    }
}
