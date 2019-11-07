using System;

namespace Generics.Config
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }

        public double Total { get; set; }
    }
}
