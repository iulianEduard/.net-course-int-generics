using Generics.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Samples.LinqSamples
{
    public class GenericTypeLinq
    {
        private readonly List<Customer> _customers;

        public GenericTypeLinq()
        {
            _customers = SampleData.InitCustomers();
        }

        public void Run()
        {
            var customersWithEmail =
                from customer in _customers
                where !string.IsNullOrEmpty(customer.Email)
                select customer;

            Console.WriteLine("-> Customers with email:");
            PrintCustomers(customersWithEmail);

            var customersWithEmailAndPhone =
                from customer in _customers
                where !string.IsNullOrEmpty(customer.Email) && !string.IsNullOrEmpty(customer.Phone)
                select customer;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-> Customers with email and phone:");
            PrintCustomers(customersWithEmailAndPhone);

            var customersOrderedByLocation =
                from customer in _customers
                orderby customer.Location ascending
                select customer;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-> Customers orderd by location ascending:");
            PrintCustomers(customersOrderedByLocation);

            var customersGroupedByLocation =
                from customer in _customers
                group customer by customer.Location;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-> Customers grouped by location:");
            foreach(var customerGroup in customersGroupedByLocation)
            {
                Console.WriteLine($"---> {customerGroup.Key}");
                PrintCustomers(customerGroup);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-> Customers with no emails in new projections(new types)");
            CustomersWithNewProjections();
        }

        private void PrintCustomers(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"--> {customer.ToString()}");
            }
        }

        private void CustomersWithNewProjections()
        {
            var customersWithNoEmail =
                from customer in _customers
                where string.IsNullOrEmpty(customer.Email)
                select new
                {
                    Id = customer.Id,
                    Name = customer.Name
                };

            foreach(var customer in customersWithNoEmail)
            {
                Console.WriteLine($"--> Id: {customer.Id}, Name: {customer.Name}");
            }
        }
    }
}
