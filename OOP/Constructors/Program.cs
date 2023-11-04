using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.List();

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 100;

            Utilities.Validate();
          Manager.DoSomething();
            Manager manager1 = new Manager();
            manager1.DoSomething2();


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 5;
        public CustomerManager(int count)
        {
            _count = count;
        }

        //constructor overloading
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class EmployeeManager
    {
        public ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }


        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0}", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
    //static olan class newlenemez ve olusturulan nesne tum projede o isimle çalıştırılır
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("something is done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("static something is done");
        }
    }
}
