using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListPerson // could be <T> instead of Person
    {
        public Person Data { get; set; } // could be T instead of Person
        public LinkedListPerson Next { get; set; } // could be <T> instead of Person
    }
}
