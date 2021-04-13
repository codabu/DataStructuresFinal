using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            LinkedList LL = new LinkedList(10);
            Ticket ticket1 = new Ticket(1000, "Computer is broke", 2, "User 1", "Unassigned");
            Ticket ticket2 = new Ticket(1001, "Monitor not working", 1, "Rob Johnston", "Unassigned");
            Ticket ticket3 = new Ticket(1003, "Won't turn on", 3, "Bob Smith", "Unassigned");
            Ticket ticket4 = new Ticket(1002, "Makes loud noises", 2, "Kylee Jones", "Unassigned");
            Ticket ticket5 = new Ticket(1004, "Internet not working", 3, "Aria Stark", "Unassigned");
            LL.addLast(ticket1);
            LL.addLast(ticket2);
            LL.addLast(ticket3);
            LL.addLast(ticket4);
            LL.addLast(ticket5);

            Application.Run(new EntryForm(LL));
        }

    }
}
