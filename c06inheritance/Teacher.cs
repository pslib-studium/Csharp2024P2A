using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c06inheritance
{
    internal class Teacher: Human
    {
        public Teacher(
            string firstname, 
            string lastname, 
            string? title, 
            string approbation,
            int shoesize = 42,
            int height = 180
            ) : base(firstname, lastname, title, shoesize, height )
        {
            Firstname = firstname;
            Lastname = lastname;
            Title = title;
            Approbation = approbation;
        }

        public string Approbation { get; set; }
        public new string Name
        {
            get
            {
                return $"{base.Name} ({Approbation})";
            }
        }
    }
}
