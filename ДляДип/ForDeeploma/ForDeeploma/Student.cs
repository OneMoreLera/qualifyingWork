using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDeeploma
{
    public partial class Student : Form
    {
        private GlobalClass.userTableMapper selectedUser;
        public void setUser(GlobalClass.userTableMapper sU)
        {
            this.selectedUser = sU;
            this.Text = this.selectedUser.reprUser;
        }
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void пройденныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 LoginWin = new Form1();
            LoginWin.Show();
            this.Close();
        }

        private void порядокПрохожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutWin = new About();
            AboutWin.Show();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramm AboutPr = new AboutProgramm();
            AboutPr.Show();
        }
    }
}
