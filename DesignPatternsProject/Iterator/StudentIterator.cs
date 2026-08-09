using DesignPatternsProject.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Iterator
{
    internal class StudentIterator : IIterator<Student>
    {
        private Student[] students;

        private int currentindex = 0;
        public StudentIterator(Student[] students)
        {
            this.students = students;
        }
        public bool HasNext()
        {
            return currentindex < students.Length;
        }

        public Student Next()
        {
            if(!HasNext())
            {
                throw new InvalidOperationException("No students left");
            }

            Student student = students[currentindex];
            currentindex++;
            return student;
        }
    }
}
