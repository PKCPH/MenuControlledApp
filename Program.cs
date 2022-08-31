using Microsoft.VisualBasic;
using PersonIndex.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace MenuControlledApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                
                Menu.DisplayMenu();
            }
            catch (Exception e)
            {
                //DataHelpers.SaveData();
                Console.WriteLine(e); ;
            }
        }

    }
}
