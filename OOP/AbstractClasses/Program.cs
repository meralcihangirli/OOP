using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{ //interface ile virtual methodların birleşimi gibi düşünebiliriz 
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }
    //abstract classlarda hem tamamlanmıs metot hem de tamamlanmamıs metot yapabiliyoruz
    //abstractlar newlenemez
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
