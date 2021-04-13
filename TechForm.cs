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
        
        public int current = 0;
        bool displayByNumber = true;
        public LinkedList ll { get; set; }
        public List<Ticket> tlist;
        


        //Believe I can add the below LinkedList as static on Program or EntryFormLoad to then access acrross the forms

        //LinkedList ll = new LinkedList(10);
        
        PriorityQueue pq = new PriorityQueue();


        public TechForm()
        {
            InitializeComponent();
        }

        public TechForm(LinkedList ll)
        {
            InitializeComponent();
            this.ll = ll;
        }

        private void TechForm_Load(object sender, EventArgs e)
        {
            switchFilter();
            displayTicket();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            current++;
            displayTicket();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            current--;
            displayTicket();
        }

        public void switchFilter()
        {
            
            if (displayByNumber == false)
            {
                tlist = ll.display();
                //set up the priority queue
                pq = new PriorityQueue();
                foreach (Ticket t in tlist)
                {
                    pq.Enqueue(t);
                }
                tlist = pq.getLL().display();
            }

            else {
                ll.insertionSort();
                tlist = ll.display();
            }
            
        }

        private void displayTicket ()
        {
            
            //prevent previous button from being pressed if at start of list
            if (current == 0)
            {
                prevBtn.Visible = false;
            }
            else { prevBtn.Visible = true; }
            //prevent next button from being pressed if at end of list
            if (current == tlist.Count - 1)
            {
                nextBtn.Visible = false;
            }
            else { nextBtn.Visible = true; }

            numberLabel.Text = tlist[current].Number.ToString();
            infoTb.Text = tlist[current].Info;
            priorityLabel.Text = getPriority(tlist[current].Priority);
            reporterLabel.Text = tlist[current].Reporter;
            assigneeLabel.Text = tlist[current].Assignee;
        }

        private string getPriority (int priority)
        {
            switch (priority)
            {
                case 1: return "High";
                case 2: return "Medium";
                case 3: return "Low";
                default: return "Low";
            }
        }

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            if (filterCombo.SelectedIndex == 0)
            {
                displayByNumber = true;
                current = 0;
                switchFilter();
                displayTicket();
            }

            else if (filterCombo.SelectedIndex == 1)
            {
                displayByNumber = false;
                current = 0;
                switchFilter();
                displayTicket();
            }
        }


        private void TechForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
                EntryForm.LL = ll;
        }

        private void assigneeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string assignee = assigneeBox.SelectedItem.ToString();
            tlist[current].Assignee = assignee;
            displayTicket();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
