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
    public partial class Form1 : Form
    {
        private BindingList<GlobalClass.userTableMapper> usersLogin;
        DBConnect elementBase = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
            usersLogin = elementBase.SelectUsers();
            LoginSelector.DataSource = usersLogin;
            LoginSelector.DisplayMember = "reprUser";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            GlobalClass.userTableMapper selectedUser = ((GlobalClass.userTableMapper)LoginSelector.SelectedItem);
            string userHash = selectedUser.MD5HashPass;
            string userPass = passwdInput.Text;
            if (GlobalClass.VerifyMd5Hash(userPass, userHash)) {
                GlobalClass.userRoleMapper SelectedRole = elementBase.roleSelectedUser(selectedUser.ID);
                if (SelectedRole.Admin)
                {
                    Admin admin = new Admin();
                    admin.setUser(selectedUser);
                    admin.Show();
                    this.Close();
                }
                else if (SelectedRole.AllowWrite)
                {
                    Teacher teacher = new Teacher();
                    teacher.Show();
                    this.Close();
                }
                else if(SelectedRole.AllowRead){
                    Student student = new Student();
                    student.Show();
                    this.Close();
                }
                
            }
            else
            {
                this.LoginError.Text = "Неверный пароль. Попробуйте ввести пароль заново или выберите другого пользователя";
                this.LoginError.ForeColor = Color.Red;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
