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
    /***************************************************************
    * Name        : TechForm
    * Author      : Corry Burton    
    * Created     : 04/12/2021
    ***************************************************************/
    


    public partial class TechForm : Form
    {
        //current keeps track of the current ticket
        public int current = 0;
        //form defautlts to displaying by ticket number (which utilizes the insertion sort)
        bool displayByNumber = true;
        //Field for the LinkedList
        public LinkedList ll { get; set; }
        //List object of tickets
        public List<Ticket> tlist;
        //Validate class
        public Validate validate { get; set; }
        
        //initialize priority queue object for sorting by priority
        PriorityQueue pq = new PriorityQueue();


        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: TechForm
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/
        public TechForm()
        {
            InitializeComponent();
        }

        /**************************************************************
        * Name: TechForm
        * Description: Constructor that accepts linked list
        * Input: LinkedList ll
        ***************************************************************/

        public TechForm(LinkedList ll)
        {
            InitializeComponent();
            //set the linked list field
            this.ll = ll;
            //set the validate class
            this.validate = new Validate();
        }

        public void setReporter(string input)
        {
            this.reporterTb.Text = input;
        }

        public string getReporter()
        {
            return this.reporterTb.Text;
        }

        public void setInfo(string input)
        {
            this.infoTb.Text = input;
        }

        public string getInfo()
        {
            return this.infoTb.Text;
        }

        public string getErrorLabel()
        {
            return this.errorLabel.Text;
        }

        public void setErrorLabel(string input)
        {
            this.errorLabel.Text = input;
        }

        /**************************************************************
        * Name: TechForm_Load
        * Description: Function that runs set up/reset of the form on load
        * Input: Form load event
        * Output: SwitchFilter function (displayByNumber is always true on load)
            the the displayTicket function to display the first ticket
        ***************************************************************/

        private void TechForm_Load(object sender, EventArgs e)
        {
            //run the switch filter function
            switchFilter();
            //display the first ticket
            displayTicket();
        }

        /**************************************************************
        * Name: nextBtn_Click
        * Description: Function for displaying the next ticket when next is clicked
        * Input: Click
        * Output: Increments current then displays the ticket
        ***************************************************************/
        private void nextBtn_Click(object sender, EventArgs e)
        {
            current++;
            displayTicket();
        }


        /**************************************************************
        * Name: prevBtn_Click
        * Description: Function for displaying the previous ticket when previous is clicked
        * Input: Click
        * Output: Decrements current then displays the ticket
        ***************************************************************/
        private void prevBtn_Click(object sender, EventArgs e)
        {
            current--;
            displayTicket();
        }

        /**************************************************************
        * Name: switchFilter
        * Description: Function for switching between displaying by 
        * ticket number or ticket priority (uses the priority queue)
        * Input: None
        * Output: Runs the insertionsort method on the linked list if sorting by ticket number
        * otherwise it adds the tickets in the linked list to a priority queue. Both options add the tickets
            to a list of tickets used to display and iterate through with prev and next buttons
        ***************************************************************/

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


        /**************************************************************
        * Name: displayTicket
        * Description: Displays the current ticket / its values
        * Input: None
        * Output: Hides/displays the prev next buttons as appropriate
        *  Populates the appropriate data in drop downs, and displays the current ticket
        *  information on the form
        ***************************************************************/
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

        /**************************************************************
        * Name: getPriorityData
        * Description: Returns the appropriate string order for priority dropdown in an array
        * Input: int priority
        * Output: string [] with proper order of priority strings
        ***************************************************************/

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

        /**************************************************************
        * Name: setPriority
        * Description: Function used upon saving to set priority int correctly based on the string from dropdown
        * Input: string selected
        * Output: tlist[current].Priority is assigned the correct int for priority
        ***************************************************************/

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

        /**************************************************************
        * Name: getAssigneeData
        * Description: Sets the source data for the assignee dropdown (where the current assignee is first)
        * Input: none
        * Output: assings the appropriate list of strings based on current assignee to the assigneCombo's DataSource property
        ***************************************************************/
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

        /**************************************************************
        * Name: filterCombo_SelectedIndexChanged
        * Description: Function that switches between filtering by priority and filtering 
        * by ticket number when the selected filter changes
        * Input: Changed filter combo box
        * Output: Sets the displayByNumber bool to correct value, resets current to 0 and 
        * then runs the switchFilter() and displayTicket() functions
        ***************************************************************/

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

        /**************************************************************
        * Name: TechForm_FormClosing_1
        * Description: Function that runs when the form is closed
        * Input: FormClosingEvent
        * Output: Assigns the linked list (which may have been updated) to the entry form's LL
        ***************************************************************/
        private void TechForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
                EntryForm.LL = ll;
        }

        /**************************************************************
        * Name: exitBtn_Click
        * Description: Function that closes the form when the exit button is clicked
        * Input: Exit button click event
        * Output: Closes the form
        ***************************************************************/
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**************************************************************
        * Name: editBtn_Click
        * Description: Edit button function enables user input/selection for changing the ticket
        * Input: Edit button click event
        * Output: Changes read only values for textboxes to false and enabled values for combos to false
        ***************************************************************/
        private void editBtn_Click(object sender, EventArgs e)
        {
            //allow editing of fields
            infoTb.ReadOnly = false;
            reporterTb.ReadOnly = false; 
            assigneeCombo.Enabled = true;
            priorityCombo.Enabled = true;
        }

        /**************************************************************
        * Name: saveBtn_Click
        * Description: Save button function that updates/saves the current ticket when clicked
        * Input: Save button click event
        * Output: assigns the current ticket with the appropriate values from the form
        *   disables user input for the ticket and redisplays the saved ticket
        ***************************************************************/
        private void saveBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (validate.CheckInput(reporterTb.Text, infoTb.Text) == "")
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

            else { errorLabel.Text = validate.CheckInput(reporterTb.Text, infoTb.Text); }
        }
    }
}
