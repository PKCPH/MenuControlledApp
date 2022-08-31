using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIndex.Helpers
{
    public static class Menu
    {
        internal static void DisplayMenu()
        {
            var dataList = DataStorage.LoadData();

            bool continueInMenu = true;
            while (continueInMenu)
            {
                Console.Clear();
                Console.WriteLine("Vælg fra menuen");
                Console.WriteLine("1: Søg");
                Console.WriteLine("2: Tilføj navn");
                Console.WriteLine("3: Vis navne");
                Console.WriteLine("4: Fjern navn");
                Console.WriteLine("5: Afslut");

                switch (Console.ReadLine())
                {
                    case "1":
                        ListEditor.Search();
                        break;
                    case "2":
                        ListEditor.addToList();
                        Console.ReadKey();
                        break;
                    case "3":
                        ListEditor.ShowList(dataList);
                        Console.ReadKey();
                        break;
                    case "4":
                        ListEditor.DeleteFromList();
                        break;
                    case "5":
                        continueInMenu = false;
                        DataStorage.SaveData();
                        break;
                    default:
                        continueInMenu = false;
                        //DataHelpers.SaveData();
                        break;
                }
            }
        }

    }
}
