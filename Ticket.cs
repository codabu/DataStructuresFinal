using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Ticket
    {
        private int _number;
        private string _info;
        private int _priority;
        private string _reporter;
        private string _assignee;

        public Ticket()
        {

        }

        public Ticket(int number, string info, int priority, string reporter, string assignee)
        {
            _number = number;
            _info = info;
            _priority = priority;
            _reporter = reporter;
            _assignee = assignee;
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        public string Reporter
        {
            get { return _reporter; }
            set { _reporter = value; }
        }

        public string Assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }

        public Ticket DisplayTicket()
        {
            return this;
        }
    }
}
