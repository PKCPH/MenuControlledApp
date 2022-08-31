using System;
using System.Collections.Generic;
using System.Text;

namespace MenuControlledApp
{
    public class Person
    {
        public string name { get; set; }
        

        //default constructor
        public Person() { }

        //constructor
        public Person(string name)
        {

            this.name = name;

        }


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
