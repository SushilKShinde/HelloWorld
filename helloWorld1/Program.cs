using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wolrd!");
            Console.WriteLine("Adding new line from remote");
            Console.WriteLine("Modification in Local");
            Console.WriteLine("Adding new line from remote");
            Console.WriteLine("Modified in Remote");
            Console.ReadKey();

            Person person = new Person();
            // displaying message on screen
            Console.WriteLine("Enter person name: ");
            // reading the input from user
            person.name = Console.ReadLine();
            Console.WriteLine("Enter person height: ");
            person.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter person weight: ");
            person.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter person age: ");
            person.age = Convert.ToInt32(Console.ReadLine());
            person.Speak();
            person.PersonDetails(person.name, person.height, person.weight, person.age);
            Console.ReadLine();
        }
    }
}
