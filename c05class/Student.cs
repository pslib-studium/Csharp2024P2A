using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c05class
{
    // zapoudření - encapsulation
    class Student
    {
        private string _firstName = "Alfons"; // datový člen, attribute, field
        private string _lastName = "Vopička"; // private members starts with _
        private string something = default;

        // property
        public string FirstName
        {
            get { return _firstName; }
            set { if (value != "Elon") _firstName = value; }
        }

        // konstruktor = constructor
        public Student(string firstName, string lastName)
        {
            //this.firstName = firstName; // this = instance of this class
            //this.lastName = lastName;
            _firstName = firstName;
            _lastName = lastName;
        }
        // bezparametrický konstruktor
        // přetížené konstrukrory - overloaded constructors
        public Student()
        {
            _firstName = "Bruce";
            _lastName = "Wayne";
        }

        public string GetFirstName()
        {
            return _firstName;
        }
        public string GetLastName() {
            return _lastName;
        }
        public void SetFirstName(string newFirstName)
        {
            if (newFirstName != "Elon") _firstName = newFirstName;
        }
        public void SetLastName(string newLastName)
        {
            if (newLastName != "Musk") _lastName = newLastName;
        }
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
