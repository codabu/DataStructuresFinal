using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /**************************************************************
    * Name        : Final Project - Ticketing System    
    * Author      : Corry Burton    
    * Created     : 04/12/2021
    * Course      : CIS 152 - Data Structures
    * Version     : 1.0
    * OS          : Windows 10
    * Copyright   : This is my own original work based on
    *               specifications issued by our instructor
    * Description : This program overall description here
    *               Input:  Users can add tickets to an IT ticketing system
    *                       IT employees can edit tickets/assign them
    *               Output: Tickets displayed to Employees
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or 
    * unmodified. I have not given other fellow student(s) access to
    * my program.         
    ***************************************************************/


    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Startup adds a few tickets to the system for demonstration purposes
            LinkedList LL = new LinkedList(1000);
            Ticket ticket1 = new Ticket(1000, "My computer won't start up properly. After turning it on a blue screen comes up.", 1, "Jane Smith");
            Ticket ticket2 = new Ticket(1001, "My monitor is not working properly. Occasionally it will flicker, and there is a line across the screen.", 2, "Rob Johnston");
            Ticket ticket3 = new Ticket(1002, "My computer is very slow. Opening more than one or two programs makes it unusable", 1, "Bob Smith");
            Ticket ticket4 = new Ticket(1003, "After running for a while, the computer makes a loud buzzing sound which never happened before.", 3, "Kylee Jones");
            Ticket ticket5 = new Ticket(1004, "The tab button on my keyboard is sticking. Could I please have a replacement keyboard?", 3, "Lou D'Jorne");
            LL.addLast(ticket1);
            LL.addLast(ticket2);
            LL.addLast(ticket3);
            LL.addLast(ticket4);
            LL.addLast(ticket5);

            //LinkedList is passed to the EntryForm
            Application.Run(new EntryForm(LL));
        }

    }
}
