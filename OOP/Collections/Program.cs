using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {//arraylistte tip güvenli calısılmadı yanı add olarak ne tur versek lısteye eklemıs oldu
         // ArrayList();

            // List();
            Dictionary<string,string> dictionary=new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]); 

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.WriteLine(dictionary.ContainsValue("glass"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Agrı");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "Meral" });
            //customers.Add(new Customer { Id = 2, Name = "Zorro" });

            List<Customer> customers = new List<Customer>
            {
             new Customer { Id = 1, Name = "Meral" },
             new Customer { Id = 2, Name = "Zeynep" }
        };

            var customer2 = new Customer
            {
                Id = 3,
                Name = "Ayse"
            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
                {
                new Customer { Id = 4, Name = "Ali" },
                new Customer { Id = 5, Name = "Ahmet" }
            });

            Console.WriteLine(customers.Contains(customer2));

            // customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            customers.Insert(0, customer2);

            customers.Remove(customer2);
            customers.Remove(customer2);
            customers.Remove(customer2);

            customers.RemoveAll(c => c.Name == "Ali");



            // clear tüm eleman sayısını sıfırlar
            //count eleman sayısını adet olarak verir
            //contains list içinde istenilen var mı yok mu ona gore true false doner
            //IndexOf elemanın kacıncı sırada oldugunu bulur
            //lastindexoff sondan baslar
            //insert kacıncı sıraya ne eklemek ıstıyorsak 
            //remove gönderilen değeri ilk buldugunu siler
            //removeall verilen tüm değerleri siler



            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            var count = customers.Count();
            Console.WriteLine("Count :{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList citiess = new ArrayList();
            citiess.Add("ankara");
            citiess.Add("istanbul");

            citiess.Add("adana");
            citiess.Add(1);
            citiess.Add('c');

            foreach (var city in citiess)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
