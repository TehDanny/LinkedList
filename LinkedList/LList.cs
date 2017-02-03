using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LList
    {
        private LinkedListPerson firstElement;
        internal void Add(Person person)
        {
            LinkedListPerson llp = new LinkedListPerson();
            llp.Data = person;
            llp.Next = firstElement;
            firstElement = llp;
        }
    }
}
