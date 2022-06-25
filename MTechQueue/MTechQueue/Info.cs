using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextmagicRest;
using TextmagicRest.Model;

namespace MTechQueue
{
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewForm view = new viewForm();
            view.Show();
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            int emplid;
            bool isNumber = int.TryParse(idBox.Text, out emplid);
            if (isNumber != true)
            {
                idBox.Text = "ID must be a number";
            }
            else if(String.IsNullOrEmpty(firstBox.Text)||String.IsNullOrEmpty(lastBox.Text)||String.IsNullOrEmpty(issueBox.Text)){
                if (String.IsNullOrEmpty(firstBox.Text))
                {
                    MessageBox.Show("Must have first name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (String.IsNullOrEmpty(lastBox.Text))
                {
                    MessageBox.Show("Must have last name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (String.IsNullOrEmpty(issueBox.Text))
                {
                    MessageBox.Show("Must have issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Person person = new Person(firstBox.Text, lastBox.Text, emplid, issueBox.Text, ticketBox.Text, numberBox.Text);
                Program.queue.Enqueue(person);
                firstBox.Clear();
                lastBox.Clear();
                idBox.Clear();
                issueBox.Clear();
                ticketBox.Clear();
                MessageBox.Show("You have been placed in the queue!", "Congrats!", MessageBoxButtons.OK);
                Client client = new Client("username", "account code");
                SendingResult link = client.SendMessage("You have now been placed in the queue!", numberBox.Text);
                if (link.Success)
                {
                    MessageBox.Show($"Message {link.Id} has been sent", "Text Sent!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Message {link.Id} has not been sent... Sorry!", "Text Not Sent!", MessageBoxButtons.OK);
                }
            }
        }

    }
}
