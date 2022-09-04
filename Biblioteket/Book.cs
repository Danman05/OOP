using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Book
    {
        // fields
        private string name;

        // properties
        public string Name { get { return name; }set { name = value; } }

        // Constructor
        public Book(string name)
        {
            this.name = name;
        }
    }
}
