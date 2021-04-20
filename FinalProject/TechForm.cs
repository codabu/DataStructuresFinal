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

            getAssigneeData();
            numberLabel.Text = tlist[current].Number.ToString();
            infoTb.Text = tlist[current].Info;
            getPriorityData(tlist[current].Priority);
            reporterTb.Text = tlist[current].Reporter;
        }

        private void getPriorityData (int priority)
        {
            switch (priority)
            {
                case 1: 
                    { 
                        priorityCombo.DataSource = new string[] { "High", "Medium", "Low" }; 
                        break; 
                    }
                case 2:
                    {
                        priorityCombo.DataSource = new string[] { "Medium", "High", "Low" }; 
                        break;
                    }
                case 3:
                    {
                        priorityCombo.DataSource = new string[] { "Low", "Medium", "High" };
                        break;
                    }
                default:
                    {
                        priorityCombo.DataSource = new string[] { "Low", "Medium", "High" };
                        break;
                    }
            }
        }

        private void setPriority(string selected)
        {
            switch (selected)
            {
                case "High":
                    {
                        tlist[current].Priority = 1;
                        break;
                    }
                case "Medium":
                    {
                        tlist[current].Priority = 2;
                        break;
                    }
                case "Low":
                    {
                        tlist[current].Priority = 3;
                        break;
                    }
            }
        }

        private void getAssigneeData()
        {
            string currentAssignee = tlist[current].Assignee;
            string [] temp = new string[] { "Corry", "Jarrod", "Alexis", "Unassigned"};

            List<string> data = new List<String>();
            data.Add(currentAssignee);
            foreach (string s in temp)
            {
                if (s!= currentAssignee)
                {
                    data.Add(s);
                }
            }
            assigneeCombo.DataSource = data;
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //allow editing of fields
            infoTb.ReadOnly = false;
            reporterTb.ReadOnly = false; 
            assigneeCombo.Enabled = true;
            priorityCombo.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            tlist[current].Info = infoTb.Text;
            tlist[current].Reporter = reporterTb.Text;
            tlist[current].Assignee = assigneeCombo.SelectedItem.ToString();
            setPriority(priorityCombo.SelectedItem.ToString());

            assigneeCombo.Enabled = false;
            priorityCombo.Enabled = false;
            infoTb.ReadOnly = true;
            reporterTb.ReadOnly = true;
            displayTicket();
        }
    }
}
