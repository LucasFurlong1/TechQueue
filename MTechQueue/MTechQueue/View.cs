using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTechQueue
{
    public partial class viewForm : Form
    {
        numberForm number = new numberForm();
        public viewForm()
        {
            InitializeComponent();
            number.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (Program.queue.Count == 0)
            {
                firstBox.Clear();
                lastBox.Clear();
                ticketBox.Clear();
                idBox.Clear();
                this.TopMost = true;
                MessageBox.Show("Queue is empty", "Horray!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                number.numlabText = "Queue is Empty.\nWelcome to the MTech Desk!";
            }
            else
            {
                Person person = Program.queue.Dequeue();
                firstBox.Text = person.First;
                lastBox.Text = person.Last;
                issueBox.Text = person.Issue;
                idBox.Text = person.Emplid.ToString();
                ticketBox.Text = person.Ticket;
                number.numlabText = $"{person.First} {person.Last}";
            }
        }
    }
}
