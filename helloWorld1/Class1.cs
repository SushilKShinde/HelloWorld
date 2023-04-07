using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld1
{
    public class Person
    {
       // instance variables 
        public string name;
        public float weight, height;
        public int age;

        // method 1
        public void Speak()
        {
            Console.WriteLine("Person can talk");
        }

        public void PersonDetails(string personName, float personHeight, float personWeight, int personAge)
        {
            Console.WriteLine("Person Details as: personName: {0}, personHeight: {1}, personWeight: {2}, personAge: {3}", personName, personHeight, personWeight, personAge);
        }
    }
}
