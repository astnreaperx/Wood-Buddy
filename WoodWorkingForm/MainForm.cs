using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorkingForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectForm project = new ProjectForm();
            project.Show();
        }

        private void projectListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectListForm projectForm = new ProjectListForm();
            projectForm.Show();
        }
    }
}
