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
        private System.Windows.Forms.DataGridView AdminGridView;
        private DataGridViewCellEventArgs mouseLocation;
        DBConnect elementBase = new DBConnect();
        private int selectedTab;
        public Admin()
        {
            InitializeComponent();
        }
        public void setUser(GlobalClass.userTableMapper sU){
            this.selectedUser = sU;
            this.Text = this.selectedUser.reprUser;
        }
        private void generateTable()
        {
            if (this.PanelLayout.Controls.Contains(this.AdminGridView))
            {
                this.AdminGridView.CellMouseEnter -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
                this.PanelLayout.Controls.Remove(this.AdminGridView);
                this.AdminGridView.Dispose();

            }
            this.AdminGridView = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGridView)).BeginInit();
            this.AdminGridView.AllowUserToOrderColumns = true;
            this.AdminGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.AdminGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminGridView.Location = new System.Drawing.Point(12, 27);
            this.AdminGridView.Name = "AdminGridView";
            this.AdminGridView.Size = new System.Drawing.Size(625, 266);
            this.AdminGridView.TabIndex = 1;
            this.AdminGridView.AllowUserToAddRows = false;
            this.AdminGridView.AllowUserToDeleteRows = false;
            this.AdminGridView.AllowUserToResizeColumns = false;
            this.AdminGridView.AllowUserToResizeRows = false;
            this.AdminGridView.RowTemplate.ContextMenuStrip = this.contextData;
            this.AdminGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
            this.PanelLayout.Controls.Add(this.AdminGridView);
            ((System.ComponentModel.ISupportInitialize)(this.AdminGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedTab = 0;
            this.generateTable();
            this.AdminGridView.DataSource = this.elementBase.SelectUsersInfo(this.selectedUser.ID);
            this.AdminGridView.Columns["ID"].Visible = false;
        }
        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedTab = 1;
            this.generateTable();
            this.AdminGridView.DataSource = this.elementBase.SelectGroupsInfo();
            this.AdminGridView.Columns["ID"].Visible = false;
        }
        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedTab = 2;
            this.generateTable();
            this.AdminGridView.DataSource = this.elementBase.SelectRolesInfo();
            this.AdminGridView.Columns["ID"].Visible = false;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.selectedTab == 0)
            {
                AddUser newUser = new AddUser();
                newUser.ShowDialog(this);
                this.generateTable();
                this.AdminGridView.DataSource = this.elementBase.SelectUsersInfo(this.selectedUser.ID);
                this.AdminGridView.Columns["ID"].Visible = false;
            }
            else if (this.selectedTab == 1)
            {
                Groups newGroup = new Groups();
                newGroup.ShowDialog(this);
                this.generateTable();
                this.AdminGridView.DataSource = this.elementBase.SelectGroupsInfo();
                this.AdminGridView.Columns["ID"].Visible = false;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)//це изменить
        {
            if (this.selectedTab == 0)
            {
                int rowId = (int)((long)AdminGridView.Rows[this.mouseLocation.RowIndex].Cells["ID"].Value);
                AddUser newUser = new AddUser(rowId);
                newUser.ShowDialog(this);
                this.generateTable();
                this.AdminGridView.DataSource = this.elementBase.SelectUsersInfo(this.selectedUser.ID);
                this.AdminGridView.Columns["ID"].Visible = false;
            }
            else if (this.selectedTab == 1)
            {
                int rowId = (int)((long)AdminGridView.Rows[this.mouseLocation.RowIndex].Cells["ID"].Value);
                Groups newGroup = new Groups(rowId);
                newGroup.ShowDialog(this);
                this.generateTable();
                this.AdminGridView.DataSource = this.elementBase.SelectGroupsInfo();
                this.AdminGridView.Columns["ID"].Visible = false;
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.selectedTab == 0)
            {
                int rowId = (int)((long)AdminGridView.Rows[this.mouseLocation.RowIndex].Cells["ID"].Value);
                elementBase.DeleteUser(rowId);
                this.generateTable();
                this.AdminGridView.DataSource = this.elementBase.SelectUsersInfo(this.selectedUser.ID);
                this.AdminGridView.Columns["ID"].Visible = false;
            }
        }
        private void dataGridView_CellMouseEnter(object sender,DataGridViewCellEventArgs location)
        {
            this.mouseLocation = location;
        }
    }
}
