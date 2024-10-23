using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            set { if (value != "Elon") _firstName = value; }
            get { return _firstName; }        
        }
        [Required] // anotace
        public string ClassName { get; set; } = "1A";
        public string Name
        {
            get {
                return _firstName + " " + _lastName;
            } // lze jen číst
        }
        public int Age { get; private set; } // lze měnit jen z vnitřku třídy
        public string FullName => _firstName + " " + _lastName;
        public int ShoeSize { get; init; } = 42; // init = jen při inicializaci
        public int MyProperty { get; set; } // prop<tab><tab> = property

        // konstruktor = constructor
        public Student(string firstName, string lastName = "Smith")
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
            // return Student ...
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

        public void SetAge(int age) // polymorfismus - přetížení metody
        {
            if (age > 0 && age < 120) Age = age;
        }

        public void SetAge(string age)
        {
            if (int.TryParse(age, out int a))
            {
                SetAge(a);
            }
        }

        public int GetAge() // polymorfismus - přetížení metody
        {
            return Age;
        }

    }
}
