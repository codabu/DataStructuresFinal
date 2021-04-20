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
    public partial class EntryForm : Form
    {
        public static LinkedList LL { get; set; }

        public EntryForm()
        {
            InitializeComponent();
        }

        public EntryForm(LinkedList ll)
        {
            InitializeComponent();
            LL = ll;
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            LogTicket newForm = new LogTicket(LL);
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void techBtn_Click(object sender, EventArgs e)
        {
            TechForm newForm = new TechForm(LL);
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
