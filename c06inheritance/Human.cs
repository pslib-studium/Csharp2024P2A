using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c06inheritance
{
    internal class Human
    {
        public Human(string firstname, string lastname, string? title, int shoesize, int height)
        {
            Firstname = firstname;
            Lastname = lastname;
            Title = title;
            ShoeSize = shoesize;
            Height = height;
        }

        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string? Title { get; set; }
        public int ShoeSize { get; set; }
        public int Height { get; set; }
        public string Name {
            get { if (Title is not null) 
                    return $"{Title} {Firstname} {Lastname} [{ShoeSize},{Height}]";
                  else
                    return $"{Firstname} {Lastname} [{ShoeSize},{Height}]";
            }
        }
    }
}
