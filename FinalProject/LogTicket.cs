using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /***************************************************************
    * Name        : LogTicket
    * Author      : Corry Burton    
    * Created     : 04/12/2021
    ***************************************************************/


    public partial class LogTicket : Form
    {
        //fields - LL to hold the Linked List and newNumber to hold the next ticket number
        public LinkedList LL { get; set; }
        public int newNumber;
        public Validate validate { get; set; }

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: LogTicket
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/

        public LogTicket()
        {
            InitializeComponent();
        }


        /**************************************************************
        * Name: LogTicket
        * Description: Constructor that accepts LinkedList
        * Input: LinkedList LL
        ***************************************************************/

        public LogTicket(LinkedList ll)
        {
            InitializeComponent();
            LL = ll;
            validate = new Validate();
        }


        /***************************************************************
        * Class Functions
        ***************************************************************/
        /**************************************************************
        * Name: LogTicket_Load
        * Description: The load function for this form
        * Input: object sender, EventArgs e
        * Output: Performs an insertion, gets the new ticket's ticket number
        *         and displays the ticket number for the to-be-created ticket
        ***************************************************************/

        private void LogTicket_Load(object sender, EventArgs e)
        {
            LL.insertionSort();
            newNumber = LL.lastNumber() + 1;
            numDisplayLabel.Text = newNumber.ToString();
        }

        /**************************************************************
        * Name: submitBtn_Click
        * Description: The submit button function
        * Input: object sender, EventArgs e
        * Output: Resets errorLabel. If input is valid, it creates a new ticket,
        *         adds the ticket to the linked list, and then displays a message box
        *         informing the user the ticket has been created, and closes the form
        ***************************************************************/

        private void submitBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (validate.CheckInput(reporterTb.Text, infoTb.Text) == "")
            {
                Ticket newTicket = new Ticket(newNumber, infoTb.Text, (getPriority(priorityBox.Text)), reporterTb.Text);
                LL.addLast(newTicket);
                errorLabel.Text = "";
                MessageBox.Show("Ticket " + newTicket.Number + " submitted" + System.Environment.NewLine + "Someone will be in touch to assist you at our earliest convenience.");
                this.Close();
            }

            else { errorLabel.Text = validate.CheckInput(reporterTb.Text, infoTb.Text); }
        }


        /**************************************************************
        * Name: getPriority
        * Description: Function that returns the correct int based on 
          the fixed string values that can be provided by the dropdown for priority
        * Input: string text
        * Output: int between 1 and 3, 1 being highest priority, 2 being medium and 3 being lowest
        ***************************************************************/
        private int getPriority(string text)
        {
            switch (text)
            {
                case "Low":
                    return 3;
                case "Medium":
                    return 2;
                case "High":
                    return 1;
                default:
                    return 3;
            }
        }

        /**************************************************************
        * Name: checkInput
        * Description: Boolean function that validates input and sets the errorlabel message/s 
        * Input: None
        * Output: true if valid, otherwise sets the errorLabel text based on the input/s and returns false
        ***************************************************************/
        public bool checkInput()
        {
            bool output = true;
            Regex regex = new Regex("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");

            if (infoTb.TextLength < 25)
            {
                errorLabel.Text += "Please enter more information about the issue" + Environment.NewLine;
                output = false;
            }

            if (reporterTb.TextLength < 3)
            {
                errorLabel.Text += "Please enter a name" + Environment.NewLine;
                output = false;
            } 

            if (!regex.IsMatch(reporterTb.Text))
            {
                errorLabel.Text += "Please enter a valid name" + Environment.NewLine;
                output = false;
            }

            return output;
        }

        /**************************************************************
        * Name: LogTicket_FormClosing
        * Description: Function that runs on form close
        * Input: object sender, FormClosingEventArgs e
        * Output: Sets the LinkedList in the EntryForm to the LinkedList here 
        * (which may have been updated with a new ticket)
        ***************************************************************/

        private void LogTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            EntryForm.LL = LL;
        }

        /**************************************************************
        * Name: clearBtn_Click
        * Description: Function that clears inputs
        * Input: object sender, FormClosingEventArgs e
        * Output: Clears/resets the input fields that are available to the user
        ***************************************************************/

        private void clearBtn_Click(object sender, EventArgs e)
        {
            infoTb.Text = "";
            reporterTb.Text = "";
            priorityBox.SelectedIndex = -1;
        }


        /**************************************************************
        * Name: exitBtn_Click
        * Description: Function that closes the form
        * Input: object sender, FormClosingEventArgs e
        * Output: Closes the form when user clicks the exit button
        ***************************************************************/
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**************************************************************
        * Name: reporterTb_TextChanged
        * Description: Function that resets the error label when
        * user changes input in the reporter text box
        * Input: object sender, FormClosingEventArgs e
        * Output: Resets the errorLabel
        ***************************************************************/
        private void reporterTb_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
