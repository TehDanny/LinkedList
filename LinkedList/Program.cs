using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Daniel", 27);
            Person p2 = new Person("Bobby", 3);
            Person p3 = new Person("John", 80);

            LList l = new LinkedListPerson();
            l.Add(p1);
            l.Add(p2);
            l.Add(p3);
        }
    }
}
