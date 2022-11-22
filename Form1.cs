using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilburyLab2
//Name: Aaron Milbury
//Date: October 6th
{
    public partial class FrmLab2 : Form
    {
        public FrmLab2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This is to close the form
            this.Close();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            //This is to reveal the picture
            pbMountain.Show();
            //This is to hide the label on top of the picture box
            lblDescription.Hide();
            //This is to create a message box and show it
            string message = "This picture is of me and some of my friends. We were on the way to Grosmorne National park, " +
                "where we would hike many trails.";
            string title = "Aaron Milbury";
            //This is to show the message box
            MessageBox.Show(message, title);

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //This is to display the description of my hobbyy
            lblDescription.Show();
            
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //This is to hide the picture box
            pbMountain.Hide();
            //This hides the description label
            lblDescription.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //This is to get rid of text in the textboxes
            txtNumber.Text = " ";
            txtMultiplier.Text = " ";
            //This is to remove the text in the text boxes
            lblResult.Text = " ";

            //This is to set the cursor to the top of the first text box
            txtNumber.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //This is converting the text in the textboxes to integers
            int operand1 = Convert.ToInt32(txtNumber.Text);
            int operand2 = Convert.ToInt32(txtMultiplier.Text);

            //This is calculating the answer
            int answer = operand1 * operand2;

            //This displays the answer in the label
            lblResult.Text = answer.ToString();
        }
    }
}
