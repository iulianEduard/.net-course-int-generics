using Generics.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Generics.Samples.LinqSamples
{
    public class DataTransformationLinq
    {
        private readonly List<Customer> _customers;

        public DataTransformationLinq()
        {
            _customers = SampleData.InitCustomers();
        }

        public void Run()
        {
            var customerToXml = new XElement("Root",
                from customer in _customers
                select new XElement("Customer",
                    new XElement("Id", customer.Id),
                    new XElement("Name", customer.Name),
                    new XElement("Location", customer.Location),
                    new XElement("Phone", customer.Phone),
                    new XElement("Email", customer.Email)
                    )
                );

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--> Customers to XML");
            Console.WriteLine(customerToXml);
        }
    }
}
