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
        private void Teacher_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {

            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void добавитьПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSubject Adding = new NewSubject();
            Adding.ShowDialog();
        }
        
    }
}
