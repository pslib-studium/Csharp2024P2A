using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c06inheritance
{
    internal class Student: Human
    {
        public Student(
            string firstname, 
            string lastname, 
            string? title, 
            string classname = "P2A",
            int shoesize = 36,
            int height = 160
            ): base(firstname, lastname, title, shoesize, height  )
        {
            Classname = classname;
        }

        public string Classname { get; set; }
        public new string Name
        {
            get
            {
                return $"{base.Name} ({Classname})";
            }
        }
    }
}
