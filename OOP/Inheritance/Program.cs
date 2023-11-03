using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer{FirstName="Eda"},new Student{FirstName="Meral" }, new Person{FirstName="Burak"}
            };
            foreach (Person person in persons) 
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer :Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }


}
