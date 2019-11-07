using Generics.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Samples.LinqSamples
{
    public class DataJoinLinq
    {
        private readonly List<Student> _students;
        private readonly List<Teacher> _teachers;

        public DataJoinLinq()
        {
            _students = SampleData.InitStudents();
            _teachers = SampleData.InitTeachers();
        }

        public void Run()
        {
            var peopleInSeattle = 
                (
                from student in _students
                where student.City == "Seattle"
                select student.Last
                )
                .Concat(
                    from teacher in _teachers
                    where teacher.City == "Seattle"
                    select teacher.Last
                );

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-> The following students and teachers live in Seattle:");
            // Execute the query.
            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine(person);
            }
        }
    }
}
