using System;
using System.Collections.Generic;
using System.Text;

namespace MenuControlledApp
{
    internal class Person
    {
        private string name;
        public string test = "Dingdong";

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}
