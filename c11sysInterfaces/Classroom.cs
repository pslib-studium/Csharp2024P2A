using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c11sysInterfaces
{
    internal class Classroom : IEnumerable<Student>
    {
        public Classroom(string classname, Student[] students)
        {
            Classname = classname;
            Students = students;
        }

        public string Classname { get; set; }
        private Student[] Students { get; set; }

        public IEnumerator<Student> GetEnumerator()
        {
            return ((IEnumerable<Student>)Students).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
