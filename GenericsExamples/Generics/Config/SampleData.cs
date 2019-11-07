using System;
using System.Collections.Generic;

namespace Generics.Config
{
    public static class SampleData
    {
        public static Customer InitCustomer()
        {
            return new Customer
            {
                Id = 1,
                Email = "therealaegon@gmail.com",
                Location = "Knight's watch",
                Name = "Jon Snow"
            };
        }

        public static List<Customer> InitCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Email = "therealaegon@gmail.com",
                    Location = "Knight's watch",
                    Name = "Jon Snow"
                },
                new Customer
                {
                    Id = 2,
                    Email = "sansa.stark@gmail.com",
                    Location = "Winterfell",
                    Name = "Sans Stark",
                    Phone = "025548877"
                },
                new Customer
                {
                    Id = 3,
                    Location = "Dragon's Stone",
                    Name = "Millisandei"
                },
                new Customer
                {
                    Id = 4,
                    Location = "North of the Wall",
                    Name = "Bran the 3 eyed raven",
                    Email = "N/A",
                    Phone = "N/A"
                },
                new Customer
                {
                    Id = 5,
                    Location = "Old Town",
                    Name = "Ser Jorah Mormont",
                    Email = "danny4ever@gmail.com",
                    Phone = "N/A"
                }
            };
        }

        public static Transaction InitTransaction()
        {
            return new Transaction
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Price = 99.9,
                Tax = 21.9,
                Quantity = 2
            };
        }

        public static List<Student> InitStudents()
        {
            return new List<Student>()
            { 
                new Student 
                { 
                    First="Svetlana",
                    Last="Omelchenko",
                    ID=111,
                    Street="123 Main Street",
                    City="Seattle",
                    Scores= new List<int> { 97, 92, 81, 60 } 
                },
                new Student 
                { 
                    First="Claire",
                    Last="O’Donnell",
                    ID=112,
                    Street="124 Main Street",
                    City="Redmond",
                    Scores= new List<int> { 75, 84, 91, 39 } 
                },
                new Student 
                { 
                    First="Sven",
                    Last="Mortensen",
                    ID=113,
                    Street="125 Main Street",
                    City="Lake City",
                    Scores= new List<int> { 88, 94, 65, 91 } 
                },
            };
        }

        public static List<Teacher> InitTeachers()
        {
            return new List<Teacher>()
            {
                new Teacher 
                { 
                    First="Ann", 
                    Last="Beebe", 
                    ID=945, 
                    City="Seattle" 
                },
                new Teacher 
                { 
                    First="Alex", 
                    Last="Robinson", 
                    ID=956, 
                    City="Redmond" 
                },
                new Teacher 
                { 
                    First="Michiyo", 
                    Last="Sato", 
                    ID=972, 
                    City="Tacoma" 
                }
            };
        }
    }
}
