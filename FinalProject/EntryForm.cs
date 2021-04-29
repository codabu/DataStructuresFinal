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
    * Name        : EntryForm
    * Author      : Corry Burton
    * Created     : 04/12/2021
    ***************************************************************/


    public partial class EntryForm : Form
    {
        //public static field LinkedList for the entry form
        public static LinkedList LL { get; set; }

        /**************************************************************
        * Name: EntryForm
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/

        public EntryForm()
        {
            InitializeComponent();
        }

        /**************************************************************
        * Name: EntryForm
        * Description: Constructor that accepts the Linked List parameter
        * Input: LinkedList ll
        ***************************************************************/

        public EntryForm(LinkedList ll)
        {
            InitializeComponent();
            //set the form's LinkedList to the provided LinkedList from program.cs
            LL = ll;
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        /**************************************************************
        * Name: logBtn_Click
        * Description: function for when the button to log a new ticket is clicked
        * Input: object sender, EventArgs e
        * Output: a new LogTicket form using the LinkedList LL as an argument
        *         hides the current form, displays the new form
        ***************************************************************/


        private void logBtn_Click(object sender, EventArgs e)
        {
            LogTicket newForm = new LogTicket(LL);
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        /**************************************************************
        * Name: techBtn_Click
        * Description: function for when the button to go to the IT section is clicked
        * Input: object sender, EventArgs e
        * Output: a new TechForm form using the LinkedList LL as an argument
        *         hides the current form, displays the new form
        ***************************************************************/

        private void techBtn_Click(object sender, EventArgs e)
        {
            TechForm newForm = new TechForm(LL);
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        /**************************************************************
        * Name: exitBtn_Click
        * Description: Exit button function
        * Input: object sender, EventArgs e
        * Output: Exits the program (because this is the parent form)
        ***************************************************************/

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
