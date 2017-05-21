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
    public partial class Teacher : Form
    {
        private GlobalClass.userTableMapper selectedUser;
        public void setUser(GlobalClass.userTableMapper sU)
        {
            this.selectedUser = sU;
            this.Text = this.selectedUser.reprUser;
        }
        public Teacher()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
            this.dataGridView1.ContextMenuStrip = this.contextMenuDG;
        }

        private void Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {

            ForDeeploma.GlobalClass.decrementCounter();
        }

    }
}
