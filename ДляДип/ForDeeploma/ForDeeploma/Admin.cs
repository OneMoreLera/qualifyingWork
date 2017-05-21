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
    public partial class Admin : Form
    {
        private GlobalClass.userTableMapper selectedUser;
        public Admin()
        {
            InitializeComponent();
        }
        public void setUser(GlobalClass.userTableMapper sU){
            this.selectedUser = sU;
            this.Text = this.selectedUser.reprUser;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 LoginWin = new Form1();
            LoginWin.Show();
            this.Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser Adding = new AddUser();
            Adding.Show();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Groups AddGroups = new Groups();
            AddGroups.Show();
        }

        

    }
}
