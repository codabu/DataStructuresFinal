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
    public partial class LogTicket : Form
    {
        public LinkedList LL { get; set; }
        public int newNumber;

        public LogTicket()
        {
            InitializeComponent();
        }

        public LogTicket(LinkedList ll)
        {
            InitializeComponent();
            LL = ll;
        }

        private void LogTicket_Load(object sender, EventArgs e)
        {
            LL.insertionSort();
            newNumber = LL.lastNumber() + 1;
            numDisplayLabel.Text = newNumber.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            if (checkInput())
            {
                Ticket newTicket = new Ticket(newNumber, infoTb.Text, (getPriority(priorityBox.Text)), reporterTb.Text);
                LL.addLast(newTicket);
                errorLabel.Text = "";
                MessageBox.Show("Ticket " + newTicket.Number + " submitted" + System.Environment.NewLine + "Someone will be in touch to assist you at our earliest convenience.");
                this.Close();
            }
        }

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

        private bool checkInput()
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

        private void LogTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            EntryForm.LL = LL;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            infoTb.Text = "";
            reporterTb.Text = "";
            priorityBox.SelectedIndex = -1;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporterTb_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
