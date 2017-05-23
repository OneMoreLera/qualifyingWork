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
    public partial class AddUser : Form
    {
        private int userId;
        private BindingList<GlobalClass.userGroupMapper>  groupList;
        private GlobalClass.userCreateMapper AlteringUser;
        DBConnect elementBase = new DBConnect();
        Boolean newUser;
        public AddUser()
        {
            InitializeComponent();
            newUser = true;
        }
        public AddUser(int _Id)
        {
            InitializeComponent();
            this.userId = _Id;
            newUser = false;
        }

        private void AlterUser()
        {
            AlteringUser = elementBase.SelectUserWhere(this.userId);
            this.SurnameT.Text = AlteringUser.Surname;
            this.NameT.Text = AlteringUser.Name;
            this.PatronymT.Text = AlteringUser.Patronim;
            this.groupSelector.SelectedValue = AlteringUser.id_group;

        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
            groupList = elementBase.SelectGroups();
            groupSelector.DataSource = groupList;
            groupSelector.DisplayMember = "Name";
            groupSelector.ValueMember = "ID";
            if (!this.newUser) this.AlterUser();
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlteringUser.Surname = this.SurnameT.Text;
            AlteringUser.Name = this.NameT.Text;
            AlteringUser.Patronim = this.PatronymT.Text;
            AlteringUser.id_group = (int)this.groupSelector.SelectedValue;
            elementBase.UpdateUser(AlteringUser);
            this.Close();
        }
    }
}
