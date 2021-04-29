using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /***************************************************************
    * Name        : Ticket
    * Author      : Corry Burton
    * Created     : 4/12/2021
    ***************************************************************/
    


    public class Ticket
    {
        //private fields
        private int _number;
        private string _info;
        private int _priority;
        private string _reporter;
        private string _assignee;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: Ticket
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/

        public Ticket()
        {

        }

        /**************************************************************
        * Name: Ticket
        * Description: Constructor that accepts all fields
        * Input: int number, string info, int priority, string reporter
        ***************************************************************/


        public Ticket(int number, string info, int priority, string reporter)
        {
            _number = number;
            _info = info;
            _priority = priority;
            _reporter = reporter;
            _assignee = "Unassigned";
        }


        //Public properties
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


        /***************************************************************
        * Class Functions
        ***************************************************************/
        /**************************************************************
        * Name: DisplayTicket
        * Description: Simple function that just returns the ticket for display purposes
        * Input: None
        * Output: Returns the ticket
        ***************************************************************/

        public Ticket DisplayTicket()
        {
            return this;
        }
    }
}
