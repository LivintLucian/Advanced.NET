using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();

            Console.ReadKey();
        }

        static void TestPerson()
        {
            using (Model2Container context = new Model2Container())
            {
                Person p = new Person()
                {
                    FirstName = "Julie",
                    LastName = "Andrew",
                    MidleNale = "T",
                    TelephonNumber = "1234567890"
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        static void TestOneToMany()
        {
            Console.WriteLine("One to many association");
            using (Model2Container context = new Model2Container())
            {
                Customer c = new Customer()
                {
                    Name = "Customer1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c

                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();

                var items = context.Customers;
                foreach(var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                        x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                            ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }
    }
}