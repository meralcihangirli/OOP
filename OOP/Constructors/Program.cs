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

            EmployeeManager employeeManager =new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

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
}
