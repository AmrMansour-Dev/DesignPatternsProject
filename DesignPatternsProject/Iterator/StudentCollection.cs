using DesignPatternsProject.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Iterator
{
    internal class StudentCollection : IStudentCollection
    {
        private Student[] students;

        public StudentCollection()
        {
            students = new Student[]
            {
                new Student(name:"Amr"),
                new Student(name:"Sayed"),
                new Student(name:"Samo")
            };
        }

        public IIterator<Student> CreateIterator()
        {
            return new StudentIterator(students); 
        }
    }
}
