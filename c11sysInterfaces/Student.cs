using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c11sysInterfaces
{
    internal class Student: IEquatable<Student>, IComparable<Student>
    {
        public Student(string firstName, string lastName, string studentID, double averageMark)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
            AverageMark = averageMark;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public double AverageMark { get; set; } = 5.0;

        public int CompareTo(Student? other) // -1 (this < other), 0 (this = other), 1 (this > other) 
        {
            //return this.AverageMark.CompareTo(other?.AverageMark);
            if (other == null) return 1;
            if (this.AverageMark == other.AverageMark) return 0;
            if (this.AverageMark < other.AverageMark) return -1;
            return 1;
        }

        public bool Equals(Student? other)
        {
            if (other is not null && this.FirstName == other.FirstName && this.LastName == other.LastName)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Student a, Student b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <(Student a, Student b)
        {
            return b.CompareTo(a) > 0;
        }
    }
}
