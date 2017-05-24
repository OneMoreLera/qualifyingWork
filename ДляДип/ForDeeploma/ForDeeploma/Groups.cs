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
    public partial class Groups : Form
    {
        private int GroupId;
        private BindingList<GlobalClass.classifMapper> rolesList;
        private GlobalClass.GroupsCreateMapper AlteringRole;
        DBConnect elementBase = new DBConnect();
        Boolean newGroup;
        public Groups()
        {
            InitializeComponent();
            newGroup = true;
        }
        public Groups(int _Id)
        {
            InitializeComponent();
            this.GroupId = _Id;
            newGroup = false;
        }

        private void AlterGroup()
        {
            AlteringRole = elementBase.SelectRoleWhere(this.GroupId);
            this.NameT.Text = AlteringRole.Name;
            this.DescriptionT.Text = AlteringRole.Description;
            this.rolesSelector.SelectedValue = AlteringRole.id_role;
        }
        private void Groups_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
            rolesList = elementBase.SelectRoles();
            rolesSelector.DataSource = rolesList;
            rolesSelector.DisplayMember = "Name";
            rolesSelector.ValueMember = "ID";
            if (!this.newGroup) this.AlterGroup();
        }

        private void Groups_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
