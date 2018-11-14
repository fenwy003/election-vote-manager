using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingManager
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

private void CSVButton_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to proceed with manual mode, if yes then open the manual mode form
            if (MessageBox.Show("In this mode, you are required to import a CSV file which contains the required voting data.", "Preferential Voting Manager: CSV Mode",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {        
                this.Hide();
                new CSVModeForm().Show();
            }
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to proceed with manual mode, if yes then open the manual mode form
            if (MessageBox.Show("In this mode, you are required to manually enter all the voting data.", "Preferential Voting Manager: Manual Mode",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new ManualModeForm().Show();
            }
        }
    }
}
