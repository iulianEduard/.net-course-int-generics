using System.Collections.Generic;

namespace Generics.Config
{
    public class Student
    {
        public string First { get; set; }

        public string Last { get; set; }

        public int ID { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public List<int> Scores { get; set; }
    }
}
