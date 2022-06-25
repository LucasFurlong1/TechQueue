using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechQueue
{
    class Person
    {
        private string first;
        private string last;
        private int emplid;
        private string issue;
        private string ticket;
        private string number;

        public Person(string first, string last, int emplid, string issue, string ticket, string number)
        {
            First = first;
            Last = last;
            Emplid = emplid;
            Issue = issue;
            Ticket = ticket;
            Number = number;
        }
        public string First { get { return first; } set { first = value; } }
        public string Last { get { return last; } set { last = value; } }
        public int Emplid { get { return emplid; } set { emplid = value; } }
        public string Issue { get { return issue; } set { issue = value; } }
        public string Ticket { get { return ticket; } set { ticket = value; } }
        public string Number { get { return number; } set { number = value; } }

    }
}
