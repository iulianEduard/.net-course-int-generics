using Generics.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Samples.BuildInGenericsSamples
{
    public class GenericList
    {
        private List<Customer> Customers { get; set; }

        public GenericList()
        {
            Fill();
        }

        public void Run()
        {
            WhereExample();

            CountExample();

            OrderByExample();

            SelectAndFirstOrDefaultExample();

            WhereAndFirstOrDefaultExample();

            WhereAndSelectExample();

            RemoveExample();
        }

        private void Fill()
        {
            Customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Jon",
                    Location = "King's Landing",
                    Email = "ruler4ever@gmail.com"
                },

                new Customer
                {
                    Id = 2,
                    Name = "Sansa",
                    Location = "Winterfell",
                    Phone = "0756 8965312"
                },

                new Customer
                {
                    Id = 3,
                    Name = "Jaime",
                    Location = "King's Landing"
                }
            };
        }

        private void WhereExample()
        {
            var filteredCustomers = Customers.Where(c => c.Location.ToLower().Contains("winterfell"));

            Console.WriteLine("-> Customers in Winterfell:");
            foreach(var customer in filteredCustomers)
            {
                Console.WriteLine($"--> Name: {customer.Name}");
            }
        }

        private void CountExample()
        {
            var numberOfCustomers = Customers.Count;

            Console.WriteLine($"-> Number of customers: {numberOfCustomers}");
        }

        private void OrderByExample()
        {
            var orderedCustomers = Customers.OrderBy(c => c.Location);

            Console.WriteLine("-> Order customers by location");
            foreach (var customer in orderedCustomers)
            {
                Console.WriteLine($"--> {customer.ToString()}");
            }
        }

        private void SelectAndFirstOrDefaultExample()
        {
            var customer = Customers.Select(c => c.Location == "Winterfell").FirstOrDefault();

            Console.WriteLine("-> First customer located in Winterfell");
            Console.WriteLine(customer.ToString());
        }

        private void WhereAndFirstOrDefaultExample()
        {
            var customer = Customers.Where(c => string.IsNullOrEmpty(c.Phone)).FirstOrDefault();

            Console.WriteLine("-> First customer with valid Phone");
            Console.WriteLine(customer.ToString());
        }

        private void WhereAndSelectExample()
        {
            var customers = Customers.Where(c => !string.IsNullOrEmpty(c.Phone))
                .Select(c => new { c.Id, c.Name });

            Console.WriteLine("-> Customers with valid Phone");
            foreach(var customer in customers)
            {
                Console.WriteLine($"--> Id: {customer.Id}, Name: {customer.Name}");
            }
        }

        private void RemoveExample()
        {
            Console.WriteLine("-> Remove first customer");
            Customers.Remove(Customers[0]);
            PrintCustomers();

            Console.WriteLine("-> Remove customers with empty phone");
            Customers.RemoveAll(c => string.IsNullOrEmpty(c.Phone));
            PrintCustomers();
        }

        private void PrintCustomers()
        {
            Console.WriteLine("Print customers");
            foreach(var customer in Customers)
            {
                Console.WriteLine($"--> {customer.ToString()}");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}
