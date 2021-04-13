using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class TechForm : Form
    {
        public TechForm()
        {
            InitializeComponent();
        }

        public TechForm(LinkedList ll)
        {
            InitializeComponent();
        }

        private void TechForm_Load(object sender, EventArgs e)
        {
            //Believe I can add the below LinkedList as static on Program or EntryFormLoad to then access acrross the forms

            LinkedList ll = new LinkedList(10);
            Ticket ticket1 = new Ticket(1000, "Computer is broke", 2, "User 1", "Unassigned");
            ll.addLast(ticket1);
            List<Ticket> tlist = ll.display();
            int current = 0;
            numberLabel.Text = tlist[current].Number.ToString();
            infoLabel.Text = tlist[current].Info;
            priorityLabel.Text = tlist[current].Priority.ToString();
            reporterLabel.Text = tlist[current].Reporter;
            assigneeLabel.Text = tlist[current].Assignee;
        }

    }
}
