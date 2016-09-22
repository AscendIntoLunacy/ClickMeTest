using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMeTest
{
    public partial class NextForm : Form
    {
        // Declare a property that has the shapre of the previous form
        public StartForm previousForm { get; set; }

        public NextForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Show previous form
            this.previousForm.Show();
            // Close NextForm
            this.Close();
        }
    }
}
