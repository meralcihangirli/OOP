using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        //INTERFACES
        static void Main(string[] args)
        {
            //InterfacesIntro();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //Customer newlenip bunu add içinde de çağırabilirdik
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "NewCustomerName",
            //    LastName = "NewCustomerSurName",
            //    Adress = "Antalya"
            //};
            //manager.Add(customer);

            manager.Add(new Customer
            {
                Id = 1,
                FirstName = "NewCustomerName",
                LastName = "NewCustomerSurName",
                Adress = "Antalya"
            });

            Student student = new Student
            {
                Id = 1,
                FirstName = "NewStudentFirstName",
                LastName = "NewStudentLastName",
                Department = "Computer Programming"
            };

            manager.Add(student);
        }

        //interface soyut nesnedir.Asagidaki classlar somut nesnelerdir
        //interface icinde bulunan özellik public ile başlamaz
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        //classa implement edilen özellikler public ile başlamalı
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        //class PersonManager
        //{ //Add içine IPerson gönderirsen Customer haricinde implement edilen tüm classlara ulaşabilirsin
        //    public void Add(Customer customer)
        //    {
        //        Console.WriteLine(customer.FirstName);
        //        Console.WriteLine(customer.LastName);
        //        Console.WriteLine(customer.Adress);
        //    }
        //}

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
               

            }
        }

    }
}
