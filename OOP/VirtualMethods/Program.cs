using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();
            sqlServer.Add();
            sqlServer.Delete();
            mySql.Add();
            mySql.Delete();

            Console.ReadLine();

        }
    }
    //virtual-override metodları kullanıldıgında metodda bulunan default degeri ezer ve kendi metodunun içindeki değeri getirir
    //virtual yapılan classın tek metoduna yazmak yeterlidir.Override yapan extend aldıgı dıger classın tum metodlarına ulasabılecektır 
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Default by added");
        }
        public void Delete()
        {
            Console.WriteLine("Default by Deleted");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Sql by Added!!");
            //base.Add();
        }
    }

    class MySql : Database
    {

    }
}
