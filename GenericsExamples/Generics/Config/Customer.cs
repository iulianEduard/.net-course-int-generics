﻿namespace Generics.Config
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"Id: #{Id}, Name: {Name}, Location: {Location}, Phone: {Phone}, Email: {Email}";
        }
    }
}
