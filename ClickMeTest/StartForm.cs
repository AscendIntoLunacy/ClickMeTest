using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMeTest
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = (MessageLabel.Text == "Hello!") ? "Good Bye!" : "Hello!";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            NextForm nextForm = new NextForm();
            // Save a reference to the current form in a property of the next formForm
            nextForm.previousForm = this;
            // Show the next form
            nextForm.Show();
            // Hide this Form
            this.Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
